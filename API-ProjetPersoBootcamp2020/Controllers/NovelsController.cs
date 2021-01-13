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
    public class NovelsController : ControllerBase
    {
        private readonly INovelsService<Novels> _repository;
        public NovelsController(INovelsService<Novels> repository) 
        {
            _repository = repository;
        }


        // GET: api/<NovelsController>
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                 IEnumerable<Novels> novels = _repository.GetAll().ToList();
                return Ok(novels);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET api/<NovelsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Novels novels = _repository.GetOne(id);
                return Ok(novels);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // POST api/<NovelsController>
        [HttpPost("Update")]
        public IActionResult Update([FromBody] NovelsForm novels)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.Update(new Novels(novels.Id, novels.Title, novels.SerieId, novels.Serie, novels.Authors, novels.SerialNumber,novels.Price,novels.Informations,novels.Langue,novels.Dimension,novels.Published,novels.Type,novels.TypeId)); ;
                    return NoContent();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost("Add")]
        public IActionResult Add([FromBody] NovelsForm novels)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.Add(new Novels(novels.Id, novels.Title, novels.SerieId, novels.Serie, novels.Authors, novels.SerialNumber, novels.Price, novels.Informations, novels.Langue, novels.Dimension, novels.Published, novels.Type, novels.TypeId)); ;
                    return NoContent();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // PUT api/<NovelsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NovelsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _repository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
