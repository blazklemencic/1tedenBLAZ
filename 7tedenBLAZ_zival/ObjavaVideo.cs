using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _7tedenBLAZ_zival
{
    internal class ObjavaVideo : Objava
    {
        public string URL { get; set; }
        public double Dolzina { get; set; }

        public ObjavaVideo()
        {

        }

        public ObjavaVideo(string naslov, string username, string url, bool jeJavna, double dolzina) : base(naslov, jeJavna, username)
        {
            this.Dolzina = dolzina;
            this.URL = url;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Naslov} - {this.URL} - {this.Dolzina}s - objavil {this.Username}");
        }
    }
}
