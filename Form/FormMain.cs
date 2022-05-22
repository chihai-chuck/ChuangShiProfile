using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net;
using System.Drawing;
using System.Threading;
using System.Reflection;
using System.Resources;

namespace ChuangShiProfile {
    public partial class FormMain : Form {
        private int _requestNum = 0;
        private short _requestPage = 1;

        private delegate string FansData(); // 异步请求数据

        // 粉丝排行榜JSON实体类
        public class FansRankJson {
            public long uid { get; }
            public string icon { get; }
            public string title { get; }
            public long num { get; }
            public string nick { get; }
            public int pos { get; }
        }

        // 用于自动关联资源文件中的dll文件（dll文件是项目中使用的第三方库），以让生成exe无需附带dll文件即可正常运行
        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args) {
            var dllName = args.Name.Contains(",") ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name.Replace(".dll", "");
            dllName = dllName.Replace(".", "_");
            if (dllName.EndsWith("_resources")) {
                return null;
            }
            var rm = new ResourceManager(GetType().Namespace + ".Properties.Resources", Assembly.GetExecutingAssembly());
            var bytes = (byte[])rm.GetObject(dllName);
            return Assembly.Load(bytes);
        }

        public FormMain() {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve); // 调用dll关联
            Control.CheckForIllegalCrossThreadCalls = false; // 使线程中可以直接更改winform控件属性
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textQQ.Text + textNick.Text)) {
                MessageBox.Show("必须输入QQ号或昵称之一才可进行查询！", "提示");
                return;
            }
            this.Height = 185;
            btnSearch.Enabled = false;
            textQQ.Enabled = false;
            textNick.Enabled = false;
            btnSearch.Text = "查询中...";
            _requestPage = 1;
            _requestNum = 0;

            var findFansDataThread = new Thread(new ThreadStart(FindFansData)) {
                IsBackground = true
            };
            findFansDataThread.Start();
        }

        private void FindFansData() {
            if (_requestPage > 10) {
                this.Height = 185;
                btnSearch.Enabled = true;
                textQQ.Enabled = true;
                textNick.Enabled = true;
                btnSearch.Text = "查询";
                var queryEmpty = string.IsNullOrEmpty(textQQ.Text) || string.IsNullOrEmpty(textNick.Text);
                MessageBox.Show("未查询到对应的用户数据！查询对象可能未在总排行榜前500名，或输入信息有误！" + (queryEmpty ? "也可尝试同时输入QQ号和昵称进行查询，以提高成功率！" : "") + "\n\n(目前仅可查询QQ用户，若查询对象为微信用户，可尝试通过昵称进行查询)");
                return;
            }

            var fansResultData = PostFansData();

            var fansJson = JObject.Parse(fansResultData);
            var fansChildrenList = fansJson["page"]["record"].Children().ToList();

            var isDone = false;

            fansChildrenList.ForEach(i => {
                var searchResult = JsonConvert.DeserializeObject<FansRankJson>(i.ToString());
                _requestNum++;
                lblNum.Text = _requestNum.ToString();
                if (searchResult.uid.ToString() != textQQ.Text && searchResult.nick != textNick.Text) {
                    return;
                }
                isDone = true;
                lblUid.Text = searchResult.uid.ToString();
                lblNick.Text = searchResult.nick;
                lblTitle.Text = searchResult.title;
                lblFans.Text = searchResult.num.ToString();
                lblRank.Text = searchResult.pos.ToString();
                var imageStream = WebRequest.Create(searchResult.icon).GetResponse().GetResponseStream();
                if (imageStream is null) {
                    pictureCover.Image = Image.FromStream(imageStream);
                }
                this.Height = 375;
                btnSearch.Enabled = true;
                textQQ.Enabled = true;
                textNick.Enabled = true;
                btnSearch.Text = "查询";
            });
            if (isDone) {
                return;
            }
            _requestPage++;
            FindFansData();
        }

        private string PostFansData() {
            var fansAsync = new FansData(FansRequest);
            var fansResult = fansAsync.BeginInvoke(FansCallBack, "");
            return fansAsync.EndInvoke(fansResult);
        }
        
        private string FansRequest() {
            var postParams = new Dictionary<string, string>() {
                {"id", "14041725"}, // 书籍ID
                {"pn", _requestPage.ToString()}, // 页码（无论如何，该接口最多只能获取总排行前500的用户数据，或月、周排行前50的数据）
                {"ps", "50"}, // 每页数量，测试最多一次也只会返回50条
                {"rt", "2"},
                {"lm_f", "fanslist"},
                {"lmh_f", "fanslist"},
                {"tf", "2"},
                {"fp", "1"}
            };
            return HttpHelper.GetResponseString(HttpHelper.CreatePostHttpResponse("http://adr.reader.qq.com/6_3_5/fans/rank", postParams, 20000, null, null));
        }

        private static void FansCallBack(IAsyncResult data) {
            Console.Write(data.AsyncState);
        }
    }
}
