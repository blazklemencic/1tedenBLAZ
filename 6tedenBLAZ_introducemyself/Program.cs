namespace _6tedenBLAZ_introducemyself
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human miroslav = new Human("m", "s");
            miroslav.ime = "Miroslav";
            miroslav.priimek = "Strnisa";

            miroslav.PredstaviSe();
            Console.ReadKey();
        }
    }
}