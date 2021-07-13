using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Verwaltung
{
    class Protocol
    {
        public string pathpublic = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\greenLib\\LogFiles\\error_reports.txt";
        public string pathprivate = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\greenLib\\LogFiles\\system_error_reports.txt";

        public Protocol()
        {

        }

        /// <summary>
        /// Schreibt einen LogFile-Eintrag des aufgetretenen Fehlers in die Log-Datei
        /// </summary>
        private static void LogPublic(string logMessage, TextWriter tw)
        {
            tw.Write("\r\nLog Entry : ");
            tw.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            tw.WriteLine("  Message:");
            tw.WriteLine($"  :{logMessage}");
            tw.WriteLine("------------------------------------------------------------");
        }

        /// <summary>
        /// Schreibt einen LogFile-Eintrag des aufgetretenen Fehlers in eine geschützte System-Log-Datei
        /// </summary>
        private static void LogPrivate(Exception ex, TextWriter tw)
        {
            tw.Write("\r\nLog Entry : ");
            tw.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            tw.WriteLine("  Source:");
            tw.WriteLine($"  :{ex.Source}");
            tw.WriteLine("  TargetSite:");
            tw.WriteLine($"  :{ex.TargetSite}");
            tw.WriteLine("  HResult:");
            tw.WriteLine($"  :{ex.HResult}");
            tw.WriteLine("  Message:");
            tw.WriteLine($"  :{ex.Message}");
            tw.WriteLine("------------------------------------------------------------");
        }

        /// <summary>
        /// Erstellt einen LogFile-Eintrag des aufgetretenen Fehlers
        /// </summary>
        public void CreateReport(Exception exceptionObject)
        {
            try
            {
                if (!Directory.Exists(pathpublic))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\greenLib\\LogFiles");
                }

                using (StreamWriter sw = File.AppendText(pathpublic))
                {
                    LogPublic(exceptionObject.Message, sw);
                }
                using (StreamWriter sw = File.AppendText(pathprivate))
                {
                    LogPrivate(exceptionObject, sw);
                }
            }
            catch { }
        }

        /// <summary>
        /// Erstellt einen LogFile-Eintrag des aufgetretenen Fehlers
        /// </summary>
        public void LogTransaction()
        {
            try
            {

            }
            catch { }
        }
    }
}
