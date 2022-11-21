using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    internal class OdtwarzanieClass
    {
        public void play()
        {
            string command = "play MediaFile";
            Eksplorator.mciSendString(command, null, 0, 0);
        }

        public void stop()
        {
            string command = "stop MediaFile";
            Eksplorator.mciSendString(command, null, 0, 0);
        }
        public void czysc()
        {
            string command = "close MediaFile";
            Eksplorator.mciSendString(command, null, 0, 0);
        }
    }
}
