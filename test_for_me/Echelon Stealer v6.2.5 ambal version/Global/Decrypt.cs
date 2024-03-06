using System;
using System.IO;
using Ionic.Zlib;

namespace Echelon
{
    internal class Decrypt
    {
        public static string Get(string str)
        {
            var value = Convert.FromBase64String(str);
            var resultString = string.Empty;
            if (value != null && value.Length > 0)
                using (var stream = new MemoryStream(value))
                using (var zip = new GZipStream(stream, CompressionMode.Decompress))
                using (var reader = new StreamReader(zip))
                {
                    resultString = reader.ReadToEnd();
                }

            return resultString;
        }
    }
}
