using System;
using System.Security.Principal;

namespace Echelon
{
    public static class RunChecker
    {
        public static bool IsAdmin => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        public static bool IsWin64 => Environment.Is64BitOperatingSystem ? true : false;
    }
}