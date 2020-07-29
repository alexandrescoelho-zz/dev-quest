using System;
using System.Collections.Generic;

namespace MyMath
{
    public static class AwesomeMath
    {

        public static IEnumerable<int> GetDivisor(int number)
        {
            var result = new List<int>();

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    result.Add(i);
            }

            result.Add(number);

            return result;
        }

    }
}
