using System.ComponentModel;
using System.Numerics;

namespace _2tedenBLAZ_CALC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("select your operation(+, -, *, /): ");
            string? op = Console.ReadLine();
            Console.WriteLine();
            Console.Write("input your first operand: ");
            string? fo = Console.ReadLine();
            if (fo == null)
            {
                Console.WriteLine("No operand");
                return;
            }
            Console.WriteLine();
            Console.Write("Input your second operand: ");
            string? so = Console.ReadLine();
            if (so == null)
            {
                Console.WriteLine("No operand");
                return;
            }

            bool firstOperand = double.TryParse(fo, out double res);
            bool secondOperand = double.TryParse(so, out double res2);
            if (!firstOperand)
            {
                Console.WriteLine("first operand is in invalid format");
                return;
            }
            if (!secondOperand)
            {
                Console.WriteLine("Second operand is in invalid format");
                return;
            }
            switch (op)
            {
                case "+":
                    Console.WriteLine($"result: {CALC.Sum(res, res2)}");
                    break;
                case "-":
                    Console.WriteLine($"result: {CALC.Sub(res, res2)}");
                    break;
                case "*":
                    Console.WriteLine($"result: {CALC.Multiply(res, res2)}");
                    break;
                case "/":
                    Console.WriteLine($"result: {CALC.Divide(res, res2)}");
                    break;
                case "":
                    Console.WriteLine($"sum result: {CALC.Sum(res, res2)}");
                    Console.WriteLine($"sub result: {CALC.Sub(res, res2)}");
                    Console.WriteLine($"multiplication result: {CALC.Multiply(res, res2)}");
                    Console.WriteLine($"division result: {CALC.Divide(res, res2)}");
                    break;
                default:
                    throw new NotSupportedException("Operation not supported");
            }
        }
    }
}
