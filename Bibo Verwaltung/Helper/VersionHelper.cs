using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;
using System.Net;
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
            //to be done later, hard coded for now
            CurrentVersion = "1.0.0";
        }
        public bool isNewVersionAvailable()
        {
            CheckForNewVersion();
            int newestVersion = int.Parse(NewestVersion.Replace(".", ""));
            int currentVersion = int.Parse(CurrentVersion.Replace(".", ""));
            return newestVersion > currentVersion;
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
            using (var client = new WebClient())
            {
                client.DownloadFile(downloadUrl, $"greenLibSetup-{NewestVersion}.msi");
            }
            Process.Start($"greenLibSetup-{NewestVersion}.msi");
            Application.Exit();
        }
    }
}
