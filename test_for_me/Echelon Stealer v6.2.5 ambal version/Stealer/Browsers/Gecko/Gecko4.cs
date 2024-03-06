using System.Collections.Generic;
using System.Text;

namespace Echelon
{
	public   class Gecko4
	{
        public  Gecko4()
		{
			Objects = new List<Gecko4>();
		}

        public  Gecko2 ObjectType
		{
			get;
			set;
		}

        public  byte[] ObjectData
		{
			get;
			set;
		}

        public  int ObjectLength
		{
			get;
			set;
		}

        public  List<Gecko4> Objects
		{
			get;
			set;
		}

        public override string ToString()
		{
			var stringBuilder = new StringBuilder();
			var stringBuilder2 = new StringBuilder();
			switch (ObjectType)
			{
			case Gecko2.Sequence:
				stringBuilder.AppendLine("SEQUENCE {");
				break;
			case Gecko2.Integer:
			{
				var objectData = ObjectData;
				foreach (var b2 in objectData) stringBuilder2.AppendFormat("{0:X2}", b2);
                stringBuilder.Append("\tINTEGER ").Append(stringBuilder2).AppendLine();
				break;
			}
			case Gecko2.OctetString:
			{
				var objectData = ObjectData;
				foreach (var b3 in objectData) stringBuilder2.AppendFormat("{0:X2}", b3);
                stringBuilder.Append("\tOCTETSTRING ").AppendLine(stringBuilder2.ToString());
				break;
			}
			case Gecko2.ObjectIdentifier:
			{
				var objectData = ObjectData;
				foreach (var b in objectData) stringBuilder2.AppendFormat("{0:X2}", b);
                stringBuilder.Append("\tOBJECTIDENTIFIER ").AppendLine(stringBuilder2.ToString());
				break;
			}
			}
			foreach (var @object in Objects) stringBuilder.Append(@object);
            if (ObjectType == Gecko2.Sequence) stringBuilder.AppendLine("}");
            stringBuilder2.Remove(0, stringBuilder2.Length - 1);
			return stringBuilder.ToString();
		}
    }
}
