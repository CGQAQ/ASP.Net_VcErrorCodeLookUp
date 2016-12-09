namespace VC__6._0ERRLookup
{
    partial class Form1
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
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.lbxResultList = new System.Windows.Forms.ListBox();
            this.tbxInfo = new System.Windows.Forms.TextBox();
            this.lleLink = new System.Windows.Forms.LinkLabel();
            this.lblLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxInput.Location = new System.Drawing.Point(12, 32);
            this.tbxInput.MaxLength = 5;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(150, 21);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.Tag = "请输入VC++6.0中的错误码";
            this.tbxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(168, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(19, 9);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(143, 12);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "请输入VC++6.0中的错误码";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxResultList
            // 
            this.lbxResultList.FormattingEnabled = true;
            this.lbxResultList.ItemHeight = 12;
            this.lbxResultList.Location = new System.Drawing.Point(12, 73);
            this.lbxResultList.Name = "lbxResultList";
            this.lbxResultList.Size = new System.Drawing.Size(231, 268);
            this.lbxResultList.TabIndex = 4;
            this.lbxResultList.Visible = false;
            this.lbxResultList.DoubleClick += new System.EventHandler(this.lbxResultList_DoubleClick);
            // 
            // tbxInfo
            // 
            this.tbxInfo.Location = new System.Drawing.Point(287, 73);
            this.tbxInfo.Multiline = true;
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.Size = new System.Drawing.Size(285, 234);
            this.tbxInfo.TabIndex = 5;
            // 
            // lleLink
            // 
            this.lleLink.Location = new System.Drawing.Point(366, 310);
            this.lleLink.MaximumSize = new System.Drawing.Size(287, 31);
            this.lleLink.Name = "lleLink";
            this.lleLink.Size = new System.Drawing.Size(206, 31);
            this.lleLink.TabIndex = 6;
            this.lleLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lleLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lleLink_LinkClicked);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(287, 310);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(77, 12);
            this.lblLink.TabIndex = 7;
            this.lblLink.Text = "详情请访问：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lleLink);
            this.Controls.Add(this.tbxInfo);
            this.Controls.Add(this.lbxResultList);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxInput);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VC++6.0 error lookup tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ListBox lbxResultList;
        private System.Windows.Forms.TextBox tbxInfo;
        private System.Windows.Forms.LinkLabel lleLink;
        private System.Windows.Forms.Label lblLink;
    }
}

