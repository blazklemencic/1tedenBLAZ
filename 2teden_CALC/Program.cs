using System.ComponentModel;
using System.Data;
using System.Numerics;
using System.Text;
using System.Xml;

namespace _2tedenBLAZ_CALC
{
    internal class Program
    {
        static bool end = false;
        static int number_of_operands = 0;
        static List<double> operands = new List<double>();

        static void Main(string[] args)
        {
            InputRegularMathString();

            Console.Write("select your operation(+, -, *, /): ");
            string? op = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("To stop inputting operands and calculate the result, type \"end\" instead of a number");
            while (!end)
            {
                number_of_operands++;
                Console.Write($"input operand {number_of_operands}: ");
                string? foo = Console.ReadLine();
                if (foo == null)
                {
                    Console.WriteLine("No operand");
                    return;
                }
                bool operand = double.TryParse(foo, out double ress);
                if (!operand)
                {
                    if(foo == "end")
                    {
                        end = true;
                        break;
                    }
                    Console.WriteLine($"operand {number_of_operands} is in invalid format. Try again");
                    number_of_operands--;
                    continue;
                }
                operands.Add(ress);
            }

            switch (op)
            {
                case "+":
                    Console.WriteLine($"result: {CALC.Sum(operands.ToArray())}");
                    break;
                case "-":
                    Console.WriteLine($"result: {CALC.Sub(operands.ToArray())}");
                    break;
                case "*":
                    Console.WriteLine($"result: {CALC.Multiply(operands.ToArray())}");
                    break;
                case "/":
                    Console.WriteLine($"result: {CALC.Divide(operands.ToArray())}");
                    break;
                case "":
                    Console.WriteLine($"sum result: {CALC.Sum(operands.ToArray())}");
                    Console.WriteLine($"sub result: {CALC.Sub(operands.ToArray())}");
                    Console.WriteLine($"multiplication result: {CALC.Multiply(operands.ToArray())}");
                    Console.WriteLine($"division result: {CALC.Divide(operands.ToArray())}");
                    break;
                default:
                    throw new NotSupportedException("Operation not supported");
            }
        }

        private static void InputRegularMathString()
        {
            Console.Write("your equation: ");
            string? equation = Console.ReadLine();

            if (equation != null && equation.Contains('/') && equation.Contains('0'))
            {
                throw new DivideByZeroException();
            }

            if (equation == null)
            {
                throw new Exception();
            }

            foreach (string eq in equation.Split())
            {
                bool e = double.TryParse(eq, out double value);
                if (!e)
                {
                    Console.WriteLine("erm numbers only please?");
                    Environment.Exit(1);
                }
            }

            /// https://codereview.stackexchange.com/a/57982 the goat
            DataTable dt = new DataTable();
            string? answer;
            try
            {
                answer = dt.Compute(equation, "").ToString();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine($"Rezultat je: {answer}");
        }
    }
}
