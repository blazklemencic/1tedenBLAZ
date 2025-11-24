namespace _4tedenBLAZ_napake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            napaka_1();
            napaka_2();
            napaka_3();
            napaka_4();
            napaka_5();
            napaka_6();
            napaka_7();
            napaka_8();
            napaka_9();
        }

        static void napaka_1()
        {
            // WriteLine, ime
            string ime = "Miroslav";
            Console.WriteLine("Pozdravljen, " + ime + "!");
        }

        static void napaka_2()
        {
            // ne mores deliti z 0
            int a = 10;
            int b = 0;
            if (b == 0)
            {
                Console.WriteLine("dont divide by 0");
                return;
            }
            Console.WriteLine("Rezultat je: " + (a / b));
        }

        static void napaka_3()
        {
            // Naloga: Preveri, ali je številka soda ali liha
            // sintaksa + obrnjena logika
            int stevilo = 5;
            if (stevilo % 2 == 0)
            {
                Console.WriteLine("Številka je soda.");
            }
            else
            {
                Console.WriteLine("Številka je liha.");
            }
        }

        static void napaka_4()
        {
            // Naloga: Prikaz temperature glede na vhodni podatek
            // sintaksa
            int temperatura = 20;
            if (temperatura < 15)
            {
                Console.WriteLine("Mrzlo je.");
            }
            else
            {
                Console.WriteLine("Toplo je.");
            }
        }

        static void napaka_5()
        {
            // Naloga: Izpiši številke od 1 do 5 vključno z 1 in 5
            // manjka }
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Številka: " + i);
            }
        }

        static void napaka_6()
        {
            // Naloga: Pretvori decimalno število v celo število
            // (int) in wrong case
            double stevilo = 12.5;
            int celoStevilo = (int)stevilo;
            Console.WriteLine("Celo število: " + celoStevilo);
        }

        // Naloga: Kreiraj metodo za seštevanje dveh števil
        // en parameter premalo
        public static int Add(int x, int y)
        {
            return x + y;
        }

        static void napaka_7()
        {
            Console.WriteLine("Rezultat je: " + Add(5, 7));
        }
        
        static void napaka_8()
        {
            // Naloga: Poišči določeno vrednost v tabeli
            // manjka en =
            int[] tabela = { 1, 2, 3, 4, 5 };
            int iskanaVrednost = 3;
            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i] == iskanaVrednost)
                {
                    Console.WriteLine("Vrednost najdena!");
                }
            }
        }

        static void napaka_9()
        {
            // Naloga: Preveri, ali je vnos uporabnika številka
            // Console.ReadLine(), TryParse, obrnjena logika
            Console.WriteLine("Vnesite število:");
            string? vnos = Console.ReadLine();
            bool jeStevilo = int.TryParse(vnos, out _);
            if (jeStevilo == true)
            {
                Console.WriteLine("Vnesena vrednost je številka.");
            }
            else
            {
                Console.WriteLine("Napaka: Vnesena vrednost ni številka.");
            }
        }
    }
}
