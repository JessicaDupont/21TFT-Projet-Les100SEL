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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesRepository categorieRepository;

        public CategoriesController(ICategoriesRepository categorieRepository)
        {
            this.categorieRepository = categorieRepository;
        }

        // GET: api/<CategoriesController>/Liste
        [HttpGet("Liste")]
        public ActionResult<IEnumerable<ICategorie>> Get()
        {
            try
            {
                return Ok(categorieRepository.Read());
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

        // GET api/<CategoriesController>/Read=5
        [HttpGet("Read={id}")]
        public ActionResult<ICategorie> Get(int id)
        {
            try
            {
                return Ok(categorieRepository.Read(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        Method = "Get(id)",
                        Message = ex.Message
                    });
            }
        }

        // POST api/<CategoriesController>/Add
        [HttpPost("Add")]
        public ActionResult<string> Post([FromBody] CategorieForm form)
        {
            try
            {
                if (form is null) { return BadRequest(); }
                ICategorie result = categorieRepository.Create(form);
                return Ok("La catégorie "+result.Nom+" a bien été ajoutée.");
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

        // PUT api/<CategoriesController>/Update=5
        [HttpPut("Update={id}")]
        public ActionResult<string> Put(int id, [FromBody] CategorieForm form)
        {
            try
            {
                if (form is null) { return BadRequest(); }
                ICategorie result = categorieRepository.Update(id, form);
                return Ok("La catégorie " + result.Nom + " a bien été mise à jour.");
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

        // DELETE api/<CategoriesController>/Delete=5
        [HttpDelete("Delete={id}")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                ICategorie result = categorieRepository.Delete(id);
                return Ok("La catégorie "+result.Nom+" a bien été supprimée.");
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
