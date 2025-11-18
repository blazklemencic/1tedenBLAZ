namespace _7teden_employeeCompanycar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pot = $"C:\\Users\\VSŠ\\Desktop";
            string inputFile = pot + "\\input.txt";
            string outputFile = pot + "\\output.txt";

            if (!File.Exists(inputFile))
            {
                Console.WriteLine("Ne obstaja vhodna pot");
                return;
            }

            using (StreamReader sr = new StreamReader(inputFile))
            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                string? linija;
                bool prviElement = true;

                while ((linija = sr.ReadLine()) != null) { 
                    if(linija.Contains("split"))
                    {
                        string[] deli = linija.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                        if(deli.Length > 4)
                        {
                            string beseda = deli[4].Trim('.', ',', ';', '!', '?');

                            if(!prviElement)
                            {
                                sw.Write(" ");
                            }

                            sw.Write(beseda);
                            prviElement = false;
                        }
                    }
                }
            }

            Console.WriteLine($"done. check {outputFile}");

            Console.ReadLine();
        }
    }
}
