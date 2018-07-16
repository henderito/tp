using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Printer
    {
        public static bool Print(string file, string printer)
        {
            try
            {
                Process.Start(
                   Registry.LocalMachine.OpenSubKey(
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion" +
                        @"\App Paths\AcroRd32.exe").GetValue("").ToString(),
                   string.Format("/h /t \"{0}\" \"{1}\"", file, printer));
                return true;
            }
            catch { }
            return false;
        }
    }
}
