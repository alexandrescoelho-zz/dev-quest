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

            if (number < 3)
                return (number > 1);
            else if (number % 2 == 0 || number % 3 == 0)
                return false;

            var i = 5;

            while (i*i <= number){
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
                i += 6;
            }

            return true;
        }
    }
}
