namespace _6tedenBLAZ_imepriimekbarva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human clovek1 = new Human();
            Human clovek2 = new Human("blaz", "k", 24);
            Human clovek3 = new Human("blaz", "k", 25, "modra");

            clovek1.predstaviSe();
            clovek2.predstaviSe();
            clovek3.predstaviSe();
        }
    }
}
