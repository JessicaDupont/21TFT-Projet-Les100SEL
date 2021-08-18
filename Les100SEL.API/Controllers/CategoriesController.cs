using Les100SEL.DA.Repositories.Bases;
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

        /// <summary>
        /// fourni la liste complète des catégories et sous-catégories
        /// </summary>
        /// <returns></returns>
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
                        Method = "Get",
                        Message = ex.Message
                    });
            }
        }

        //// POST api/<CategoriesController>
        //[HttpPost]
        //public void Post([FromBody] CategorieForm value)
        //{
        //}

        //// PUT api/<CategoriesController>/Update=5
        //[HttpPut("Update={id}")]
        //public void Put(int id, [FromBody] CategorieForm value)
        //{
        //}

        //// DELETE api/<CategoriesController>/Delete=5
        //[HttpDelete("Delete={id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
