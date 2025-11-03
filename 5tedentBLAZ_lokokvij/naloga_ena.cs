using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5tedentBLAZ_lokokvij
{
    internal class Naloga_ena : Naloga
    {
        private readonly static string ime = "Blaz Klemencic";
        private readonly static int dneviVTednu = 7;
        private readonly static float temperaturaZraka = 25.6f;
        private readonly static bool grelnikVklopljen = false;

        internal override void Task()
        {
            Console.WriteLine($"moje ime je: {ime}");
            Console.WriteLine($"dni v tednu je {dneviVTednu}");
            Console.WriteLine($"temperatura zraka je {temperaturaZraka}°C");
            Console.WriteLine($"grelnik je {(grelnikVklopljen ? "vklopljen" : "izklopljen")}");
        }
    }
}
