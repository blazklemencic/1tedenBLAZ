using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2tedenBLAZ_CALC
{
    internal class CALC
    {
        public static T Sum<T>(params T[] numbers) where T : INumber<T>
        {
            T sum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static T Sub<T>(params T[] numbers) where T : INumber<T>
        {
            if(numbers.Length == 0) return T.Zero;
            T final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final -= numbers[i];
            }
            return final;
        }

        public static T Multiply<T>(params T[] numbers) where T : INumber<T>
        {
            if (numbers.Length == 0) return T.One;
            T final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final *= numbers[i];
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
                final /= numbers[i];
            }
            return final;
        }
    }
}
