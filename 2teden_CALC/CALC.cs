using System.Numerics;

namespace _2tedenBLAZ_CALC
{
    internal class CALC
    {
        public static T Sum<T>(params T[] numbers) where T : INumber<T>
        {
            T sum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                try
                {
                    sum += numbers[i];
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception occured while SUMMING {ex}");
                    return T.Zero;
                }
            }

            return sum;
        }

        public static T Sub<T>(params T[] numbers) where T : INumber<T>
        {
            if(numbers.Length == 0) return T.Zero;
            T final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                try
                {
                    final -= numbers[i];
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception occured while SUBSTRACTING {ex}");
                    return T.Zero;
                }
            }
            return final;
        }

        public static T Multiply<T>(params T[] numbers) where T : INumber<T>
        {
            if (numbers.Length == 0) return T.One;
            T final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                try
                {
                    final *= numbers[i];
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception occured while MULTIPLYING {ex}");
                    return T.Zero;
                }
                
            }
            return final;
        }

        public static T Divide<T>(params T[] numbers) where T : INumber<T>
        {
            if (numbers.Length == 0) return T.One;
            T final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == T.Zero)
                {
                    Console.WriteLine("You can't divide by zero dummy");
                    return T.Zero;
                }
                try { 
                final /= numbers[i];
                } catch (Exception ex) {
                    Console.WriteLine($"Exception occured while DIVIDING {ex}");
                    return T.Zero;
                }
            }
            return final;
        }
    }
}
