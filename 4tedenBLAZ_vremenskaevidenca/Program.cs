using System.Collections;

namespace _4tedenBLAZ_vremenskaevidenca
{
    enum OpisVremena
    {
        soncen,
        zasnezen,
        dezeven,
        vetroven,
        megleno,
        toplo
    }
    internal class VremenskaEvidenca
    {


        private readonly static List<Vreme> vremes = new List<Vreme>();

        static void Main(string[] args)
        {
            Console.Write("Za koliko dni zelite vnesti vreme? ");
            string? steviloDniString = Console.ReadLine();
            bool jeStevilo = int.TryParse(steviloDniString, out int stDni);
            if (!jeStevilo)
            {
                Console.WriteLine("Ni stevilo!");
                return;
            }

            Array opisi = Enum.GetValues(typeof(OpisVremena));
            string opisiVremena = "";
            for (int i = 0; i < opisi.Length; i++)
            {
                opisiVremena += opisi.GetValue(i);

                if (i < opisi.Length - 1)
                    opisiVremena += ", ";
            }
            Console.WriteLine($"Za vsak dan vnesi vreme v formatu: \"[temperatura] [opis (moznosti so: {opisiVremena})]\"");
            for (int i = 1; i <= stDni; i++)
            {
                Console.Write($"{i}. Dan: ");
                string? vneseniString = Console.ReadLine();
                if (vneseniString == null)
                {
                    Console.WriteLine("string je null??");
                    i--;
                    continue;
                }
                string[] splitString = vneseniString.Split(" ");
                if (splitString.Length != 2)
                {
                    Console.WriteLine("Format vremena za dan ni pravilen. Znova si poglejte navodila formata v zgornjih navodilih.");
                    i--;
                    continue;
                }
                bool temperaturaJeStevilo = float.TryParse(splitString[0], out float temperatura);
                if (!temperaturaJeStevilo)
                {
                    Console.WriteLine("Temperatura ni stevilo! poskusi znova");
                    i--;
                    continue;
                }

                bool niPravilenOpis = false;
                foreach (OpisVremena o in opisi)
                {
                    if (splitString[1].Contains(o.ToString()))
                    {
                        niPravilenOpis = false;
                        break;
                    }
                    else
                    {
                        niPravilenOpis = true;
                    }
                }
                bool jeOpis = OpisVremena.TryParse(splitString[1], out OpisVremena opis);
                if (!jeOpis || niPravilenOpis == true)
                {
                    Console.WriteLine("opis ni v pravem formatu! poskusi znova");
                    i--;
                    continue;
                }

                Vreme vreme = new Vreme(i, temperatura, opis);

                vremes.Add(vreme);
            }

            double averageTemp = averageTemperature(vremes);
            averageTemp = Math.Round(averageTemp, 2);
            Vreme biggestTemp = najvisjaTemperatura(vremes);
            Vreme lowestTemp = najnizjaTemperatura(vremes);
            Console.Clear();
            Console.WriteLine("============== REZULTATI ===============");
            foreach (Vreme v in vremes)
            {
                double temperatura = Math.Round(v.getTemperatura(), 2);
                int dan = v.getDan();
                OpisVremena opis = v.getOpisVremena();
                Console.WriteLine($"{dan}. dan: {temperatura}°C, {opis}");
            }
            Console.WriteLine();
            Console.WriteLine($"Povprecna temperatura za vse dni: {averageTemp}°C");
            Console.WriteLine($"Najvisja temperatura: {biggestTemp.getDan()}. dan: {biggestTemp.getTemperatura()}°C");
            Console.WriteLine($"Najnizja temperatura: {lowestTemp.getDan()}. dan: {lowestTemp.getTemperatura()}°C");
            Console.WriteLine("========================================");

            Console.ReadLine();
        }

        private static float averageTemperature(List<Vreme> v)
        {
            if(v == null)
            {
                Console.WriteLine("List of vremes is null");
                return 0f;
            }

            float sum = 0f;
            foreach (Vreme vreme in v)
            {
                sum += vreme.getTemperatura();
            }
            return sum / v.Count;
        }

        private static Vreme najvisjaTemperatura(List<Vreme> v)
        {
            Vreme vreme = v.Aggregate((i1, i2) => i1.getTemperatura() > i2.getTemperatura() ? i1 : i2);
            return vreme;
        }

        private static Vreme najnizjaTemperatura(List<Vreme> v)
        {
            Vreme vreme = v.Aggregate((i1, i2) => i1.getTemperatura() < i2.getTemperatura() ? i1 : i2);
            return vreme;
        }
    }

    internal class Vreme
    {
        readonly OpisVremena opis;
        readonly float temperatura;
        readonly int dan;

        public Vreme(int dan, float temperatura, OpisVremena opis)
        {
            this.opis = opis;
            this.temperatura = temperatura;
            this.dan = dan;
        }

        public OpisVremena getOpisVremena()
        {
            return this.opis;
        }

        public float getTemperatura()
        {
            return this.temperatura;
        }

        public int getDan()
        {
            return this.dan;
        }
    }
}
