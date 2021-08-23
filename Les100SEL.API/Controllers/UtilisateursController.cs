using Les100SEL.DA.Repositories.Bases;
using Les100SEL.Models.Forms;
using Les100SEL.Models.IModels;
using Microsoft.AspNetCore.Http;
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
    public class UtilisateursController : ControllerBase
    {
        private readonly IUtilisateurRepository utilisateurRepository;

        public UtilisateursController(IUtilisateurRepository utilisateurRepository)
        {
            this.utilisateurRepository = utilisateurRepository;
        }

        // GET: api/<UtilisateursController>
        [HttpGet]
        public ActionResult<IEnumerable<IUtilisateur>> Get()
        {
            try
            {
                return Ok(utilisateurRepository.Read());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        Method = "Get",
                        Message = ex.Message
                    });
            }
        }

        // GET api/<UtilisateursController>/5
        [HttpGet("{id}")]
        public ActionResult<IUtilisateur> Get(int id)
        {
            try
            {
                return Ok(utilisateurRepository.Read(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        Method = "Get",
                        Message = ex.Message
                    });
            }
        }

        // POST api/<UtilisateursController>
        [HttpPost]
        public ActionResult<string> Post([FromBody] UtilisateurForm form)
        {
            try
            {
                if (form is null) { return BadRequest(); }
                IUtilisateur result = utilisateurRepository.Create(form);
                return Ok($"L'utilisateur {result.Nom} a bien été ajouté.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        Method = "Post",
                        Message = ex.Message
                    });
            }
        }

        // PUT api/<UtilisateursController>/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] UtilisateurForm form)
        {
            try
            {
                if (form is null) { return BadRequest(); }
                IUtilisateur result = utilisateurRepository.Update(id, form);
                return Ok($"L'utilisateur {result.Nom} a bien été modifié.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        Method = "Put",
                        Message = ex.Message
                    });
            }
        }

        // DELETE api/<UtilisateursController>/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                IUtilisateur result = utilisateurRepository.Delete(id);
                return Ok("L'utilisateur " + result.Nom + " a bien été supprimé.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        Method = "Delete(id)",
                        Message = ex.Message
                    });
            }
        }
    }
}
