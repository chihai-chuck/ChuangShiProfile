namespace ChuangShiProfile
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textQQ = new System.Windows.Forms.TextBox();
            this.lblSearchQQ = new System.Windows.Forms.Label();
            this.lblSearchNick = new System.Windows.Forms.Label();
            this.textNick = new System.Windows.Forms.TextBox();
            this.lblTips = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNumTips = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.groupProfile = new System.Windows.Forms.GroupBox();
            this.pictureCover = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleCaption = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblRankCaption = new System.Windows.Forms.Label();
            this.lblFans = new System.Windows.Forms.Label();
            this.lblFansCaption = new System.Windows.Forms.Label();
            this.lblNick = new System.Windows.Forms.Label();
            this.lblNickCaption = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();
            this.lblUidCaption = new System.Windows.Forms.Label();
            this.lblSearchTips = new System.Windows.Forms.Label();
            this.groupProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).BeginInit();
            this.SuspendLayout();
            // 
            // textQQ
            // 
            this.textQQ.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textQQ.Location = new System.Drawing.Point(67, 17);
            this.textQQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textQQ.MaxLength = 30;
            this.textQQ.Name = "textQQ";
            this.textQQ.Size = new System.Drawing.Size(236, 23);
            this.textQQ.TabIndex = 0;
            // 
            // lblSearchQQ
            // 
            this.lblSearchQQ.AutoSize = true;
            this.lblSearchQQ.Location = new System.Drawing.Point(12, 20);
            this.lblSearchQQ.Name = "lblSearchQQ";
            this.lblSearchQQ.Size = new System.Drawing.Size(52, 17);
            this.lblSearchQQ.TabIndex = 1;
            this.lblSearchQQ.Text = "QQ号：";
            // 
            // lblSearchNick
            // 
            this.lblSearchNick.AutoSize = true;
            this.lblSearchNick.Location = new System.Drawing.Point(12, 51);
            this.lblSearchNick.Name = "lblSearchNick";
            this.lblSearchNick.Size = new System.Drawing.Size(44, 17);
            this.lblSearchNick.TabIndex = 3;
            this.lblSearchNick.Text = "昵称：";
            // 
            // textNick
            // 
            this.textNick.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.textNick.Location = new System.Drawing.Point(67, 48);
            this.textNick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNick.MaxLength = 100;
            this.textNick.Name = "textNick";
            this.textNick.Size = new System.Drawing.Size(236, 23);
            this.textNick.TabIndex = 1;
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTips.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTips.Location = new System.Drawing.Point(64, 75);
            this.lblTips.MaximumSize = new System.Drawing.Size(245, 0);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(244, 34);
            this.lblTips.TabIndex = 4;
            this.lblTips.Text = "必须输入QQ号或昵称之一，若两种都输入，可提高搜索成功率！";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(312, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 54);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNumTips
            // 
            this.lblNumTips.AutoSize = true;
            this.lblNumTips.Location = new System.Drawing.Point(12, 118);
            this.lblNumTips.Name = "lblNumTips";
            this.lblNumTips.Size = new System.Drawing.Size(80, 17);
            this.lblNumTips.TabIndex = 6;
            this.lblNumTips.Text = "已搜索数量：";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(90, 118);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(15, 17);
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "0";
            // 
            // groupProfile
            // 
            this.groupProfile.Controls.Add(this.pictureCover);
            this.groupProfile.Controls.Add(this.lblTitle);
            this.groupProfile.Controls.Add(this.lblTitleCaption);
            this.groupProfile.Controls.Add(this.lblRank);
            this.groupProfile.Controls.Add(this.lblRankCaption);
            this.groupProfile.Controls.Add(this.lblFans);
            this.groupProfile.Controls.Add(this.lblFansCaption);
            this.groupProfile.Controls.Add(this.lblNick);
            this.groupProfile.Controls.Add(this.lblNickCaption);
            this.groupProfile.Controls.Add(this.lblUid);
            this.groupProfile.Controls.Add(this.lblUidCaption);
            this.groupProfile.Location = new System.Drawing.Point(12, 147);
            this.groupProfile.Name = "groupProfile";
            this.groupProfile.Size = new System.Drawing.Size(415, 177);
            this.groupProfile.TabIndex = 9;
            this.groupProfile.TabStop = false;
            this.groupProfile.Text = "用户信息";
            // 
            // pictureCover
            // 
            this.pictureCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureCover.Location = new System.Drawing.Point(300, 22);
            this.pictureCover.Name = "pictureCover";
            this.pictureCover.Size = new System.Drawing.Size(100, 100);
            this.pictureCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCover.TabIndex = 10;
            this.pictureCover.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(72, 86);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 17);
            this.lblTitle.TabIndex = 9;
            // 
            // lblTitleCaption
            // 
            this.lblTitleCaption.AutoSize = true;
            this.lblTitleCaption.Location = new System.Drawing.Point(19, 86);
            this.lblTitleCaption.Name = "lblTitleCaption";
            this.lblTitleCaption.Size = new System.Drawing.Size(44, 17);
            this.lblTitleCaption.TabIndex = 8;
            this.lblTitleCaption.Text = "称号：";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(72, 144);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(0, 17);
            this.lblRank.TabIndex = 7;
            // 
            // lblRankCaption
            // 
            this.lblRankCaption.AutoSize = true;
            this.lblRankCaption.Location = new System.Drawing.Point(19, 144);
            this.lblRankCaption.Name = "lblRankCaption";
            this.lblRankCaption.Size = new System.Drawing.Size(56, 17);
            this.lblRankCaption.TabIndex = 6;
            this.lblRankCaption.Text = "总排名：";
            // 
            // lblFans
            // 
            this.lblFans.AutoSize = true;
            this.lblFans.Location = new System.Drawing.Point(72, 115);
            this.lblFans.Name = "lblFans";
            this.lblFans.Size = new System.Drawing.Size(0, 17);
            this.lblFans.TabIndex = 5;
            // 
            // lblFansCaption
            // 
            this.lblFansCaption.AutoSize = true;
            this.lblFansCaption.Location = new System.Drawing.Point(19, 115);
            this.lblFansCaption.Name = "lblFansCaption";
            this.lblFansCaption.Size = new System.Drawing.Size(56, 17);
            this.lblFansCaption.TabIndex = 4;
            this.lblFansCaption.Text = "粉丝值：";
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(72, 57);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(0, 17);
            this.lblNick.TabIndex = 3;
            // 
            // lblNickCaption
            // 
            this.lblNickCaption.AutoSize = true;
            this.lblNickCaption.Location = new System.Drawing.Point(19, 57);
            this.lblNickCaption.Name = "lblNickCaption";
            this.lblNickCaption.Size = new System.Drawing.Size(44, 17);
            this.lblNickCaption.TabIndex = 2;
            this.lblNickCaption.Text = "昵称：";
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Location = new System.Drawing.Point(72, 28);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(0, 17);
            this.lblUid.TabIndex = 1;
            // 
            // lblUidCaption
            // 
            this.lblUidCaption.AutoSize = true;
            this.lblUidCaption.Location = new System.Drawing.Point(19, 28);
            this.lblUidCaption.Name = "lblUidCaption";
            this.lblUidCaption.Size = new System.Drawing.Size(42, 17);
            this.lblUidCaption.TabIndex = 0;
            this.lblUidCaption.Text = "UID：";
            // 
            // lblSearchTips
            // 
            this.lblSearchTips.AutoSize = true;
            this.lblSearchTips.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSearchTips.Location = new System.Drawing.Point(312, 79);
            this.lblSearchTips.MaximumSize = new System.Drawing.Size(120, 0);
            this.lblSearchTips.Name = "lblSearchTips";
            this.lblSearchTips.Size = new System.Drawing.Size(116, 34);
            this.lblSearchTips.TabIndex = 10;
            this.lblSearchTips.Text = "此工具目前只可查询总榜前500名的用户";
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(444, 146);
            this.Controls.Add(this.lblSearchTips);
            this.Controls.Add(this.groupProfile);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblNumTips);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.lblSearchNick);
            this.Controls.Add(this.textNick);
            this.Controls.Add(this.lblSearchQQ);
            this.Controls.Add(this.textQQ);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "《升棺发财》书友信息查询工具";
            this.groupProfile.ResumeLayout(false);
            this.groupProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textQQ;
        private System.Windows.Forms.Label lblSearchQQ;
        private System.Windows.Forms.Label lblSearchNick;
        private System.Windows.Forms.TextBox textNick;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblNumTips;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.GroupBox groupProfile;
        private System.Windows.Forms.Label lblUidCaption;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleCaption;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblRankCaption;
        private System.Windows.Forms.Label lblFans;
        private System.Windows.Forms.Label lblFansCaption;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.Label lblNickCaption;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.PictureBox pictureCover;
        private System.Windows.Forms.Label lblSearchTips;
    }
}

