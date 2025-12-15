using System;
using System.Collections.Generic;
using System.Text;

namespace ZaposleniPlace
{
    class PlacilniZapis
    {
        public double bruto;
        public double dodatki;
        public double prispevki;
        public double davek;
        public double neto;
        public DateTime timestamp;

        public PlacilniZapis(double bruto, double dodatki, double prispevki, double davek, double neto)
        {
            this.bruto = bruto;
            this.dodatki = dodatki;
            this.prispevki = prispevki;
            this.davek = davek;
            this.neto = neto;

            this.timestamp = DateTime.Now;
        }
    }
}
