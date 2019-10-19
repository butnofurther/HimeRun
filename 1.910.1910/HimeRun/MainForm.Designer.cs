namespace HimeRun {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.LTitle = new System.Windows.Forms.Label();
            this.TMain = new System.Windows.Forms.TextBox();
            this.LVersion = new System.Windows.Forms.Label();
            this.LFileName = new System.Windows.Forms.Label();
            this.LPath = new System.Windows.Forms.Label();
            this.LFileType = new System.Windows.Forms.Label();
            this.BHide = new System.Windows.Forms.Button();
            this.BRun = new System.Windows.Forms.Button();
            this.LExit = new System.Windows.Forms.Label();
            this.LArguments = new System.Windows.Forms.Label();
            this.PConfig = new System.Windows.Forms.Panel();
            this.PClose = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.BackColor = System.Drawing.SystemColors.Control;
            this.LTitle.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LTitle.Location = new System.Drawing.Point(48, 20);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(106, 28);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "HimeRun";
            // 
            // TMain
            // 
            this.TMain.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TMain.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TMain.Location = new System.Drawing.Point(53, 89);
            this.TMain.Name = "TMain";
            this.TMain.Size = new System.Drawing.Size(396, 33);
            this.TMain.TabIndex = 0;
            this.TMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TMain.TextChanged += new System.EventHandler(this.RunInput);
            // 
            // LVersion
            // 
            this.LVersion.AutoSize = true;
            this.LVersion.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LVersion.Location = new System.Drawing.Point(149, 30);
            this.LVersion.Name = "LVersion";
            this.LVersion.Size = new System.Drawing.Size(100, 16);
            this.LVersion.TabIndex = 0;
            this.LVersion.Text = "Version 1.910.1910";
            // 
            // LFileName
            // 
            this.LFileName.AutoSize = true;
            this.LFileName.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LFileName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LFileName.Location = new System.Drawing.Point(52, 128);
            this.LFileName.MaximumSize = new System.Drawing.Size(300, 0);
            this.LFileName.Name = "LFileName";
            this.LFileName.Size = new System.Drawing.Size(0, 16);
            this.LFileName.TabIndex = 3;
            // 
            // LPath
            // 
            this.LPath.AutoSize = true;
            this.LPath.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LPath.ForeColor = System.Drawing.Color.Gray;
            this.LPath.Location = new System.Drawing.Point(52, 142);
            this.LPath.MaximumSize = new System.Drawing.Size(400, 20);
            this.LPath.Name = "LPath";
            this.LPath.Size = new System.Drawing.Size(0, 16);
            this.LPath.TabIndex = 4;
            // 
            // LFileType
            // 
            this.LFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LFileType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LFileType.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LFileType.ForeColor = System.Drawing.Color.MediumOrchid;
            this.LFileType.Location = new System.Drawing.Point(354, 66);
            this.LFileType.Name = "LFileType";
            this.LFileType.Size = new System.Drawing.Size(100, 23);
            this.LFileType.TabIndex = 5;
            this.LFileType.Text = "[ALL TYPES]";
            this.LFileType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LFileType.Click += new System.EventHandler(this.FileTypeChange);
            // 
            // BHide
            // 
            this.BHide.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BHide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BHide.Location = new System.Drawing.Point(374, 187);
            this.BHide.Name = "BHide";
            this.BHide.Size = new System.Drawing.Size(75, 23);
            this.BHide.TabIndex = 6;
            this.BHide.TabStop = false;
            this.BHide.Text = "Hide";
            this.BHide.UseVisualStyleBackColor = true;
            this.BHide.Click += new System.EventHandler(this.Hide);
            // 
            // BRun
            // 
            this.BRun.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BRun.Location = new System.Drawing.Point(293, 187);
            this.BRun.Name = "BRun";
            this.BRun.Size = new System.Drawing.Size(75, 23);
            this.BRun.TabIndex = 6;
            this.BRun.TabStop = false;
            this.BRun.Text = "Run";
            this.BRun.UseVisualStyleBackColor = true;
            this.BRun.Click += new System.EventHandler(this.Run);
            // 
            // LExit
            // 
            this.LExit.AutoSize = true;
            this.LExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LExit.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LExit.Location = new System.Drawing.Point(50, 194);
            this.LExit.Name = "LExit";
            this.LExit.Size = new System.Drawing.Size(74, 16);
            this.LExit.TabIndex = 0;
            this.LExit.Text = "Exit HimeRun";
            this.LExit.Click += new System.EventHandler(this.Exit);
            // 
            // LArguments
            // 
            this.LArguments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LArguments.Cursor = System.Windows.Forms.Cursors.Default;
            this.LArguments.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LArguments.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LArguments.Location = new System.Drawing.Point(353, 125);
            this.LArguments.Name = "LArguments";
            this.LArguments.Size = new System.Drawing.Size(100, 23);
            this.LArguments.TabIndex = 5;
            this.LArguments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LArguments.Click += new System.EventHandler(this.FileTypeChange);
            // 
            // PConfig
            // 
            this.PConfig.BackgroundImage = global::HimeRun.Properties.Resources.setting;
            this.PConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PConfig.Location = new System.Drawing.Point(438, 12);
            this.PConfig.Name = "PConfig";
            this.PConfig.Size = new System.Drawing.Size(24, 24);
            this.PConfig.TabIndex = 2;
            this.PConfig.Click += new System.EventHandler(this.OptionFormShow);
            // 
            // PClose
            // 
            this.PClose.BackgroundImage = global::HimeRun.Properties.Resources.cross;
            this.PClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PClose.Location = new System.Drawing.Point(468, 12);
            this.PClose.Name = "PClose";
            this.PClose.Size = new System.Drawing.Size(24, 24);
            this.PClose.TabIndex = 1;
            this.PClose.Click += new System.EventHandler(this.Hide);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 238);
            this.Controls.Add(this.BRun);
            this.Controls.Add(this.BHide);
            this.Controls.Add(this.LFileType);
            this.Controls.Add(this.LPath);
            this.Controls.Add(this.LFileName);
            this.Controls.Add(this.PConfig);
            this.Controls.Add(this.PClose);
            this.Controls.Add(this.TMain);
            this.Controls.Add(this.LExit);
            this.Controls.Add(this.LVersion);
            this.Controls.Add(this.LTitle);
            this.Controls.Add(this.LArguments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.Deactivate += new System.EventHandler(this.Hide);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TMainKeyWatch);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.TextBox TMain;
        private System.Windows.Forms.Label LVersion;
        private System.Windows.Forms.Panel PClose;
        private System.Windows.Forms.Panel PConfig;
        private System.Windows.Forms.Label LFileName;
        private System.Windows.Forms.Label LPath;
        private System.Windows.Forms.Label LFileType;
        private System.Windows.Forms.Button BHide;
        private System.Windows.Forms.Button BRun;
        private System.Windows.Forms.Label LExit;
        private System.Windows.Forms.Label LArguments;
    }
}

