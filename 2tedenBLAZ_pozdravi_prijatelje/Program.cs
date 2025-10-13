namespace _2tedenBLAZ_pozdravi_prijatelje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] prijatelji = ["Miha", "Tone", "Joze"];

            foreach (var prijatelj in prijatelji)
            {
                PozdraviPrijatelja(prijatelj);
            }
        }

        static void PozdraviPrijatelja(string ime)
        {
            Console.WriteLine($"Hej, {ime}. Kako si?");
        }
    }
}
