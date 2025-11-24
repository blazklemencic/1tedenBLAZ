using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tedenBLAZ_Phone
{
    public class Phone
    {
        public string podjetje;
        public string model;
        public string danIzdaje;

        public Phone()
        {
            podjetje = "neznano";
            model = "neznano";
            danIzdaje = "neznano";
        }

        public Phone(string podjetje, string model)
        {
            this.podjetje = podjetje;
            this.model = model;
            danIzdaje = "Unknown";
        }

        public Phone(string podjetje, string model, string danIzdaje)
        {
            this.podjetje = podjetje;
            this.model = model;
            this.danIzdaje = danIzdaje;
        }

        public void Predstavi()
        {
            if (podjetje != null && model != null && danIzdaje != null && danIzdaje != "Unknown")
                Console.WriteLine($"Telefon podjetja {podjetje}, model {model}, je bil izdan {danIzdaje}.");
            else
            {
                string tekst = $"Telefon podjetja {podjetje}, model {model}, je bil izdan {danIzdaje}.";
                Console.WriteLine(tekst.ToUpper());
            }
        }
    }
}
