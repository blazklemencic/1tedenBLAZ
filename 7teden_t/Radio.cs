using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7tedenBLAZ_t
{
    internal class Radio : ElektricneNaprave
    {

        public Radio(bool jeVklopljen, string brand) : base(jeVklopljen, brand)
        {
        }

        public void Poslusaj()
        {
            Console.WriteLine(this.JeVklopljen
              ? "Poslusamo glasbo."
              : "Najprej ga moraš vklopiti, da bi ga lahko poslusal.");
        }
    }
}
