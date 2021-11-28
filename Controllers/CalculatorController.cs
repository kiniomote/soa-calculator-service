using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1Api.Services;
using Lab1Api.Models;

namespace Lab1Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculator;

        public CalculatorController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpPost]
        [Route("calculate")]
        public async Task<ActionResult<double>> Calculate([FromBody]CalculateData calculateData)
        {
            double result = await _calculator.CalculateAsync(calculateData);

            return new JsonResult(result);
        }
    }
}
