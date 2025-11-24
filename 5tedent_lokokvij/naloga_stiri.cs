using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5tedentBLAZ_lokokvij
{
    internal class Naloga_stiri : Naloga
    {
        internal override void Task()
        {
            while(true)
            {
                Console.Write("Vnesite vrednost: ");
                string? vrednostString = Console.ReadLine();
                if (String.IsNullOrEmpty(vrednostString))
                {
                    Console.WriteLine("vrednost ni v pravem formatu");
                    continue;
                }
                bool vrednostJeValidna = double.TryParse(vrednostString, out double vrednost);
                if (!vrednostJeValidna)
                {
                    Console.WriteLine("vrenost ni v pravem formatu");
                    continue;
                }
                jeDeljivo(vrednost);
                break;
            }
        }

        private static void jeDeljivo(double vrednost)
        {
            if (vrednost % 4 == 0)
            {
                Console.WriteLine("vrednost je deljiva z 4");
            }
            else if (vrednost % 5 == 0)
            {
                Console.WriteLine("vrednost je deljiva z 5");
            }
            else if (vrednost % 2 == 0)
            {
                Console.WriteLine("vrednost je soda");
            }
            else
            {
                Console.WriteLine("vrednost je liha");
            }
        }
    }
}
