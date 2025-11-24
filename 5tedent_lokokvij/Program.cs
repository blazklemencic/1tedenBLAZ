using System.Reflection;

namespace _5tedentBLAZ_lokokvij
{
    internal class Program
    {
        static List<Type> naloge = new List<Type>();

        static void Main(string[] args)
        {
            Init();

            while (true)
            {
                // izpise vse razpolozljive subclasse Naloga
                Console.WriteLine("Razpoložljive naloge:");
                for (int i = 0; i < naloge.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {naloge[i].Name}");
                }

                Console.Write("Katero nalogo bi radi zagnali? ");
                string? input = Console.ReadLine();

                // dobi izbiro uporabnika in offseta izbiro classa za 1 nazaj (list se zacne z 0)
                // kreira novo instanco Classa z Reflection in izvede Task() metodo ki jo mora imeti vsaka naloga ki extenda Naloga class
                if (int.TryParse(input, out int izbira) && izbira > 0 && izbira <= naloge.Count)
                {
                    var nalogaType = naloge[izbira - 1];
                    Naloga? nalogaInstance = (Naloga)Activator.CreateInstance(nalogaType);

                    Console.WriteLine($"\nZaganjam {nalogaType.Name}...\n");
                    nalogaInstance?.Task();
                }
                else
                {
                    Console.WriteLine("Neveljavna izbira!");
                    continue;
                }

                Console.WriteLine("\nPritisnite katerokoli tipko za izhod...");
                Console.ReadKey();
                break;
            }
        }

        // inicializira vse subclase Naloga v naloge List
        static void Init()
        {
            // dobi vse subclase ki extendajo Naloga in jih nastavi v 
            naloge = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Naloga)) && !t.IsAbstract)
                .OrderBy(t => t.Name)
                .ToList();

            // ce ni nalog zapri program
            if (naloge.Count == 0)
            {
                Console.WriteLine("Ni najdenih nobenih nalog!");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
        }
    }
}
