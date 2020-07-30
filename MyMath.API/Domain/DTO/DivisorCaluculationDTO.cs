using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMath.API.Domain.DTO
{
    public class DivisorCaluculationDTO
    {
        public IEnumerable<int> Divisors { get; set; }

        public IEnumerable<int> Primes { get; set; }
    }
}
