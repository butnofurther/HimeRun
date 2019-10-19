using HimeUtil;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Pinyin4net;

namespace HimeRun {
    public partial class OptionForm : Form {

        private SQLiteHelper DBLinker = new SQLiteHelper(Environment.CurrentDirectory, "core.db");

        /// <summary>
        /// working condition, if is loading, disable all window controls.
        /// </summary>
        private bool isLoading = false;
        private bool IsLoading {
            get {
                return isLoading;
            }
            set {
                isLoading = value;
                PConfig.Enabled = !isLoading;
                ListViewFetching.Enabled = !isLoading;
                ListViewFetchRecord.Enabled = !isLoading;
                ListViewFiles.Enabled = !isLoading;
                Text = isLoading ? "Options[Fetching...]" : "Options";
            }
        }

        public OptionForm() {
            InitializeComponent();
            try {
                // load config
                DBLinker.Execute(@"
                    create table if not exists
                    config (
                        keyName varchar(50),
                        keyValue varchar(100)
                    );
                ");
                InitConfigUI();
                // load Path
                DBLinker.Execute(@"
                    create table if not exists
                    main (
                        path varchar(200),
                        fileType varchar(50)
                    );
                ");
                ReloadListViewFetching();
                // RunLog
                DBLinker.Execute(@"
                    create table if not exists
                    runLog (
                        runTime datetime,
                        fileMainName varchar(100),
                        path varchar(200),
                        args varchar(200)
                    );
                ");
                GetRunLog();
                // FetchLog
                DBLinker.Execute(@"
                    create table if not exists
                    fetchLog (
                        fetchTime datetime,
                        triggerPath varchar(100),
                        fetchedFilesCount int,
                        secondsUsed bigint
                    );
                ");
                GetFetchLog();
                // load File -- main Data
                DBLinker.Execute(@"
                    create table if not exists
                    files (
                        path varchar(200), 
                        fileMainName varchar(100),
                        fileExtension varchar(20),
                        fileDiscrib varchar(200),
                        pinyin varchar(500),
                        updateTime datetime
                    );
                ");
                DBLinker.Execute(@"
                    create unique index fullPathName if not exists
                    on files (path, fileMainName, fileExtension);
                ");
                // load File -- running Arguments
                DBLinker.Execute(@"
                    create table if not exists
                    arguments (
                        path varchar(200), 
                        fileMainName varchar(100),
                        args varchar(200)
                    );
                ");
                GetFileList();
                // customized command
                DBLinker.Execute(@"
                    create table if not exists
                    customizeCommand (
                        name varchar(100),
                        discrib varchar(100),
                        code varchar(4000)
                    );
                ");
                GetCommandList();
                // timer
                LoadTimer();
            } catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// load the main clock handle of reload from the db-config
        /// </summary>
        private void LoadTimer() {
            string reloadTime = DBLinker.GetOneLine(@"select keyValue from config where keyName = 'AutoFetchTime' limit 1;");
            ReloadTimer.Interval = int.Parse(reloadTime) * 1000 * 60;
            ReloadTimer.Enabled = true;
            ReloadTimer.Tick += FetchAll;
        }

        private void GetFetchLog() {
            ListViewFetchRecord.Items.Clear();
            List<string[]> fetchLog = DBLinker.ExecuteToList(@"
                select * from fetchLog order by fetchTime desc;
            ");
            foreach (string[] f in fetchLog) {
                ListViewFetchRecord.Items.Add(new ListViewItem(f));
            }
        }

        public void GetRunLog() {
            ListViewRunRecord.Items.Clear();
            List<string[]> runLog = DBLinker.ExecuteToList(@"
                select
                    runTime,
                    path || '\' || fileMainName || ' ' || args
                from runLog
                order by runTime desc;
            ");
            foreach (string[] r in runLog) {
                ListViewRunRecord.Items.Add(new ListViewItem(r));
            }
        }

        /// <summary>
        /// get the data from db to listview
        /// </summary>
        private void ReloadListViewFetching() {
            ListViewFetching.Items.Clear();
            List<string[]> resultList = DBLinker.ExecuteToList(@"
                    select * from main;
                ");
            foreach (string[] re in resultList) {
                ListViewItem line = new ListViewItem(re);
                ListViewFetching.Items.Add(line);
            }
        }

        /// <summary>
        /// Add a fetching directroy from disk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFetchingDirectory(object sender, EventArgs e) {
            FolderDialog folderDialog = new FolderDialog();
            folderDialog.ShowDialog();
            DBLinker.Execute($@"
                insert into main values(
                    '{ folderDialog.Path }', 'exe'
                );
            ");
            ReloadListViewFetching();
        }

        private void RemoveFetchingDirectory(object sender, EventArgs e) {
            if (ListViewFetching.SelectedItems.Count < 1) {
                MessageBox.Show(
                    "You have to select at lease one line to remove.",
                    "Remove Directory",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            foreach (ListViewItem item in ListViewFetching.SelectedItems) {
                DBLinker.Execute($@"
                    delete from main
                    where path = '{ item.SubItems[0].Text }';
                ");
            }
            ReloadListViewFetching();
        }

        private void ClearFetchingDirectory(object sender, EventArgs e) {
            DialogResult con = MessageBox.Show(
                "Are you sure about that?",
                "Clear Directories",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );
            if (con == DialogResult.OK) {
                DBLinker.Execute(@"delete from main;");
                ReloadListViewFetching();
            } 
        }

        /// <summary>
        /// changing the file types from default type of *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeFileTypes(object sender, EventArgs e) {
            if (ListViewFetching.SelectedItems.Count < 1) {
                MessageBox.Show(
                    "You have to select at lease one line to update.",
                    "Changing File Types",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            PromptForm prompt = new PromptForm("Please input types you want to fetch, using ';' to seperate.") {
                Owner = this
            };
            prompt.ShowDialog();
            if (prompt.ConfirmedMessage == null) {
                return;
            }
            string changingTypes = prompt.ConfirmedMessage;
            changingTypes = changingTypes.Replace(" ", "");
            if (changingTypes == "") changingTypes = "*";
            foreach (ListViewItem item in ListViewFetching.SelectedItems) {
                DBLinker.Execute($@"
                    update main
                    set fileType = '{ changingTypes }'
                    where path = '{ item.SubItems[0].Text }'
                ");
            }
            ReloadListViewFetching();
        }

        private List<FileInfo> Fetch(string fetchPath, string fetchTypes) {
            List<FileInfo> result = new List<FileInfo>();
            void DoFetch(string path, string fileTypes) {
                string[] fileTypesArray = fileTypes.Split(';');
                if (!Directory.Exists(path)) return;
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                try {
                    FileSystemInfo[] fs = dirInfo.GetFileSystemInfos();
                    foreach (var fsObject in fs) {
                        FileInfo f = fsObject as FileInfo;
                        DirectoryInfo d = fsObject as DirectoryInfo;
                        if (f != null && f.Extension.Length > 0) {
                            string ext = f.Extension.Replace(".", "");
                            // if the ext in fileTypes, or there is a * mark in the fileTypes list(it means fetching all types of files), then add to result.
                            if (Array.IndexOf(fileTypesArray, ext) != -1 || Array.IndexOf(fileTypesArray, "*") != -1) {
                                result.Add(f);
                            }
                        }
                        if (d != null && d.FullName.IndexOf("$") == -1) {
                            DoFetch(d.FullName, fileTypes);
                        }
                    }
                } catch { }
            }
            DoFetch(fetchPath, fetchTypes);
            return result;
        }

        private void FetchAll(object sender, EventArgs e) {
            if (ListViewFetching.Items.Count == 0) return;
            IsLoading = true;
            string startTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            (new Thread(new ThreadStart(delegate {
                for (int i = 0; i < ListViewFetching.Items.Count; i++) {
                    ListViewItem item = ListViewFetching.Items[i];
                    List<FileInfo> re = Fetch(item.SubItems[0].Text, item.SubItems[1].Text);
                    foreach (FileInfo r in re) {
                        char[] nameCharArray = r.Name.ToCharArray();
                        string pinyin = "";
                        foreach (char nc in nameCharArray) {
                            string[] pinyinGroup = PinyinHelper.ToHanyuPinyinStringArray(nc);
                            if (pinyinGroup != null && pinyinGroup.Length > 0) {
                                pinyin += pinyinGroup[0].Substring(0, pinyinGroup[0].Length - 1);
                            } else {
                                pinyin += nc;
                            }
                        }
                        try {
                            DBLinker.Execute($@"
                                insert into files values(
                                    '{ r.Directory }',
                                    '{ r.Name }',
                                    '{ r.Extension.Replace(".", "") }',
                                    '',
                                    '{ pinyin }',
                                    '{ startTime }'
                                );
                            ");
                        } catch { }
                    }
                    // difference (in seconds) between now and startTime
                    TimeSpan ts = DateTime.Now - Convert.ToDateTime(startTime);
                    long secondsUsed = (long)ts.TotalSeconds;
                    // set fetch log
                    DBLinker.Execute($@"
                        insert into fetchLog values(
                            '{ startTime }',
                            '{ item.SubItems[0].Text }',
                            '{ re.Count.ToString() }',
                            '{ secondsUsed }'
                        );
                    ");
                }
                // delete old data
                DBLinker.Execute($@"
                    delete from files where updateTime != '{ startTime }';
                ");
                GetFileList();
                GetFetchLog();
                GetRunLog();
                IsLoading = false;
            }))).Start();
        }

        private void GetFileList() {
            ListViewFiles.Items.Clear();
            List<string[]> re = DBLinker.ExecuteToList(@"
                select 
                    f.path, 
                    f.fileMainName,
                    f.fileExtension,
                    f.fileDiscrib,
                    f.pinyin,
                    (select count(l.runTime) from runLog l where l.fileMainName = f.fileMainName and l.path = f.path) as cnt,
                    (select a.args from arguments a where f.fileMainName = a.fileMainName and f.path = a.path limit 1) as arguments
                from files f
                order by (select count(l.runTime) from runLog l where l.fileMainName = f.fileMainName and l.path = f.path) desc
                limit 1000;
            ");
            foreach (string[] r in re) {
                ListViewFiles.Items.Add(new ListViewItem(r));
            }
        }

        private void Refetch(object sender, EventArgs e) {
            DialogResult con = MessageBox.Show(
                "Fetch all directories immediately?",
                "Reload",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (con == DialogResult.Yes) {
                FetchAll(sender, e);
            }
        }

        /// <summary>
        /// build the config sheet pair by pair fitting the database.
        /// </summary>
        private void InitConfigUI() {
            string GetFromDB(string key, string defaultValue) {
                string result = DBLinker.GetOneLine($@"
                    select keyValue from config where keyName = '{ key }' limit 1;
                ");
                if (result == null) {
                    DBLinker.Execute($@"
                        insert into config values(
                            '{ key }', '{ defaultValue }'
                        );
                    ");
                    return defaultValue;
                }
                return result;
            }
            // auto fetching time
            ComboBoxAutoFetchTime.Items.Clear();
            ComboBoxAutoFetchTime.Items.Add("[Manual]");
            for (int i = 1; i < 241; i++) {
                ComboBoxAutoFetchTime.Items.Add(i.ToString());
            }
            ComboBoxAutoFetchTime.SelectedItem = GetFromDB("AutoFetchTime", "60");
            // hot keys
            string[] hotKeys = GetFromDB("HotKeys", "Shift;Z").Split(';');
            ComboBoxHotKey0.SelectedItem = hotKeys[0];
            ComboBoxHotKey1.SelectedItem = hotKeys[1];
            // start position
            string showPosition = GetFromDB("ShowPosition", "Left-Bottom");
            ComboBoxShowPosition.SelectedItem = showPosition;
            // start search after how many chars inputed
            string searchAfterHowManyCharInputed = GetFromDB("SearchAfterHowManyCharInputed", "3");
            ComboBoxSearchAfterHowManyCharInputed.SelectedItem = searchAfterHowManyCharInputed;
            // auto start up
            string autoStartUp = GetFromDB("AutoStartUp", "1");
            CheckBoxStartUp.Checked = autoStartUp == "1";
            // enable web search
            string enableWebSearch = GetFromDB("EnableWebSearch", "1");
            CheckBoxWebSearch.Checked = enableWebSearch == "1";
            // web search engine
            string webSearchEngine = GetFromDB("WebSearchEngine", "Baidu");
            ComboBoxWebSearchEngine.SelectedItem = webSearchEngine;
        }

        /// <summary>
        /// on submit, reset all data back into database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigConfirm(object sender, EventArgs e) {
            void SetDB(string keyName, string keyValue) {
                DBLinker.Execute($@"
                    update config
                    set keyValue = '{ keyValue }'
                    where keyName = '{ keyName }'
                ");
            }
            SetDB("AutoFetchTime", ComboBoxAutoFetchTime.Text);
            SetDB("HotKeys", ComboBoxHotKey0.Text + ";" + ComboBoxHotKey1.Text);
            SetDB("ShowPosition", ComboBoxShowPosition.Text);
            SetDB("SearchAfterHowManyCharInputed", ComboBoxSearchAfterHowManyCharInputed.Text);
            // reset the program
            Application.ExitThread();
            Thread thtmp = new Thread(new ParameterizedThreadStart(delegate(object obj) {
                Process ps = new Process();
                ps.StartInfo.FileName = obj.ToString();
                ps.Start();
            }));
            object appName = Application.ExecutablePath;
            Thread.Sleep(200);
            thtmp.Start(appName);
        }

        private void ConfigHide(object sender, EventArgs e) {
            Close();
        }

        /// <summary>
        /// set the arguments of file when running.
        /// these arguments will not remove by reload fetching.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditArguments(object sender, EventArgs e) {
            if (ListViewFiles.SelectedItems.Count < 1) {
                MessageBox.Show(
                    "At least select one file, to set its arguments when running.",
                    "Set Arguments",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            PromptForm promptForm = new PromptForm(
                "Set Arguments for " + ListViewFiles.SelectedItems[0].SubItems[1].Text + " ...",
                ListViewFiles.SelectedItems[0].SubItems[6].Text
            );
            promptForm.ShowDialog();
            string confirmedArguments = promptForm.ConfirmedMessage;
            foreach (ListViewItem item in ListViewFiles.SelectedItems) {
                DBLinker.Execute($@"
                    delete from arguments
                    where fileMainName = '{ item.SubItems[1].Text }'
                        and path = '{ item.SubItems[0].Text }';
                ");
                DBLinker.Execute($@"
                    insert into arguments values(
                        '{ item.SubItems[1].Text }',
                        '{ item.SubItems[0].Text }',
                        '{ confirmedArguments }'
                    );
                ");
            }
            GetFileList();
        }

        private void Exit(object sender, EventArgs e) {
            DialogResult con = MessageBox.Show(
                "Are you sure to exit this program completely?",
                "Exit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );
            if (con == DialogResult.OK) {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// find a file from file list view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilesFind(object sender, EventArgs e) {
            PromptForm findForm = new PromptForm("Find file name:") {
                Owner = this
            };
            findForm.ShowDialog();
            for (int i = 0; i < ListViewFiles.Items.Count; i++) {
                if (ListViewFiles.Items[i].SubItems[1].Text.IndexOf(findForm.ConfirmedMessage) != -1) {
                    ListViewFiles.Items[i].Selected = true;
                    ListViewFiles.Items[i].EnsureVisible();
                }
            }
        }

        /// <summary>
        /// add a new customized command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandAddNew(object sender, EventArgs e) {
            CustomizeCommandForm ccf = new CustomizeCommandForm() {
                Owner = this
            };
            ccf.ShowDialog();
            string code = ccf.ConfirmedCode.Replace("'", @"\'");
            DBLinker.Execute($@"
                insert into customizeCommand values(
                    '{ ccf.ConfirmedName }',
                    '{ ccf.ConfirmedDiscrib }',
                    '{ code }'
                );
            ");
            GetCommandList();
        }

        private void GetCommandList() {
            List<string[]> result = DBLinker.ExecuteToList(@"
                select * from customizeCommand;
            ");
            foreach (string[] r in result) {
                ListViewCommand.Items.Add(new ListViewItem(r));
            }
        }

        private void CommandRemove(object sender, EventArgs e) {
            if (ListViewCommand.SelectedItems.Count < 1) {
                MessageBox.Show(
                   "You have to select at lease one line to remove.",
                   "Remove Directory",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return;
            }
            foreach (ListViewItem item in ListViewCommand.SelectedItems) {
                DBLinker.Execute($@"
                    delete from customizeCommand
                    where name = '{ item.SubItems[0].Text }'
                ");
            }
            GetCommandList();
        }
    }
}
