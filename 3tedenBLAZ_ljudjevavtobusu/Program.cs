namespace _3tedenBLAZ_ljudjevavtobusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte ljudjeVAvtobusu = 0;

            b(ljudjeVAvtobusu);

            while (ljudjeVAvtobusu < 52)
            {
                Console.Write("Dodaj ali odstrani ljudi iz avtobusa. Npr. \"-12\", \"2\" (Za izhod vnesite \"na svidenje\"): ");
                string? str = Console.ReadLine();
                if (str != null && str.ToLower().Equals("na svidenje")) break;
                bool tru = sbyte.TryParse(str, out sbyte don);
                if (!tru)
                {
                    Console.WriteLine("Zal to ni stevlika");
                }

                if (ljudjeVAvtobusu + don < 0 || ljudjeVAvtobusu + don > 51)
                {
                    Console.WriteLine("Avtobus je prepoln ali prevec prazen. Poskusi znova!");
                    continue;
                }

                ljudjeVAvtobusu += don;
                b(ljudjeVAvtobusu);
            }

            Console.WriteLine("Hvala enako!");
        }

        static void b(sbyte ljudjeVAvtobusu)
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
