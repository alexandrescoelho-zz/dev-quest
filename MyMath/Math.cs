using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    public static class AwesomeMath
    {

        public static IEnumerable<int> GetDivisor(int number)
        {
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

    }
}
