using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Odtwarzacz
{
    internal static class Eksplorator
    {

        [DllImport("winmm.dll")]
        public static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);

        public static void open(string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);

        }
        public static void close(string File)
        {
            string Format = @"step %s %s %s";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);

        }
    }
}
