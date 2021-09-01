using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung.Helper
{
    class VersionHelper
    {
        public string CurrentVersion { get; private set; }
        public string NewestVersion { get; private set; }

        string baseUrl = $"https://greendevhub.github.io/";
        string downloadUrl = "";

        public VersionHelper()
        {
            GetCurrentVersion();
        }
        private void GetCurrentVersion()
        {
            CurrentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            CurrentVersion = CurrentVersion.Substring(0, CurrentVersion.Length - 2);
        }
        public bool isNewVersionAvailable()
        {
            CheckForNewVersion();
            var newV = NewestVersion.Split('.');
            var currentV = CurrentVersion.Split('.');
            for(int i = 0; i < newV.Length; i++)
            {
                int newVersion = int.Parse(newV[i]);
                int currentVersion = int.Parse(currentV[i]);
                if (newVersion > currentVersion) return true;
                else if (newVersion < currentVersion) return false;
            }
            return false;
        }
        public void CheckForNewVersion()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client = new WebClient();
            try
            {
                client.UseDefaultCredentials = true;
                client.Proxy = null;
                client.Credentials = CredentialCache.DefaultCredentials;
                string htmlData = client.DownloadString($"https://greendevhub.github.io/version.json");
                JObject json = JObject.Parse(htmlData);
                NewestVersion = json["version"].ToString();
                downloadUrl = baseUrl + json["url"].ToString();
            }
            catch
            {
                downloadUrl = "";
                NewestVersion = CurrentVersion;
            }
        }

        public void DownloadNewVersion()
        {
            if (downloadUrl == "" || NewestVersion == "" || NewestVersion == CurrentVersion) return;
            string fileUrl = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/greenLibSetupDownload.msi";
            if (File.Exists(fileUrl)) File.Delete(fileUrl);
            using (var client = new WebClient())
            {
                client.DownloadFile(downloadUrl, fileUrl);
            }
            Process.Start(fileUrl);
            Application.Exit();
        }
        public VersionChange GetChanges(string currentVersion)
        {
            string version = "";
            string message = "";
            List<string> features = new List<string>();
            List<string> bugs = new List<string>();
            VersionChange change;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client = new WebClient();
            try
            {
                client.UseDefaultCredentials = true;
                client.Proxy = null;
                client.Credentials = CredentialCache.DefaultCredentials;
                client.Encoding = Encoding.UTF8;
                string htmlData = client.DownloadString($"https://greendevhub.github.io/version.json");
                JObject json = JObject.Parse(htmlData);
                NewestVersion = json["version"].ToString();
                JArray changelog = (JArray)json["changelog"];
                for(int i = 0; i < changelog.Count; i++)
                {
                    JObject changeObj = (JObject)changelog[i];
                    if (changeObj["version"].ToString().Equals(currentVersion))
                    {
                        version = changeObj["version"].ToString();
                        message = changeObj["message"].ToString();
                        JArray featureArr = (JArray)changeObj["features"];
                        foreach(JObject featureObj in featureArr)
                        {
                            features.Add(featureObj["feature"].ToString());
                        }
                        JArray bugArr = (JArray)changeObj["bugs"];
                        foreach (JObject bugObj in bugArr)
                        {
                            bugs.Add(bugObj["bug"].ToString());
                        }
                    }
                }
                change = new VersionChange(version, message, features, bugs);
            }
            catch
            {
                change = new VersionChange();
            }
            return change;
        }
    }

    class VersionChange
    {
        public VersionChange()
        {
            Version = "";
            Message = "";
            Features = new List<string>();
            Bugs = new List<string>();
        }
        public VersionChange(string version, string message, List<string> features, List<string> bugs)
        {
            Version = version;
            Message = message;
            Features = features;
            Bugs = bugs;
        }
        public string Version { get; private set; }
        public string Message { get; private set; }
        public List<string> Features { get; private set; }
        public List<string> Bugs { get; private set; }

        public string GetChanges()
        {
            string changes = $"{Message}\n";
            changes += "\n";
            changes += $"Features: \n";
            foreach(string s in Features)
            {
                changes += $"{s}\n";
            }
            changes += "\n";
            changes += $"Fehlerbehebungen: \n";
            foreach (string s in Bugs)
            {
                changes += $"{s}\n";
            }
            return changes;
        }
    }
}
