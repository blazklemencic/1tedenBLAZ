namespace _1tedenBLAZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 19;
            int st1 = 22;
            int st2 = 55;
            int suma;
            String besedilo = "Jaz sem pisana marjetica";

            Console.Out.WriteLine("Hello, World!");
            Console.Out.WriteLine("Hello, Blaz Klemencic, starost " + age);
            suma = st1 + st2;

            Console.Out.WriteLine(age);

            Console.WriteLine("Stevilo 1 je: " + st1 + ". Stevilo 2 je: " + st2);
            Console.Out.WriteLine("Rezultat sestevanja = " + suma);

            Console.WriteLine(besedilo.ToUpper());
            Console.WriteLine(besedilo.ToLower());

            Console.Out.Write("Vnesite besedilo in pritisnite Enter: ");
            string? vnos = Console.ReadLine();
            if (vnos == null || vnos.Equals(""))
            {
                Console.WriteLine("Niste vnesli nobenega besedila");
                return;
            }
            Console.WriteLine($"Vneseno besedilo: {vnos}");

            Console.Write("Vnesi samo en karakter in pritisni Enter: ");
            int c = Console.In.Read();
            if(c == '\r' || c == '\n')
            {
                Console.WriteLine("NISI DAL NIC KAJJJ");
                return;
            }
            Console.Out.WriteLine(c);

            float floatSprem = 521.24f;
            int mojaStevilka = 24;

            string parsedStringFloat = floatSprem.ToString();
            string parsedStringInt = mojaStevilka.ToString();

            Console.Out.WriteLine(floatSprem + parsedStringFloat);

            string stringForFloat = "0.85"; // float
            string stringForInt = "12345"; // int
            float f = StringToFloat(stringForFloat);
            int i = StringToInt(stringForInt);
            Console.Out.WriteLine(f);
            Console.Out.WriteLine(i);

            Console.In.ReadLine();
        }

        private static float StringToFloat(string s)
        {
            bool sucFCon = float.TryParse(s, System.Globalization.CultureInfo.InvariantCulture.NumberFormat, out float f);
            if (!sucFCon)
            {
                Console.WriteLine("NI FLOAT");
                System.Environment.Exit(1);
            }
            return f;
        }

        private static int StringToInt(string s)
        {
            bool sucICon = Int32.TryParse(s, System.Globalization.CultureInfo.InvariantCulture.NumberFormat, out int i);
            if (!sucICon)
            {
                Console.WriteLine("NI INT");
                System.Environment.Exit(1);
            }
            return i;
        }
    }
}
