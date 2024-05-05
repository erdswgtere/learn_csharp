using System.Text;
using Registration_proccess;
namespace Auto_reg {
    internal class Program {
        static void Main(string[] args) {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1251 = Encoding.GetEncoding(1251);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = enc1251;

            Registration.AllInfo();
        }
    }
}
