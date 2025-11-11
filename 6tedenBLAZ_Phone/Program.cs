namespace _6tedenBLAZ_Phone
{

    public class Program
    {
        public static void Main()
        {
            Phone prvi = new Phone();
            Phone drugi = new Phone("Apple", "IPhone 12");
            Phone tretji = new Phone("Apple", "IPhone 12", "September 24, 2021");
            prvi.Predstavi();
            drugi.Predstavi();
            tretji.Predstavi();
        }
    }
}