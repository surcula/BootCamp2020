using API_EntitiesForm;
using Api_ModelClient.Entities;
using Bibliotheque_Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_ProjetPersoBootcamp2020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesController : ControllerBase
    {
        private readonly ITypesRepo<Types> _repository;
        public TypesController(ITypesRepo<Types> repository)
        {
            _repository = repository;
        }
        // GET: api/<SeriesController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<Types> types = _repository.GetAll();
                return Ok(types);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET api/<SeriesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Types types = _repository.GetOne(id);
                return Ok(types);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // POST api/<SeriesController>
        [HttpPost("Add")]
        public IActionResult Post([FromBody] TypesForm typesForm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.Insert(new Types(typesForm.Id, typesForm.Type));
                    return Ok();

                }
                else
                    return BadRequest();

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // PUT api/<SeriesController>/5
        [HttpPut("update")]
        public IActionResult Put([FromBody] TypesForm typesForm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.Update(new Types(typesForm.Id, typesForm.Type));
                    return Ok();
                }
                else
                    return BadRequest();

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // DELETE api/<SeriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           
        }
    }
}
