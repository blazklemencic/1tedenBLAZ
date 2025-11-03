using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5tedentBLAZ_lokokvij
{
    internal class Naloga_dva : Naloga
    {
        internal override void Task()
        {
            while (true)
            {
                Console.Write("Vnesi en znak: ");
                string? characterString = Console.ReadLine();
                if (String.IsNullOrEmpty(characterString) || characterString.Length > 1)
                {
                    Console.WriteLine("vnesi samo en znak");
                    continue;
                }
                char character = characterString[0];
                Console.WriteLine($"ascii koda za {characterString} je {(int)character}");
                break;
            }
        }
    }
}
