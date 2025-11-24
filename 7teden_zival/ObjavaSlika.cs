using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7tedenBLAZ_zival
{
    internal class ObjavaSlika : Objava
    {
        public string URL { get; set; }

        public ObjavaSlika()
        {

        }

        public ObjavaSlika(string naslov, string username, string urlSlike, bool jeJavna) : base(naslov, jeJavna, username)
        {
            this.URL = urlSlike;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Naslov} - {this.URL} - objavil {this.Username}");
        }
    }
}
