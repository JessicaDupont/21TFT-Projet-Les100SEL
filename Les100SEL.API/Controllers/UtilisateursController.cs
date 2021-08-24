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
        [HttpGet("Liste")]
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
        // GET: api/<UtilisateursController>
        [HttpGet("ListeAlertes")]
        public ActionResult<IEnumerable<IUtilisateur>> GetAlertes()
        {
            try
            {
                return Ok(utilisateurRepository.GetAlert());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        Method = "GetAlertes",
                        Message = ex.Message
                    });
            }
        }

        // GET api/<UtilisateursController>/5
        [HttpGet("Read={id}")]
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
        [HttpPost("Create")]
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
        [HttpPut("Update={id}")]
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
        // PUT api/<UtilisateursController>/5
        [HttpPut("Alerte={id}")]
        public ActionResult<string> Alerte(int id)
        {
            try
            {
                IUtilisateur result = utilisateurRepository.Alert(id);
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
        [HttpDelete("Delete={id}")]
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
