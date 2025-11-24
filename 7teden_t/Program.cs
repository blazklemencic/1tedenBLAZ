namespace _7tedenBLAZ_t
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElektricneNaprave tv = new TV(false, "LG");
            ElektricneNaprave radio = new Radio(false, "Sony");

            Console.WriteLine($"{tv.Brand}, {radio.Brand}");
        }
    }
}
