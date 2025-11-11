using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tedenBLAZ_introducemyself
{
    internal class Human
    {
        public string ime;
        public string priimek;

        public Human(string firstName, string lastName)
        {
            this.ime = firstName;
            this.priimek = lastName;
        }

        public void PredstaviSe()
        {
            Console.WriteLine($"Hi, I'm {ime} {priimek}");
        }
    }
}
