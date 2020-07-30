using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace MyMath
{
    public static class AwesomeMath
    {

        public static IEnumerable<int> GetDivisorsFromPositiveNumber(int number)
        {
            if (number<0) 
                throw new ArgumentOutOfRangeException("number", number, "value has to be a positive integer");

            var result = new List<int>();

            for (int i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    result.Add(i);

                    if (number / i != i)
                        result.Add(number / i);
                }
            }
            
            return result.OrderBy(n=>n);
        }

        public static bool IsPrime(int number) {

            return false;
        }

    }
}
