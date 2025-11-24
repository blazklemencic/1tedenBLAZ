namespace _3tedenBLAZ_programzauciteljapovprecneocene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<byte> ocene = new List<byte>();

            while (true)
            {
                Console.Write("Vnesite oceno [vnesite -1 da dobite povprecno oceno]: ");
                string? ocenaString = Console.ReadLine();
                bool succ = sbyte.TryParse(ocenaString, out sbyte ocena);
                if (!succ)
                {
                    Console.WriteLine("Stevilo ni veljavno");
                    continue;
                }
                if (ocena == -1)
                {
                    break;
                }
                if (!(ocena >= 5) || !(ocena <= 10))
                {
                    Console.WriteLine("Stevilo naj bo od 5 do 10");
                    continue;
                }

                ocene.Add((byte)ocena);
            }

            float povprecnaOcena = ocene.Sum(x => (float)x) / ocene.Count;
            Console.WriteLine($"Povprecna ocena je {povprecnaOcena}");
        }
    }
}
