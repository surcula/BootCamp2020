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
    public class UserController : ControllerBase
    {
        private readonly IUserService<User> _repository;
        public UserController(IUserService<User> repository)
        {
            _repository = repository;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<User> novels = _repository.GetAll();
                return Ok(novels);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                User novels = _repository.GetOne(id);
                return Ok(novels);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // POST api/<UserController>
        [HttpPost("Update")]
        public IActionResult Update(int id,[FromBody] UserForm user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.Update(id, new User(id,user.Email, user.Passwd,user.LastName,user.FirstName,user.Birthdate,user.Address,user.Cp,user.Land,user.Phone)) ;
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
        public IActionResult Add([FromBody] UserForm user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.Insert(new User(user.Id, user.Email, user.Passwd, user.LastName, user.FirstName, user.Birthdate, user.Address, user.Cp, user.Land, user.Phone));
                    return NoContent();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
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
