namespace _2tedenBLAZ_sodoliho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tvoja stevilka: ");
            string? stringStevilo = Console.ReadLine();
            bool isNumber = Int32.TryParse(stringStevilo, out int value);
            if (!isNumber)
            {
                Console.WriteLine("not a number");
                return;
            }
            if (value % 2 == 0)
            {
                Console.WriteLine("sodo");
            }
            else
            {
                Console.WriteLine("liho");
            }
        }
    }
}
