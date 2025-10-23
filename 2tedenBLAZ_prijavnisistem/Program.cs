using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

namespace _2tedenBLAZ_prijavnisistem
{
    internal class Program
    {
        static Dictionary<string, string> users = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            Console.Write("username: ");
            string? username = Console.ReadLine();
            Console.Write("password: ");
            string? password = Console.ReadLine();

            Register(username, password);
            Console.WriteLine("registered");

            Console.WriteLine("Login: ");
            Console.Write("username: ");
            string? username2 = Console.ReadLine();
            Console.Write("password: ");
            string? password2 = Console.ReadLine();
            Login(username2, password2);
        }

        static void Login(string? username, string? password)
        {
            if (username == null) {
                return;
            }
            bool obstaja = users.TryGetValue(username, out string? value);
            if (obstaja == false)
            {
                Console.WriteLine($"uporabnik {username} ne obstaja");
                return;
            }
            if (value == null || password == null)
            {
                throw new Exception();
            }
            string[] valuee = value.Split("|-|-|");
            if(VerifyPassword(password, valuee[0], Convert.FromBase64String(valuee[1]))) {
                Console.WriteLine("prijavljen si");
                return;
            }
            else
            {
                Console.WriteLine("napacno geslo");
                return;
            }

        }

        static void Register(string? username, string? password)
        {
            if (username == null || password == null || password.Length < 8)
            {
                Console.WriteLine("ne bo slo fant");
                Environment.Exit(1);
            }
            string hashed = HashAndSaltPasword(password);
            users.Add(username, hashed);
        }

        /// https://code-maze.com/csharp-hashing-salting-passwords-best-practices/
        static string HashAndSaltPasword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(64);
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                350000,
                HashAlgorithmName.SHA256,
                64);
            return Convert.ToHexString(hash) + "|-|-|" + Convert.ToBase64String(salt);
        }

        /// https://code-maze.com/csharp-hashing-salting-passwords-best-practices/
        static bool VerifyPassword(string password, string hash, byte[] salt)
        {
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, 350000, HashAlgorithmName.SHA256, 64);
            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }
    }
}
