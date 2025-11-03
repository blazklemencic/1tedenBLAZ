using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5tedentBLAZ_lokokvij
{
    internal class Naloga_pet : Naloga
    {
        internal override void Task()
        {
            sbyte ljudjeVAvtobusu = 0;

            while (ljudjeVAvtobusu < 52)
            {
                Console.Write("Za prikaz ljudi v avtobusu pritisnite \"r\"");
                Console.Write("\nDodaj ali odstrani ljudi iz avtobusa. Npr. \"-12\", \"2\" (Za izhod vnesite \"na svidenje\"): ");
                
                string? str = Console.ReadLine();
                if (!String.IsNullOrEmpty(str) && str.ToLower().Equals("na svidenje")) break;
                else if (str == "r")
                {
                    B(ljudjeVAvtobusu);
                    continue;
                };

                if (!sbyte.TryParse(str, out sbyte don))
                {
                    Console.WriteLine("Zal to ni stevlika");
                }

                if (ljudjeVAvtobusu + don < 0 || ljudjeVAvtobusu + don > 51)
                {
                    Console.WriteLine("Avtobus je prepoln ali prevec prazen. Poskusi znova!");
                    continue;
                }

                ljudjeVAvtobusu += don;
                //b(ljudjeVAvtobusu);
            }

            Console.WriteLine("Hvala enako!");
        }

        static void B(sbyte ljudjeVAvtobusu)
        {
            switch (ljudjeVAvtobusu)
            {
                case 0:
                    Console.WriteLine($"Trenutno je v avtobusu {ljudjeVAvtobusu} ljudi");
                    break;
                case 1:
                    Console.WriteLine($"Trenutno je v avtobusu {ljudjeVAvtobusu} clovek");
                    break;
                case 2:
                    Console.WriteLine($"Trenutno sta v avtobusu {ljudjeVAvtobusu} cloveka");
                    break;
                case <= 4:
                    Console.WriteLine($"Trenutno so v avtobusu {ljudjeVAvtobusu} ljudje");
                    break;
                default:
                    Console.WriteLine($"Trenutno je v avtobusu {ljudjeVAvtobusu} ljudi");
                    break;
            }
        }
    }
}
