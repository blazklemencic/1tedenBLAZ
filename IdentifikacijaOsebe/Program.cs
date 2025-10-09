namespace IdentifikacijaOsebe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program za identifikacijo osebe. Prosim preverite, da so vneseni podatki pravilni!");
            Console.Write("Ime in priimek: ");
            string? imePriimek = Console.ReadLine();
            if (imePriimek == null || imePriimek.Equals(""))
            {
                Console.WriteLine("Niste vnesli imena in priimka!");
                return;
            }

            Console.Write("Starost: ");
            string? starostVnos = Console.ReadLine();
            bool succ = Int32.TryParse(starostVnos, out int starost);
            if (!succ || starost > 130)
            {
                Console.WriteLine("Niste vnesli pravilne starosti!");
                return;
            }

            Console.Write("Vpisna stevilka: ");
            string? vpisnaStevilkaVnos = Console.ReadLine();
            succ = Int32.TryParse(vpisnaStevilkaVnos, out int vpisnaStevilka);
            if (!succ)
            {
                Console.WriteLine("Niste vnesli pravilne vpisne stevilke!");
                return;
            }

            Console.Write("Naslov: ");
            string? naslov = Console.ReadLine();
            if (naslov == null || naslov.Equals(""))
            {
                Console.WriteLine("Niste vnesli naslova!");
                return;
            }

            Console.WriteLine("\n\nVneseni podatki:");
            Console.WriteLine($"Ime in priimek: {imePriimek}");
            Console.WriteLine($"Starost: {starost}");
            Console.WriteLine($"Vpisna stevilka: {vpisnaStevilka}");
            Console.WriteLine($"Naslov: {naslov}");
        }
    }
}
