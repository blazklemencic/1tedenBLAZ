using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7tedenBLAZ_zival
{
    internal class Zival(string ime, int starost)
    {
        public string Ime { get; set; } = ime;
        public int Starost { get; set; } = starost;
        public bool JeLacna { get; set; } = true;

        public virtual void Kosilo()
        {
            Console.WriteLine(JeLacna ? $"{Ime} je kosilo" : $"{Ime} ni na kosilu");
        }

        public virtual void Zvok()
        {

        }
    }
}
