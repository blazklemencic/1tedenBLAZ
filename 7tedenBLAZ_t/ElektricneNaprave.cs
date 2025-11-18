using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7tedenBLAZ_t
{
    internal class ElektricneNaprave
    {
        public bool JeVklopljen { get; set; }
        public string Brand { get; set; }

        public ElektricneNaprave(bool jeVklopljen, string brand)
        {
            this.JeVklopljen = jeVklopljen;
            this.Brand = brand;
        }

        public void Prizgi()
        {
            this.JeVklopljen = true;
        }

        public void Ugasni()
        {
            this.JeVklopljen = false;
        }
    }
}
