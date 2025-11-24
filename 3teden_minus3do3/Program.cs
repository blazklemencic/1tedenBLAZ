namespace _3tedenBLAZ_minus3do3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            forLoop();
            whileLoop();
        }

        static void forLoop()
        {
            for (int i = -3; i <= 3; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void whileLoop()
        {
            int j = -3;
            while (j <= 3)
            {
                Console.WriteLine(j);
                j++;
            }
        }
    }
}
