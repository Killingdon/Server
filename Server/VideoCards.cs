using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class VideoCards : Machine, IGot
    {
        private string version { get; set; }

        public string _version => version;

        public VideoCards(string Version)
        {
            Version = version;
        }

        int IGot.MinVolume(int volume) 
        { 
            cout -= volume;
            return cout;
        }
    }
}
