using Les100SEL.Models.Forms;
using Les100SEL.Models.IModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Les100SEL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropositionsController : ControllerBase
    {
        // GET: api/<ServicesProposesController>
        [HttpGet]
        public ActionResult<IEnumerable<IProposition>> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/<ServicesProposesController>/5
        [HttpGet("{id}")]
        public ActionResult<IProposition> Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<ServicesProposesController>
        [HttpPost]
        public ActionResult<string> Post([FromBody] PropositionForm form)
        {
            throw new NotImplementedException();
        }

        // PUT api/<ServicesProposesController>/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] PropositionForm form)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<ServicesProposesController>/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
