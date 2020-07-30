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
        public ActionResult<DivisorCaluculationDTO> Get()
        {
            var result = new DivisorCaluculationDTO();

            return result;
        }

        // GET: api/<CalculationController>
        [HttpGet("{number}")]
        public ActionResult<DivisorCaluculationDTO> Get(int number)
        {
            if (number < 0)
                return BadRequest("number has to be a positive integer");

            var result = _service.GetAllDivisorsAndPrimeNumber(number);

            return Ok(result);
        }

        // POST api/<CalculationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CalculationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CalculationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
