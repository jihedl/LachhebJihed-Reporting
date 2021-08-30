using Reporting.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reporting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactureController : ControllerBase
    {
        private readonly ApiContext _fcontext;
        public FactureController(ApiContext fcontext)
        {
            _fcontext = fcontext;
        }
        // GET: api/<FactureController>
        [HttpGet]
       
          public IActionResult Get() {   
        var response = _fcontext.Facture.OrderBy(s => s.IdFacture).ToList();return Ok(response);
        }
       

        [HttpGet("ByPeriode")]

        public IActionResult ByPeriode()
        {
            var factures = _fcontext.Facture.Where(o => o.Periode.Contains("2020")).ToList();
            var groupeResult = factures.GroupBy(o => o.Periode.ToUpper())
                .ToList()
                .Select(grp => new
                {
                    Periode = grp.Key,
                    MontantTotalC = grp.Where(c => c.IdClient.Equals(455)).Sum(x => x.MontantTotal),
                    MontantTotal = grp.Sum(x => x.MontantTotal)

                })
                
                .ToList();

            return Ok(groupeResult);
        }




        // GET api/<FactureController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FactureController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FactureController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FactureController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
