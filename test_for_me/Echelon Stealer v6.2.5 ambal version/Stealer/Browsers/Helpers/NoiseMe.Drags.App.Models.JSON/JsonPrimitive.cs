using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Echelon
{
	public class JsonPrimitive : JsonValue
	{
        private static readonly byte[] true_bytes = Encoding.UTF8.GetBytes("true");

        private static readonly byte[] false_bytes = Encoding.UTF8.GetBytes("false");

        public JsonPrimitive(bool value)
		{
			Value = value;
		}

        public JsonPrimitive(byte value)
		{
			Value = value;
		}

        public JsonPrimitive(char value)
		{
			Value = value;
		}

        public JsonPrimitive(decimal value)
		{
			Value = value;
		}

        public JsonPrimitive(double value)
		{
			Value = value;
		}

        public JsonPrimitive(float value)
		{
			Value = value;
		}

        public JsonPrimitive(int value)
		{
			Value = value;
		}

        public JsonPrimitive(long value)
		{
			Value = value;
		}

        public JsonPrimitive(sbyte value)
		{
			Value = value;
		}

        public JsonPrimitive(short value)
		{
			Value = value;
		}

        public JsonPrimitive(string value)
		{
			Value = value;
		}

        public JsonPrimitive(DateTime value)
		{
			Value = value;
		}

        public JsonPrimitive(uint value)
		{
			Value = value;
		}

        public JsonPrimitive(ulong value)
		{
			Value = value;
		}

        public JsonPrimitive(ushort value)
		{
			Value = value;
		}

        public JsonPrimitive(DateTimeOffset value)
		{
			Value = value;
		}

        public JsonPrimitive(Guid value)
		{
			Value = value;
		}

        public JsonPrimitive(TimeSpan value)
		{
			Value = value;
		}

        public JsonPrimitive(Uri value)
		{
			Value = value;
		}

        public JsonPrimitive(object value)
		{
			Value = value;
		}

        public object Value { get; }

        public override JsonType JsonType
		{
			get
			{
				if (Value == null) return JsonType.String;
                switch (Type.GetTypeCode(Value.GetType()))
				{
				case TypeCode.Boolean:
					return JsonType.Boolean;
				case TypeCode.Object:
				case TypeCode.Char:
				case TypeCode.DateTime:
				case TypeCode.String:
					return JsonType.String;
				default:
					return JsonType.Number;
				}
			}
		}

        public override void Save(Stream stream, bool parsing)
		{
			switch (JsonType)
			{
			case JsonType.Boolean:
				if ((bool)Value)
                    stream.Write(true_bytes, 0, 4);
                else
                    stream.Write(false_bytes, 0, 5);
                break;
			case JsonType.String:
			{
				stream.WriteByte(34);
				var bytes = Encoding.UTF8.GetBytes(EscapeString(Value.ToString()));
				stream.Write(bytes, 0, bytes.Length);
				stream.WriteByte(34);
				break;
			}
			default:
			{
				var bytes = Encoding.UTF8.GetBytes(GetFormattedString());
				stream.Write(bytes, 0, bytes.Length);
				break;
			}
			}
		}

        public string GetFormattedString()
		{
			switch (JsonType)
			{
			case JsonType.String:
				if (Value is string || Value == null)
				{
					var text2 = Value as string;
					if (string.IsNullOrEmpty(text2)) return "null";
                    return text2.Trim('"');
				}
				if (Value is char) return Value.ToString();
                throw new NotImplementedException("GetFormattedString from value type " + Value.GetType());
			case JsonType.Number:
			{
				var text = !(Value is float) && !(Value is double) ? ((IFormattable)Value).ToString("G", NumberFormatInfo.InvariantInfo) : ((IFormattable)Value).ToString("R", NumberFormatInfo.InvariantInfo);
				if (text == "NaN" || text == "Infinity" || text == "-Infinity") return "\"" + text + "\"";
                return text;
			}
			default:
				throw new InvalidOperationException();
			}
		}
    }
}
