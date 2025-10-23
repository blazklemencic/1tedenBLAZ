namespace _3tedenBLAZ_najboljsiigralec
{
    internal class Program
    {
        static SortedDictionary<string, double> players = new SortedDictionary<string, double>();
        static double? najvecjiScore;
        static string? igralec;

        static void Main(string[] args)
        {
            Console.Write("One player only mode? [y/N] ");
            string? iss = Console.ReadLine();
            if (iss == null)
            {
                return;
            }
            bool iss2;
            if (String.Equals(iss.ToLower(), "y"))
            {
                iss2 = true;
            }
            else if (String.Equals(iss.ToLower(), "n"))
            {
                iss2 = false;
            }
            else
            {
                iss2 = false;
            }

            while (true)
            {
                Console.Write("Ime igralca: ");
                string? ime = Console.ReadLine();
                if (ime == null)
                {
                    return;
                }
                Console.Write("Rezultat igralca: ");
                string? rezultatString = Console.ReadLine();
                bool succ = double.TryParse(rezultatString, out double score);
                if (!succ)
                {
                    return;
                }

                if (iss2)
                {
                    PreveriRezultat(score, ime);
                    Console.WriteLine($"Najboljsi igralec je {igralec} z {najvecjiScore} tockami");
                }
                else
                {
                    PreveriRezultat2(score, ime);
                    var sortedDictionary = players.ToList();
                    sortedDictionary.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
                    foreach (var (key, value) in sortedDictionary)
                    {
                        Console.WriteLine(key.ToString() + " " + value);
                    }
                }
            }
        }

        static void PreveriRezultat(double score, string playerName)
        {
            if (igralec != null && najvecjiScore != null && najvecjiScore > score)
            {
                Console.WriteLine("prejsnji igralec ima se vedno najvec tock");
            }

            else
            {
                najvecjiScore = score;
                igralec = playerName;
            }
        }

        static void PreveriRezultat2(double score, string playerName)
        {
            bool exists = players.TryGetValue(playerName, out var score2);

            if (exists)
            {
                players[playerName] = score;
                return;
            }
            else
            {
                players.Add(playerName, score);
            }
        }
    }
}
