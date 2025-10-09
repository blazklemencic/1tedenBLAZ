using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1tedenBLAZ
{
    internal class CALC
    {
        public static int Sum(params int[] numbers)
        {
            return numbers.Sum();
        }

        public static int Sub(int mainValue, params int[] numbers)
        {
            int final = mainValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                final -= numbers[i];
            }
            return final;
        }

        public static int Multiply(params int[] numbers)
        {
            int final = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                final *= numbers[i];
            }
            return final;
        }

        public static int Divide(params int[] numbers)
        {
            int final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final /= numbers[i];
            }
            return final;
        }
    }
}
