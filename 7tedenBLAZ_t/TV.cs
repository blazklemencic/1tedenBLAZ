using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7tedenBLAZ_t
{
    internal class TV : ElektricneNaprave
    {

        public TV(bool jeVklopljen, string brand) : base(jeVklopljen, brand)
        {
        }

        public void Glej()
        {
            Console.WriteLine(this.JeVklopljen 
              ? "Gledamo TV." 
              : "Najprej ga moraš vklopiti, da bi ga lahko gledal.");
        }
    }
}
