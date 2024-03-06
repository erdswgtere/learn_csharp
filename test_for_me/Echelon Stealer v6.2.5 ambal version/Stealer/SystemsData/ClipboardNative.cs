using System;
using System.Runtime.InteropServices;

namespace Echelon
{
    internal static class ClipboardNative
    {
        private const uint CF_UNICODETEXT = 0xD;

        public static string GetText()
        {
            if (NativeMethods.IsClipboardFormatAvailable(CF_UNICODETEXT) && NativeMethods.OpenClipboard(IntPtr.Zero))
            {
                var data = string.Empty;
                var hGlobal = NativeMethods.GetClipboardData(CF_UNICODETEXT);
                if (!hGlobal.Equals(IntPtr.Zero))
                {
                    var lpwcstr = NativeMethods.GlobalLock(hGlobal);
                    if (!lpwcstr.Equals(IntPtr.Zero))
                        try
                        {
                            data = Marshal.PtrToStringUni(lpwcstr);
                            NativeMethods.GlobalUnlock(lpwcstr);
                        }
                        catch { }
                }
                NativeMethods.CloseClipboard();
                return data;
            }
            return null;
        }
    }
}