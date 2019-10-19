using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Management;

namespace HimeUtil {
    // 网络类
    public static class HNet {
        // http下载
        public static bool Download(string url, string path) {
            // 设置参数
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            // 发送请求并获取相应回应数据
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            // 直到request.GetResponse()程序才开始向目标网页发送Post请求
            Stream responseStream = response.GetResponseStream();
            // 创建本地文件写入流
            if (!File.Exists(path)) // 先判定文件是否存在
            {
                Stream stream = new FileStream(path, FileMode.Create);
                byte[] bArr = new byte[1024];
                int size = responseStream.Read(bArr, 0, (int)bArr.Length);
                while (size > 0) {
                    stream.Write(bArr, 0, size);
                    size = responseStream.Read(bArr, 0, (int)bArr.Length);
                }
                stream.Close();
                responseStream.Close();
                return true;
            } else {
                return false;
            }
        }
        // 读取代码
        public static string GetHTML(string url) {
            string strHTML;
            WebClient myWebClient = new WebClient();
            try {
                Stream myStream = myWebClient.OpenRead(url);
                StreamReader sr = new StreamReader(myStream, System.Text.Encoding.GetEncoding("utf-8"));
                strHTML = sr.ReadToEnd();
                myStream.Close();
            } catch (Exception ex) {
                strHTML = "[Error]" + ex.Message;
            }
            return strHTML;
        }
        // ajax
        internal class Ajax {
            public static string Post(string url, string paramData = "{\"body\":{}}") {
                string result = "";
                try {
                    byte[] bytes = Encoding.UTF8.GetBytes(paramData);
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
                    httpWebRequest.Method = "POST";
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.ContentLength = bytes.Length;
                    Stream requestStream = httpWebRequest.GetRequestStream();
                    requestStream.Write(bytes, 0, bytes.Length);
                    requestStream.Close();
                    HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
                    result = streamReader.ReadToEnd();
                    streamReader.Close();
                    httpWebResponse.Close();
                    requestStream.Close();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    Environment.Exit(0);
                }
                return result;
            }
        }
        // 本地资源类
        internal class Local {
            // 获取局域网ip
            public static string[] GetLANIp() {
                List<string> ipAddressList = new List<string>();
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ipAddress in ipHost.AddressList) {
                    if (!ipAddressList.Contains(ipAddress.ToString())) {
                        ipAddressList.Add(ipAddress.ToString());
                    }
                }
                return ipAddressList.ToArray();
            }
            // 获取mac地址
            public static string GetMAC() {
                string strMac = string.Empty;
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc) {
                    if ((bool)mo["IPEnabled"]) {
                        strMac = mo["MacAddress"].ToString();
                    }
                }
                return strMac;
            }
        }
    }

    // JSON类
    public class HJSON {
        private List<string[]> LevelTree = new List<string[]> { };
        // 构造
        public HJSON(string JSONString) {
            JSONString = JSONString.Trim();
            char startChar = JSONString[0];
            char endChar = JSONString[JSONString.Length - 1];
            // {} 包裹体
            if (startChar == '{' && endChar == '}') {
                string JSONContent = JSONString.Substring(1, JSONString.Length - 2);
                string[] lines = JSONContent.Split(',');
                foreach (string line in lines) {
                    string trimedLine = line.Trim();
                    string[] keyValueSet = trimedLine.Split(':');
                    string key = keyValueSet[0];
                    string value = "";
                    for (int i = 1; i < keyValueSet.Length; i++) {
                        value += keyValueSet[i] + ":";
                    }
                    value = value.Substring(0, value.Length - 1);
                    LevelTree.Add(new string[] {
                        key, value
                    });
                }
            }
            // [] 包裹体
            else if (startChar == '[' && endChar == ']') {
                string JSONContent = JSONString.Substring(1, JSONString.Length - 2);
                string[] lines = JSONContent.Split(',');
                for (int i = 0; i < lines.Length; i++) {
                    string trimedLine = lines[i].Trim();
                    LevelTree.Add(new string[] {
                        i.ToString(), trimedLine
                    });
                }
            }
        }

        // 读取值
        public string GetValue(string key) {
            string result = "";
            foreach (string[] keyValueSet in LevelTree) {
                if (keyValueSet[0] == "\"" + key + "\"") {
                    result = keyValueSet[1];
                }
            }
            return TrimQuot(result);
        }
        public string GetValue(int key) {
            string result = "";
            foreach (string[] keyValueSet in LevelTree) {
                if (keyValueSet[0] == key.ToString()) {
                    result = keyValueSet[1];
                }
            }
            return TrimQuot(result);
        }

        private string TrimQuot(string str) {
            string result = str;
            char firstChar = str[0];
            char endChar = str[str.Length - 1];
            if (firstChar == '"' && endChar == '"') {
                result = result.Substring(1, result.Length - 2);
            }
            return result;
        }

        public string[][] GetList() {
            return LevelTree.ToArray();
        }
    }

    // 进程类
    public static class HProcess {
        // 运行外部程序
        public static void Run(string exePath, string arguments, bool waitForExit, string workingDirectory) {
            Process p = new Process();
            p.StartInfo.FileName = exePath;
            if (workingDirectory != null) {
                p.StartInfo.WorkingDirectory = workingDirectory;
            }
            if (arguments != null) {
                p.StartInfo.Arguments = arguments;
            }
            p.Start();
            if (waitForExit) {
                p.WaitForExit();
            }
        }
        public static void Run(string exePath, string arguments, bool waitForExit) {
            Process p = new Process();
            p.StartInfo.FileName = exePath;
            if (arguments != null) {
                p.StartInfo.Arguments = arguments;
            }
            p.Start();
            if (waitForExit) {
                p.WaitForExit();
            }
        }
        public static void Run(string exePath, string arguments) {
            Process p = new Process();
            p.StartInfo.FileName = exePath;
            p.StartInfo.Arguments = arguments;
            p.Start();
            p.WaitForExit();
        }
        public static void Run(string exePath) {
            Process p = new Process();
            p.StartInfo.FileName = exePath;
            p.Start();
            p.WaitForExit();
        }
    }


    //  系统类
    public static class HOS {
        // 字体
        internal static class Fonts {
            [DllImport("kernel32.dll", SetLastError = true)]
            static extern int WriteProfileString(string lpszSection, string lpszKeyName, string lpszString);
            [DllImport("user32.dll")]
            public static extern int SendMessage(
                int hWnd, // handle to destination window 
                uint Msg, // message 
                int wParam, // first message parameter 
                int lParam // second message parameter 
            );
            [DllImport("gdi32")]
            public static extern int AddFontResource(string lpFileName);

            // 安装字体
            public static void Install(string ttfFile, string fontFullName) {
                string winFontDir = Environment.GetEnvironmentVariable("windir") + "\\fonts";
                string fontFileName = ttfFile.Split('\\')[ttfFile.Split('\\').Length - 1];
                string fontPath = winFontDir + "\\" + fontFileName;
                const int WM_FONTCHANGE = 0x001D;
                const int HWND_BROADCAST = 0xffff;
                if (!File.Exists(fontPath)) {
                    File.Copy(ttfFile, fontPath);
                    AddFontResource(fontPath);
                    SendMessage(HWND_BROADCAST, WM_FONTCHANGE, 0, 0);
                    WriteProfileString("fonts", fontFullName + "(TrueType)", fontFileName);
                }

            }
        }

        // 字符串到文件
        public static bool ToFile(this string fileContent, string filePath) {
            try {
                // 检查文件是否存在
                if (!File.Exists(filePath)) {
                    FileStream stream = File.Create(filePath);
                    stream.Close();
                }
                File.WriteAllText(filePath, fileContent, Encoding.UTF8);
                return true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }

    // 窗体
    public static class HForm {
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        // 无边框窗体设置阴影
        public static bool SetShadow(this Form form) {
            if (form.FormBorderStyle != FormBorderStyle.None) {
                return false;
            }
            try {
                SetClassLong(form.Handle, GCL_STYLE, GetClassLong(form.Handle, GCL_STYLE) | CS_DropSHADOW);
                return true;
            } catch {
                return false;
            }
        }

    }

    // 日期时间类
    public static class HDateTime {
        public static string GetTimeStamp() {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
    }



    // 数组扩展
    public static class StringArrayExtends {
        // 数组连接函数
        public static string[] Concat(this string[] array0, string[] array1) {
            List<string> result = new List<string>();
            foreach (string s in array0) {
                result.Add(s);
            }
            foreach (string s in array1) {
                result.Add(s);
            }
            return result.ToArray();
        }
    }

    // 扩展路径选择器
    public class FolderDialog : FolderNameEditor {
        FolderBrowser fDialog = new FolderBrowser();
        public FolderDialog() {
        }
        public DialogResult ShowDialog() {
            return ShowDialog("请选择一个文件夹");
        }

        public DialogResult ShowDialog(string description) {
            fDialog.Description = description;
            return fDialog.ShowDialog();
        }
        public string Path {
            get {
                return fDialog.DirectoryPath;
            }
        }
        ~FolderDialog() {
            fDialog.Dispose();
        }
    }
}