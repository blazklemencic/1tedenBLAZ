namespace _2tedenBLAZ_ocenestudentov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vpisite st tock: ");

            string? tocke = Console.ReadLine();
            if (tocke == null)
            {
                return;
            }
            bool tru = int.TryParse(tocke, out int tockeInt);
            if (!tru) 
            {
                Console.WriteLine("neveljavna st");
            }

            if (tockeInt < 0 || tockeInt > 100)
            {
                Console.WriteLine("Neveljavno st tock");
                return;
            }

            bool tru2 = int.TryParse(tocke[0].ToString(), out int ocena);
            if (!tru2)
            {
                Console.WriteLine("neveljavna st");
            }

            if(tockeInt < 10)
            {
                ocena = 1;
                Console.WriteLine($"Ocena studenta je {ocena}");
                Console.WriteLine($"nikoli ne bos opravil izpita");
                return;
            }

            Console.WriteLine($"Ocena studenta je {ocena}");

            Console.ReadKey();
        }
    }
}
