using MyMath.API.Domain.DTO;
using MyMath.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMath.API.Domain
{
    public class CalculatorService : ICalculatorService
    {
        public DivisorCaluculationDTO GetAllDivisorsAndPrimeNumber(int number)
        {

            var divisors = AwesomeMath.GetDivisorsFromPositiveNumber(number);
            var primes = divisors.Where(AwesomeMath.IsPrime);

            return new DivisorCaluculationDTO { Divisors = divisors, Primes = primes };
        }
    }
}
