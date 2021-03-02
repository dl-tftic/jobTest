using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ex2_API.Models;
using ex2_BLL.Services;
using ex2_API.Mappers;
using ex2_DAL.Models;


namespace ex2_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private PersonService _personService;

        public PersonController()
        {
            _personService = new PersonService();
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_personService.Get(id));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_personService.GetByFirstName(""));
        }

        [HttpGet("GetByFirstName/{firstName}")]
        public IActionResult GetByFirstName(string firstName)
        {
            return Ok(_personService.GetByFirstName(firstName));
        }

        [HttpGet("GetByLastName/{lastName}")]
        public IActionResult GetByLastName(string lastName)
        {
            return Ok(_personService.GetByLastName(lastName));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(_personService.Delete(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] PersonApi person)
        {
            if ((person.FirstName != string.Empty) && (person.LastName != string.Empty))
            {
                if (_personService.Add(person.ToDal()) == 1) return Ok();
                else return BadRequest("Person can't be added");
            }
            else return BadRequest("LastName and FirstName can't be empty");
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if ((person.FirstName != string.Empty) && (person.LastName != string.Empty))
            {
                if (_personService.Update(person) == 1) return Ok();
                else return BadRequest("Person can't be updated");
            }
            else return BadRequest("LastName and FirstName can't be empty");
        }


    }
}
