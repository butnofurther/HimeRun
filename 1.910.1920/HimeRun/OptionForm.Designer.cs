namespace HimeRun {
    partial class OptionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.TPConfig = new System.Windows.Forms.TabPage();
            this.BSubmit = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BReload = new System.Windows.Forms.Button();
            this.PConfig = new System.Windows.Forms.Panel();
            this.CheckBoxWebSearch = new System.Windows.Forms.CheckBox();
            this.CheckBoxStartUp = new System.Windows.Forms.CheckBox();
            this.ComboBoxShowPosition = new System.Windows.Forms.ComboBox();
            this.ComboBoxSearchAfterHowManyCharInputed = new System.Windows.Forms.ComboBox();
            this.ComboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.ComboBoxWebSearchEngine = new System.Windows.Forms.ComboBox();
            this.ComboBoxAutoFetchTime = new System.Windows.Forms.ComboBox();
            this.ComboBoxHotKey1 = new System.Windows.Forms.ComboBox();
            this.ComboBoxHotKey0 = new System.Windows.Forms.ComboBox();
            this.LShowPosition = new System.Windows.Forms.Label();
            this.LLanguage = new System.Windows.Forms.Label();
            this.LSearchAfterHowManyCharInputed = new System.Windows.Forms.Label();
            this.LSearchEngine = new System.Windows.Forms.Label();
            this.LHotKeyPlus = new System.Windows.Forms.Label();
            this.AutoFetchTime = new System.Windows.Forms.Label();
            this.LHotKey = new System.Windows.Forms.Label();
            this.TPFetching = new System.Windows.Forms.TabPage();
            this.ListViewFetching = new System.Windows.Forms.ListView();
            this.ColHeadDir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadFileTypes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenuFetching = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeFileTypesToFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPRecord = new System.Windows.Forms.TabPage();
            this.ListViewFetchRecord = new System.Windows.Forms.ListView();
            this.ColHeadTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadSecUsed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TPFileList = new System.Windows.Forms.TabPage();
            this.ListViewFiles = new System.Windows.Forms.ListView();
            this.ColHeadFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadDiscrib = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadPinyin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadRunCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadArguments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenuFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editRunArgumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPRunRecord = new System.Windows.Forms.TabPage();
            this.ListViewRunRecord = new System.Windows.Forms.ListView();
            this.ColHeadRunTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TPBAT = new System.Windows.Forms.TabPage();
            this.ListViewCommand = new System.Windows.Forms.ListView();
            this.ColHeadCommand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadCommandDiscrib = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHeadCommandContext = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenuCommand = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadTimer = new System.Windows.Forms.Timer(this.components);
            this.LWebsite = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.TPConfig.SuspendLayout();
            this.PConfig.SuspendLayout();
            this.TPFetching.SuspendLayout();
            this.ContextMenuFetching.SuspendLayout();
            this.TPRecord.SuspendLayout();
            this.TPFileList.SuspendLayout();
            this.ContextMenuFiles.SuspendLayout();
            this.TPRunRecord.SuspendLayout();
            this.TPBAT.SuspendLayout();
            this.ContextMenuCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.TPConfig);
            this.MainTabControl.Controls.Add(this.TPFetching);
            this.MainTabControl.Controls.Add(this.TPRecord);
            this.MainTabControl.Controls.Add(this.TPFileList);
            this.MainTabControl.Controls.Add(this.TPRunRecord);
            this.MainTabControl.Controls.Add(this.TPBAT);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(816, 468);
            this.MainTabControl.TabIndex = 0;
            // 
            // TPConfig
            // 
            this.TPConfig.Controls.Add(this.BSubmit);
            this.TPConfig.Controls.Add(this.BExit);
            this.TPConfig.Controls.Add(this.button2);
            this.TPConfig.Controls.Add(this.BReload);
            this.TPConfig.Controls.Add(this.PConfig);
            this.TPConfig.Location = new System.Drawing.Point(4, 22);
            this.TPConfig.Name = "TPConfig";
            this.TPConfig.Size = new System.Drawing.Size(808, 442);
            this.TPConfig.TabIndex = 3;
            this.TPConfig.Text = "Config";
            this.TPConfig.UseVisualStyleBackColor = true;
            // 
            // BSubmit
            // 
            this.BSubmit.Location = new System.Drawing.Point(541, 409);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(75, 23);
            this.BSubmit.TabIndex = 1;
            this.BSubmit.Text = "Confirm";
            this.BSubmit.UseVisualStyleBackColor = true;
            this.BSubmit.Click += new System.EventHandler(this.ConfigConfirm);
            // 
            // BExit
            // 
            this.BExit.Location = new System.Drawing.Point(8, 409);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(75, 23);
            this.BExit.TabIndex = 1;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.Exit);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ConfigHide);
            // 
            // BReload
            // 
            this.BReload.Location = new System.Drawing.Point(725, 409);
            this.BReload.Name = "BReload";
            this.BReload.Size = new System.Drawing.Size(75, 23);
            this.BReload.TabIndex = 1;
            this.BReload.Text = "Refetch";
            this.BReload.UseVisualStyleBackColor = true;
            this.BReload.Click += new System.EventHandler(this.Refetch);
            // 
            // PConfig
            // 
            this.PConfig.BackColor = System.Drawing.Color.FloralWhite;
            this.PConfig.Controls.Add(this.CheckBoxWebSearch);
            this.PConfig.Controls.Add(this.CheckBoxStartUp);
            this.PConfig.Controls.Add(this.ComboBoxShowPosition);
            this.PConfig.Controls.Add(this.ComboBoxSearchAfterHowManyCharInputed);
            this.PConfig.Controls.Add(this.ComboBoxLanguage);
            this.PConfig.Controls.Add(this.ComboBoxWebSearchEngine);
            this.PConfig.Controls.Add(this.ComboBoxAutoFetchTime);
            this.PConfig.Controls.Add(this.ComboBoxHotKey1);
            this.PConfig.Controls.Add(this.ComboBoxHotKey0);
            this.PConfig.Controls.Add(this.LShowPosition);
            this.PConfig.Controls.Add(this.LWebsite);
            this.PConfig.Controls.Add(this.LLanguage);
            this.PConfig.Controls.Add(this.LSearchAfterHowManyCharInputed);
            this.PConfig.Controls.Add(this.LSearchEngine);
            this.PConfig.Controls.Add(this.LHotKeyPlus);
            this.PConfig.Controls.Add(this.AutoFetchTime);
            this.PConfig.Controls.Add(this.LHotKey);
            this.PConfig.Location = new System.Drawing.Point(3, 3);
            this.PConfig.Name = "PConfig";
            this.PConfig.Size = new System.Drawing.Size(802, 395);
            this.PConfig.TabIndex = 0;
            // 
            // CheckBoxWebSearch
            // 
            this.CheckBoxWebSearch.AutoSize = true;
            this.CheckBoxWebSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBoxWebSearch.Location = new System.Drawing.Point(427, 109);
            this.CheckBoxWebSearch.Name = "CheckBoxWebSearch";
            this.CheckBoxWebSearch.Size = new System.Drawing.Size(230, 21);
            this.CheckBoxWebSearch.TabIndex = 2;
            this.CheckBoxWebSearch.Text = "Enable Ctrl + Enter Search on Web";
            this.CheckBoxWebSearch.UseVisualStyleBackColor = true;
            // 
            // CheckBoxStartUp
            // 
            this.CheckBoxStartUp.AutoSize = true;
            this.CheckBoxStartUp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBoxStartUp.Location = new System.Drawing.Point(55, 109);
            this.CheckBoxStartUp.Name = "CheckBoxStartUp";
            this.CheckBoxStartUp.Size = new System.Drawing.Size(181, 21);
            this.CheckBoxStartUp.TabIndex = 2;
            this.CheckBoxStartUp.Text = "Start when Windows Login";
            this.CheckBoxStartUp.UseVisualStyleBackColor = true;
            // 
            // ComboBoxShowPosition
            // 
            this.ComboBoxShowPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxShowPosition.FormattingEnabled = true;
            this.ComboBoxShowPosition.Items.AddRange(new object[] {
            "Left-Top",
            "Right-Top",
            "Left-Bottom",
            "Right-Bottom",
            "Screen-Center"});
            this.ComboBoxShowPosition.Location = new System.Drawing.Point(155, 69);
            this.ComboBoxShowPosition.Name = "ComboBoxShowPosition";
            this.ComboBoxShowPosition.Size = new System.Drawing.Size(206, 20);
            this.ComboBoxShowPosition.TabIndex = 1;
            // 
            // ComboBoxSearchAfterHowManyCharInputed
            // 
            this.ComboBoxSearchAfterHowManyCharInputed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSearchAfterHowManyCharInputed.FormattingEnabled = true;
            this.ComboBoxSearchAfterHowManyCharInputed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ComboBoxSearchAfterHowManyCharInputed.Location = new System.Drawing.Point(544, 69);
            this.ComboBoxSearchAfterHowManyCharInputed.Name = "ComboBoxSearchAfterHowManyCharInputed";
            this.ComboBoxSearchAfterHowManyCharInputed.Size = new System.Drawing.Size(63, 20);
            this.ComboBoxSearchAfterHowManyCharInputed.TabIndex = 1;
            // 
            // ComboBoxLanguage
            // 
            this.ComboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLanguage.FormattingEnabled = true;
            this.ComboBoxLanguage.Items.AddRange(new object[] {
            "English",
            "中文(简体)"});
            this.ComboBoxLanguage.Location = new System.Drawing.Point(527, 147);
            this.ComboBoxLanguage.Name = "ComboBoxLanguage";
            this.ComboBoxLanguage.Size = new System.Drawing.Size(206, 20);
            this.ComboBoxLanguage.TabIndex = 1;
            // 
            // ComboBoxWebSearchEngine
            // 
            this.ComboBoxWebSearchEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxWebSearchEngine.FormattingEnabled = true;
            this.ComboBoxWebSearchEngine.Items.AddRange(new object[] {
            "Google",
            "Baidu"});
            this.ComboBoxWebSearchEngine.Location = new System.Drawing.Point(155, 147);
            this.ComboBoxWebSearchEngine.Name = "ComboBoxWebSearchEngine";
            this.ComboBoxWebSearchEngine.Size = new System.Drawing.Size(206, 20);
            this.ComboBoxWebSearchEngine.TabIndex = 1;
            // 
            // ComboBoxAutoFetchTime
            // 
            this.ComboBoxAutoFetchTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAutoFetchTime.FormattingEnabled = true;
            this.ComboBoxAutoFetchTime.Location = new System.Drawing.Point(564, 31);
            this.ComboBoxAutoFetchTime.Name = "ComboBoxAutoFetchTime";
            this.ComboBoxAutoFetchTime.Size = new System.Drawing.Size(169, 20);
            this.ComboBoxAutoFetchTime.TabIndex = 1;
            // 
            // ComboBoxHotKey1
            // 
            this.ComboBoxHotKey1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxHotKey1.FormattingEnabled = true;
            this.ComboBoxHotKey1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.ComboBoxHotKey1.Location = new System.Drawing.Point(256, 31);
            this.ComboBoxHotKey1.Name = "ComboBoxHotKey1";
            this.ComboBoxHotKey1.Size = new System.Drawing.Size(105, 20);
            this.ComboBoxHotKey1.TabIndex = 1;
            // 
            // ComboBoxHotKey0
            // 
            this.ComboBoxHotKey0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxHotKey0.FormattingEnabled = true;
            this.ComboBoxHotKey0.Items.AddRange(new object[] {
            "Win",
            "Ctrl",
            "Alt",
            "Shift",
            "[Nothing]"});
            this.ComboBoxHotKey0.Location = new System.Drawing.Point(123, 31);
            this.ComboBoxHotKey0.Name = "ComboBoxHotKey0";
            this.ComboBoxHotKey0.Size = new System.Drawing.Size(105, 20);
            this.ComboBoxHotKey0.TabIndex = 1;
            // 
            // LShowPosition
            // 
            this.LShowPosition.AutoSize = true;
            this.LShowPosition.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LShowPosition.Location = new System.Drawing.Point(52, 70);
            this.LShowPosition.Name = "LShowPosition";
            this.LShowPosition.Size = new System.Drawing.Size(89, 17);
            this.LShowPosition.TabIndex = 0;
            this.LShowPosition.Text = "Show Position";
            // 
            // LLanguage
            // 
            this.LLanguage.AutoSize = true;
            this.LLanguage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LLanguage.Location = new System.Drawing.Point(424, 149);
            this.LLanguage.Name = "LLanguage";
            this.LLanguage.Size = new System.Drawing.Size(65, 17);
            this.LLanguage.TabIndex = 0;
            this.LLanguage.Text = "Language";
            // 
            // LSearchAfterHowManyCharInputed
            // 
            this.LSearchAfterHowManyCharInputed.AutoSize = true;
            this.LSearchAfterHowManyCharInputed.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LSearchAfterHowManyCharInputed.Location = new System.Drawing.Point(424, 70);
            this.LSearchAfterHowManyCharInputed.Name = "LSearchAfterHowManyCharInputed";
            this.LSearchAfterHowManyCharInputed.Size = new System.Drawing.Size(317, 17);
            this.LSearchAfterHowManyCharInputed.TabIndex = 0;
            this.LSearchAfterHowManyCharInputed.Text = "Start Search after                        Charactors Inputed";
            // 
            // LSearchEngine
            // 
            this.LSearchEngine.AutoSize = true;
            this.LSearchEngine.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LSearchEngine.Location = new System.Drawing.Point(52, 149);
            this.LSearchEngine.Name = "LSearchEngine";
            this.LSearchEngine.Size = new System.Drawing.Size(90, 17);
            this.LSearchEngine.TabIndex = 0;
            this.LSearchEngine.Text = "Search Engine";
            // 
            // LHotKeyPlus
            // 
            this.LHotKeyPlus.AutoSize = true;
            this.LHotKeyPlus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LHotKeyPlus.Location = new System.Drawing.Point(234, 32);
            this.LHotKeyPlus.Name = "LHotKeyPlus";
            this.LHotKeyPlus.Size = new System.Drawing.Size(17, 17);
            this.LHotKeyPlus.TabIndex = 0;
            this.LHotKeyPlus.Text = "+";
            // 
            // AutoFetchTime
            // 
            this.AutoFetchTime.AutoSize = true;
            this.AutoFetchTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AutoFetchTime.Location = new System.Drawing.Point(424, 33);
            this.AutoFetchTime.Name = "AutoFetchTime";
            this.AutoFetchTime.Size = new System.Drawing.Size(119, 17);
            this.AutoFetchTime.TabIndex = 0;
            this.AutoFetchTime.Text = "Auto Fetch Minutes";
            // 
            // LHotKey
            // 
            this.LHotKey.AutoSize = true;
            this.LHotKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LHotKey.Location = new System.Drawing.Point(52, 33);
            this.LHotKey.Name = "LHotKey";
            this.LHotKey.Size = new System.Drawing.Size(60, 17);
            this.LHotKey.TabIndex = 0;
            this.LHotKey.Text = "Hot Keys";
            // 
            // TPFetching
            // 
            this.TPFetching.Controls.Add(this.ListViewFetching);
            this.TPFetching.Location = new System.Drawing.Point(4, 22);
            this.TPFetching.Name = "TPFetching";
            this.TPFetching.Size = new System.Drawing.Size(808, 442);
            this.TPFetching.TabIndex = 0;
            this.TPFetching.Text = "Fetching";
            this.TPFetching.UseVisualStyleBackColor = true;
            // 
            // ListViewFetching
            // 
            this.ListViewFetching.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColHeadDir,
            this.ColHeadFileTypes});
            this.ListViewFetching.ContextMenuStrip = this.ContextMenuFetching;
            this.ListViewFetching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewFetching.FullRowSelect = true;
            this.ListViewFetching.GridLines = true;
            this.ListViewFetching.HideSelection = false;
            this.ListViewFetching.Location = new System.Drawing.Point(0, 0);
            this.ListViewFetching.Name = "ListViewFetching";
            this.ListViewFetching.Size = new System.Drawing.Size(808, 442);
            this.ListViewFetching.TabIndex = 0;
            this.ListViewFetching.UseCompatibleStateImageBehavior = false;
            this.ListViewFetching.View = System.Windows.Forms.View.Details;
            // 
            // ColHeadDir
            // 
            this.ColHeadDir.Text = "Directory";
            this.ColHeadDir.Width = 460;
            // 
            // ColHeadFileTypes
            // 
            this.ColHeadFileTypes.Text = "File Types";
            this.ColHeadFileTypes.Width = 300;
            // 
            // ContextMenuFetching
            // 
            this.ContextMenuFetching.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDirectoryToolStripMenuItem,
            this.removeDirectoryToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.changeFileTypesToFindToolStripMenuItem});
            this.ContextMenuFetching.Name = "ContextMenuFetching";
            this.ContextMenuFetching.Size = new System.Drawing.Size(229, 98);
            // 
            // addDirectoryToolStripMenuItem
            // 
            this.addDirectoryToolStripMenuItem.Name = "addDirectoryToolStripMenuItem";
            this.addDirectoryToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.addDirectoryToolStripMenuItem.Text = "Add Directory";
            this.addDirectoryToolStripMenuItem.Click += new System.EventHandler(this.AddFetchingDirectory);
            // 
            // removeDirectoryToolStripMenuItem
            // 
            this.removeDirectoryToolStripMenuItem.Name = "removeDirectoryToolStripMenuItem";
            this.removeDirectoryToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.removeDirectoryToolStripMenuItem.Text = "Remove Directory";
            this.removeDirectoryToolStripMenuItem.Click += new System.EventHandler(this.RemoveFetchingDirectory);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearFetchingDirectory);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // changeFileTypesToFindToolStripMenuItem
            // 
            this.changeFileTypesToFindToolStripMenuItem.Name = "changeFileTypesToFindToolStripMenuItem";
            this.changeFileTypesToFindToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.changeFileTypesToFindToolStripMenuItem.Text = "Change File Types To Find";
            this.changeFileTypesToFindToolStripMenuItem.Click += new System.EventHandler(this.ChangeFileTypes);
            // 
            // TPRecord
            // 
            this.TPRecord.Controls.Add(this.ListViewFetchRecord);
            this.TPRecord.Location = new System.Drawing.Point(4, 22);
            this.TPRecord.Name = "TPRecord";
            this.TPRecord.Padding = new System.Windows.Forms.Padding(3);
            this.TPRecord.Size = new System.Drawing.Size(808, 442);
            this.TPRecord.TabIndex = 1;
            this.TPRecord.Text = "Fetch Record";
            this.TPRecord.UseVisualStyleBackColor = true;
            // 
            // ListViewFetchRecord
            // 
            this.ListViewFetchRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColHeadTime,
            this.ColHeadPath,
            this.ColHeadFile,
            this.ColHeadSecUsed});
            this.ListViewFetchRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewFetchRecord.FullRowSelect = true;
            this.ListViewFetchRecord.GridLines = true;
            this.ListViewFetchRecord.HideSelection = false;
            this.ListViewFetchRecord.Location = new System.Drawing.Point(3, 3);
            this.ListViewFetchRecord.Name = "ListViewFetchRecord";
            this.ListViewFetchRecord.Size = new System.Drawing.Size(802, 436);
            this.ListViewFetchRecord.TabIndex = 0;
            this.ListViewFetchRecord.UseCompatibleStateImageBehavior = false;
            this.ListViewFetchRecord.View = System.Windows.Forms.View.Details;
            // 
            // ColHeadTime
            // 
            this.ColHeadTime.Text = "Time";
            this.ColHeadTime.Width = 146;
            // 
            // ColHeadPath
            // 
            this.ColHeadPath.Text = "Path";
            this.ColHeadPath.Width = 394;
            // 
            // ColHeadFile
            // 
            this.ColHeadFile.Text = "Indicated Files";
            this.ColHeadFile.Width = 109;
            // 
            // ColHeadSecUsed
            // 
            this.ColHeadSecUsed.Text = "Seconds Used";
            this.ColHeadSecUsed.Width = 120;
            // 
            // TPFileList
            // 
            this.TPFileList.Controls.Add(this.ListViewFiles);
            this.TPFileList.Location = new System.Drawing.Point(4, 22);
            this.TPFileList.Name = "TPFileList";
            this.TPFileList.Padding = new System.Windows.Forms.Padding(3);
            this.TPFileList.Size = new System.Drawing.Size(808, 442);
            this.TPFileList.TabIndex = 2;
            this.TPFileList.Text = "File List";
            this.TPFileList.UseVisualStyleBackColor = true;
            // 
            // ListViewFiles
            // 
            this.ListViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColHeadFilePath,
            this.ColHeadName,
            this.ColHeadExtension,
            this.ColHeadDiscrib,
            this.ColHeadPinyin,
            this.ColHeadRunCount,
            this.ColHeadArguments});
            this.ListViewFiles.ContextMenuStrip = this.ContextMenuFiles;
            this.ListViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewFiles.FullRowSelect = true;
            this.ListViewFiles.GridLines = true;
            this.ListViewFiles.HideSelection = false;
            this.ListViewFiles.Location = new System.Drawing.Point(3, 3);
            this.ListViewFiles.Name = "ListViewFiles";
            this.ListViewFiles.Size = new System.Drawing.Size(802, 436);
            this.ListViewFiles.TabIndex = 0;
            this.ListViewFiles.UseCompatibleStateImageBehavior = false;
            this.ListViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // ColHeadFilePath
            // 
            this.ColHeadFilePath.Text = "Path";
            this.ColHeadFilePath.Width = 232;
            // 
            // ColHeadName
            // 
            this.ColHeadName.Text = "File Name";
            this.ColHeadName.Width = 160;
            // 
            // ColHeadExtension
            // 
            this.ColHeadExtension.Text = "Extension";
            this.ColHeadExtension.Width = 80;
            // 
            // ColHeadDiscrib
            // 
            this.ColHeadDiscrib.Text = "Discrib";
            this.ColHeadDiscrib.Width = 160;
            // 
            // ColHeadPinyin
            // 
            this.ColHeadPinyin.Text = "Pinyin";
            this.ColHeadPinyin.Width = 160;
            // 
            // ColHeadRunCount
            // 
            this.ColHeadRunCount.Text = "Run";
            // 
            // ColHeadArguments
            // 
            this.ColHeadArguments.Text = "Arguments";
            this.ColHeadArguments.Width = 160;
            // 
            // ContextMenuFiles
            // 
            this.ContextMenuFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRunArgumentsToolStripMenuItem,
            this.findToolStripMenuItem});
            this.ContextMenuFiles.Name = "ContextMenuFiles";
            this.ContextMenuFiles.Size = new System.Drawing.Size(192, 48);
            // 
            // editRunArgumentsToolStripMenuItem
            // 
            this.editRunArgumentsToolStripMenuItem.Name = "editRunArgumentsToolStripMenuItem";
            this.editRunArgumentsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editRunArgumentsToolStripMenuItem.Text = "Edit Run Arguments";
            this.editRunArgumentsToolStripMenuItem.Click += new System.EventHandler(this.EditArguments);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.FilesFind);
            // 
            // TPRunRecord
            // 
            this.TPRunRecord.Controls.Add(this.ListViewRunRecord);
            this.TPRunRecord.Location = new System.Drawing.Point(4, 22);
            this.TPRunRecord.Name = "TPRunRecord";
            this.TPRunRecord.Size = new System.Drawing.Size(808, 442);
            this.TPRunRecord.TabIndex = 4;
            this.TPRunRecord.Text = "Run Record";
            this.TPRunRecord.UseVisualStyleBackColor = true;
            // 
            // ListViewRunRecord
            // 
            this.ListViewRunRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColHeadRunTime,
            this.ColHeadFullName});
            this.ListViewRunRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewRunRecord.FullRowSelect = true;
            this.ListViewRunRecord.GridLines = true;
            this.ListViewRunRecord.HideSelection = false;
            this.ListViewRunRecord.Location = new System.Drawing.Point(0, 0);
            this.ListViewRunRecord.Name = "ListViewRunRecord";
            this.ListViewRunRecord.Size = new System.Drawing.Size(808, 442);
            this.ListViewRunRecord.TabIndex = 1;
            this.ListViewRunRecord.UseCompatibleStateImageBehavior = false;
            this.ListViewRunRecord.View = System.Windows.Forms.View.Details;
            // 
            // ColHeadRunTime
            // 
            this.ColHeadRunTime.Text = "Time";
            this.ColHeadRunTime.Width = 160;
            // 
            // ColHeadFullName
            // 
            this.ColHeadFullName.Text = "Full Name";
            this.ColHeadFullName.Width = 598;
            // 
            // TPBAT
            // 
            this.TPBAT.Controls.Add(this.ListViewCommand);
            this.TPBAT.Location = new System.Drawing.Point(4, 22);
            this.TPBAT.Name = "TPBAT";
            this.TPBAT.Size = new System.Drawing.Size(808, 442);
            this.TPBAT.TabIndex = 5;
            this.TPBAT.Text = "Customize Command";
            this.TPBAT.UseVisualStyleBackColor = true;
            // 
            // ListViewCommand
            // 
            this.ListViewCommand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColHeadCommand,
            this.ColHeadCommandDiscrib,
            this.ColHeadCommandContext});
            this.ListViewCommand.ContextMenuStrip = this.ContextMenuCommand;
            this.ListViewCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewCommand.FullRowSelect = true;
            this.ListViewCommand.GridLines = true;
            this.ListViewCommand.HideSelection = false;
            this.ListViewCommand.Location = new System.Drawing.Point(0, 0);
            this.ListViewCommand.Name = "ListViewCommand";
            this.ListViewCommand.Size = new System.Drawing.Size(808, 442);
            this.ListViewCommand.TabIndex = 2;
            this.ListViewCommand.UseCompatibleStateImageBehavior = false;
            this.ListViewCommand.View = System.Windows.Forms.View.Details;
            // 
            // ColHeadCommand
            // 
            this.ColHeadCommand.Text = "Command";
            this.ColHeadCommand.Width = 160;
            // 
            // ColHeadCommandDiscrib
            // 
            this.ColHeadCommandDiscrib.Text = "Discrib";
            this.ColHeadCommandDiscrib.Width = 160;
            // 
            // ColHeadCommandContext
            // 
            this.ColHeadCommandContext.Text = "Command Context";
            this.ColHeadCommandContext.Width = 448;
            // 
            // ContextMenuCommand
            // 
            this.ContextMenuCommand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCommandToolStripMenuItem,
            this.removeCommandToolStripMenuItem});
            this.ContextMenuCommand.Name = "ContextMenuCommand";
            this.ContextMenuCommand.Size = new System.Drawing.Size(195, 48);
            // 
            // addNewCommandToolStripMenuItem
            // 
            this.addNewCommandToolStripMenuItem.Name = "addNewCommandToolStripMenuItem";
            this.addNewCommandToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addNewCommandToolStripMenuItem.Text = "Add New Command";
            this.addNewCommandToolStripMenuItem.Click += new System.EventHandler(this.CommandAddNew);
            // 
            // removeCommandToolStripMenuItem
            // 
            this.removeCommandToolStripMenuItem.Name = "removeCommandToolStripMenuItem";
            this.removeCommandToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.removeCommandToolStripMenuItem.Text = "Remove Command";
            this.removeCommandToolStripMenuItem.Click += new System.EventHandler(this.CommandRemove);
            // 
            // ReloadTimer
            // 
            this.ReloadTimer.Interval = 60000;
            // 
            // LWebsite
            // 
            this.LWebsite.AutoSize = true;
            this.LWebsite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LWebsite.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LWebsite.Location = new System.Drawing.Point(52, 357);
            this.LWebsite.Name = "LWebsite";
            this.LWebsite.Size = new System.Drawing.Size(278, 17);
            this.LWebsite.TabIndex = 0;
            this.LWebsite.Text = "Visit https://github.com/butnofurther/HimeRun";
            this.LWebsite.Click += new System.EventHandler(this.VisitWebsite);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 468);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.Text = "Options";
            this.MainTabControl.ResumeLayout(false);
            this.TPConfig.ResumeLayout(false);
            this.PConfig.ResumeLayout(false);
            this.PConfig.PerformLayout();
            this.TPFetching.ResumeLayout(false);
            this.ContextMenuFetching.ResumeLayout(false);
            this.TPRecord.ResumeLayout(false);
            this.TPFileList.ResumeLayout(false);
            this.ContextMenuFiles.ResumeLayout(false);
            this.TPRunRecord.ResumeLayout(false);
            this.TPBAT.ResumeLayout(false);
            this.ContextMenuCommand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage TPFetching;
        private System.Windows.Forms.ListView ListViewFetching;
        private System.Windows.Forms.ColumnHeader ColHeadDir;
        private System.Windows.Forms.ColumnHeader ColHeadFileTypes;
        private System.Windows.Forms.ContextMenuStrip ContextMenuFetching;
        private System.Windows.Forms.ToolStripMenuItem addDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem changeFileTypesToFindToolStripMenuItem;
        private System.Windows.Forms.TabPage TPRecord;
        private System.Windows.Forms.ListView ListViewFetchRecord;
        private System.Windows.Forms.ColumnHeader ColHeadTime;
        private System.Windows.Forms.ColumnHeader ColHeadPath;
        private System.Windows.Forms.ColumnHeader ColHeadFile;
        private System.Windows.Forms.TabPage TPFileList;
        private System.Windows.Forms.ListView ListViewFiles;
        private System.Windows.Forms.ColumnHeader ColHeadFilePath;
        private System.Windows.Forms.ColumnHeader ColHeadName;
        private System.Windows.Forms.ColumnHeader ColHeadExtension;
        private System.Windows.Forms.ColumnHeader ColHeadDiscrib;
        private System.Windows.Forms.ColumnHeader ColHeadPinyin;
        private System.Windows.Forms.TabPage TPConfig;
        private System.Windows.Forms.Panel PConfig;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BReload;
        private System.Windows.Forms.Label LHotKey;
        private System.Windows.Forms.ComboBox ComboBoxHotKey0;
        private System.Windows.Forms.Label LHotKeyPlus;
        private System.Windows.Forms.ComboBox ComboBoxHotKey1;
        private System.Windows.Forms.Label AutoFetchTime;
        private System.Windows.Forms.ComboBox ComboBoxAutoFetchTime;
        private System.Windows.Forms.ColumnHeader ColHeadRunCount;
        private System.Windows.Forms.ComboBox ComboBoxShowPosition;
        private System.Windows.Forms.Label LShowPosition;
        private System.Windows.Forms.Timer ReloadTimer;
        private System.Windows.Forms.ColumnHeader ColHeadArguments;
        private System.Windows.Forms.ContextMenuStrip ContextMenuFiles;
        private System.Windows.Forms.ToolStripMenuItem editRunArgumentsToolStripMenuItem;
        private System.Windows.Forms.ComboBox ComboBoxSearchAfterHowManyCharInputed;
        private System.Windows.Forms.Label LSearchAfterHowManyCharInputed;
        private System.Windows.Forms.TabPage TPRunRecord;
        private System.Windows.Forms.ListView ListViewRunRecord;
        private System.Windows.Forms.ColumnHeader ColHeadRunTime;
        private System.Windows.Forms.ColumnHeader ColHeadFullName;
        private System.Windows.Forms.ColumnHeader ColHeadSecUsed;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.CheckBox CheckBoxStartUp;
        private System.Windows.Forms.CheckBox CheckBoxWebSearch;
        private System.Windows.Forms.ComboBox ComboBoxWebSearchEngine;
        private System.Windows.Forms.Label LSearchEngine;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.TabPage TPBAT;
        private System.Windows.Forms.ListView ListViewCommand;
        private System.Windows.Forms.ColumnHeader ColHeadCommand;
        private System.Windows.Forms.ColumnHeader ColHeadCommandDiscrib;
        private System.Windows.Forms.ColumnHeader ColHeadCommandContext;
        private System.Windows.Forms.ContextMenuStrip ContextMenuCommand;
        private System.Windows.Forms.ToolStripMenuItem addNewCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCommandToolStripMenuItem;
        private System.Windows.Forms.ComboBox ComboBoxLanguage;
        private System.Windows.Forms.Label LLanguage;
        private System.Windows.Forms.Label LWebsite;
    }
}