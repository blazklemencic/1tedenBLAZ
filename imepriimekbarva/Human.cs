using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _6tedenBLAZ_imepriimekbarva
{
    internal class Human
    {
        private string ime;
        private string priimek;
        private int starost;
        public string najljubsaBarva;


        public Human()
        {
        }

        public Human(string ime, string priimek, int starost, string favColor)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.starost = starost;
            this.najljubsaBarva = favColor;
        }

        public Human(string ime, string priimek, int starost)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.starost = starost;
        }

        public void predstaviSe()
        {
            if (starost != 0 && priimek != null && ime != null && najljubsaBarva != null)
                Console.WriteLine($" Živijo, jaz sem {ime} {priimek}. Star/a sem {starost} let. Moja najljubša barva je: {najljubsaBarva}.");
            else if (ime != null && priimek != null)
            {
                Console.WriteLine($" Živijo, jaz sem {ime} {priimek}.");
            }
            else
            {
                Console.WriteLine("objekt je kreiran vendar ni argumentov");
            }
        }

    }

}