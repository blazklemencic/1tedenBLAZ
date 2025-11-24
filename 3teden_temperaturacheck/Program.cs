namespace _3tedenBLAZ_temperaturacheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaksna je trenutna temperatura? ");
            string? tempString = Console.ReadLine();
            bool succ = float.TryParse(tempString, out var temp);

            if (!succ)
            {
                Console.WriteLine("ni pravilna stevlika");
            }

            if (temp <= 15)
            {
                Console.WriteLine("mrzlo je");
            }
            else if (temp == 16 && temp <= 28)
            {
                Console.WriteLine("its fine");
            }
            else if (temp > 28)
            {
                Console.WriteLine("vroce");
            }

            Console.Read();
        }
    }
}
