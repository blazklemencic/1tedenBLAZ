using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7tedenBLAZ_zival
{
    internal class Objava
    {
        private static int id;
        
        protected int ID { get; set; }
        public string Naslov { get; set; }
        public string Username { get; set; }
        public bool jeJavna { get; set; }

        public Objava()
        {
            ID = 0;
            this.Naslov = "Prva objava";
            this.Username = "blaz";
            this.jeJavna = true;
        }

        public Objava(string naslov, bool jeJavna, string username)
        {
            this.ID = PridobiNaslednjiID();
            this.Naslov = naslov;
            this.Username = username;
            this.jeJavna = jeJavna;
        }

        protected static int PridobiNaslednjiID()
        {
            return ++id;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Naslov} - objavil {this.Username}");
        }
    }
}
