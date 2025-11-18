using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _7tedenBLAZ_zival
{
    internal class Pes(string ime, int starost) : Zival(ime, starost)
    {
        public bool JeVesel { get; set; } = true;

        public override void Kosilo()
        {
            base.Kosilo();
        }

        public override void Zvok()
        {
            Console.WriteLine("WOOF WOOF");
        }
    }
}
