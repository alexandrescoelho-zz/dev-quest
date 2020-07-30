using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMath.API.Domain.DTO;
using MyMath.API.Domain.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyMath.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        private ICalculatorService _service;
        public CalculationController(ICalculatorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var random = new Random();
            var result = await _service.GetAllDivisorsAndPrimeNumber(random.Next());

            return Ok(result);
        }

        // GET: api/<CalculationController>
        [HttpGet("{number}")]
        public async Task<IActionResult> Get(int number)
        {
            if (number < 0)
                return BadRequest("number has to be a positive integer");

            var result = await _service.GetAllDivisorsAndPrimeNumber(number);
            
            return Ok(result);
        }
    }
}
