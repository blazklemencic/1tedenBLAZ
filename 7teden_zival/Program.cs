namespace _7tedenBLAZ_zival
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pes prviPes = new Pes("CAR", 1);

            Console.WriteLine($"{prviPes.Ime} je star {prviPes.Starost}");

            prviPes.Zvok();
            prviPes.Kosilo();

            Objava objava = new Objava("to je carska objava", true, "jaz");
            Console.WriteLine(objava.ToString());

            ObjavaSlika slika = new ObjavaSlika("slika 1", "blaz2", "https://slikica.si/b5W23X.png", true);
            Console.WriteLine(slika.ToString());

            ObjavaSlika slika2 = new ObjavaSlika("slika 1", "blaz2", "https://slikica.si/b5W23X.png", true);
            Console.WriteLine(slika2.ToString());

            ObjavaVideo video = new ObjavaVideo("objava 4", "blaz", "https://slikica.si/b5W23X.mp4", true, 15.2);
            Console.WriteLine(video.ToString());

            Console.ReadLine();
        }
    }
}
