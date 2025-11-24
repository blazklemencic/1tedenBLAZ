using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5tedentBLAZ_lokokvij
{
    internal class Naloga_tri : Naloga
    {
        internal override void Task()
        {
            while (true)
            {
                Console.Write("Vnesite stevilo tock: ");
                string? tockeString = Console.ReadLine();
                if (String.IsNullOrEmpty(tockeString))
                {
                    Console.WriteLine("niste vpisali tock");
                    continue;
                }
                bool soValidneTocke = byte.TryParse(tockeString, out byte tocke);
                if (!soValidneTocke)
                {
                    Console.WriteLine("format tock ni pravilen");
                    continue;
                }

                int ocena = IzracunOcene(tocke);
                if (ocena == 0)
                {
                    Console.WriteLine("Stevilo tock je premajhni");
                    continue;
                }
                Console.WriteLine($"ocena je {ocena}");
                break;
            }
        }

        private static int IzracunOcene(byte tocke)
        {
            if (tocke > 100)
            {
                return 0;
            }
            else if (tocke <= 50)
            {
                
                return 5;
            }
            else if (tocke <= 60)
            {
                return 6;
            }
            else if (tocke <= 70)
            {
                return 7;
            }
            else if (tocke <= 80)
            {
                return 8;
            }
            else if (tocke <= 90)
            {
                return 9;
            }
            else
            {
                return 10;
            }
        }
    }
}
