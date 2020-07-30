using MyMath.API.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMath.API.Domain.Services
{
    public interface ICalculatorService
    {
        DivisorCaluculationDTO GetAllDivisorsAndPrimeNumber(int number);
    }
}
