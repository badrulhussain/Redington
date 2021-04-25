using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Redington.BusinessLayer.Logic.ILogic;
using Redington.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Redington.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProbabilityCalculatorController : ControllerBase
    {
        private readonly IProbabilityCalculation _probabilityCalculation;
        public ProbabilityCalculatorController(IProbabilityCalculation _probabilityCalculation,
            IWebHostEnvironment hostEnvironment)
        {
            this._probabilityCalculation = _probabilityCalculation;
        }

        // GET: api/<ProbabilityCalculatorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProbabilityCalculatorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProbabilityCalculatorController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Probability probability)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var resualt = _probabilityCalculation.Get(probability);

            return NoContent();
        }

        // PUT api/<ProbabilityCalculatorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProbabilityCalculatorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
