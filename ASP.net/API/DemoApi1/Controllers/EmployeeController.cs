using DemoApi1.Fake;
using DemoApi1.Fake.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DemoApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IContext _context;

        public EmployeeController(IContext context)
        {
            _context = context;
        }

        [HttpGet]
        //Récupère IEnumerable d'employee si le code de réponse est 200, c'est à dire OK
        [ProducesResponseType<IEnumerable<Employee>>(200)]
        //Récupère un string (ici l'erreur) en cas de code 500
        [ProducesResponseType<string>(500)]

        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Employees);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erreur interne de la base de données.");
            }
        }

        [HttpGet("{id:int:min(1)}")]
        [ProducesResponseType<Employee>(200)]
        [ProducesResponseType<int>(404)]
        [ProducesResponseType<string>(500)]

        public IActionResult Get(int id)
        {
            try
            {
                Employee data = _context.Employees.SingleOrDefault(e => e.Id == id);
                if (data is null)
                {
                    return NotFound(id);
                }
                return Ok(data);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erreur interne de la base de données.");
            }
        }

        [HttpPost]
        //Code 201 Code de réussite pour Post ou Put
        [ProducesResponseType<Employee>(201)]
        [ProducesResponseType<string>(500)]

        public IActionResult Post(Employee entity)
        {
            try
            {
                int maxId = _context.Employees.Max(e => e.Id);
                entity.Id = maxId + 1;
                _context.Employees.Add(entity);
                //Pour récupérer l'entity qu'on vient de créer
                return CreatedAtAction(nameof(Get), new { id = entity.Id }, entity);
            }
            catch (Exception)
            {

                return StatusCode(500, "Erreur interne de la base de données."); 
            }
        }

        [HttpPut("{id:int:min(1)}")]
        [ProducesResponseType<Employee>(201)]
        [ProducesResponseType<string>(500)]
        [ProducesResponseType<int>(404)]

        public IActionResult Put(int id, Employee entity)
        {
            try
            {
                entity.Id = id;
                int index = _context.Employees.FindIndex(e => e.Id == id);
                if (index == -1)
                {
                    return NotFound(id);
                }
                _context.Employees[index] = entity;
                return CreatedAtAction(nameof(Get), new { id }, entity);
            }
            catch (Exception)
            {

                return StatusCode(500, "Erreur interne de la base de données.");

            }
        }

        [HttpDelete("{id:int:min(1)}")]
        //Return Rien, delete response : 204
        [ProducesResponseType(204)]
        [ProducesResponseType<string>(500)]
        [ProducesResponseType<int>(404)]

        public IActionResult Delete(int id)
        {
            try
            {
                Employee e = _context.Employees.SingleOrDefault(e => e.Id == id);
                if (e is null)
                {
                    return NotFound(id);
                }
                _context.Employees.Remove(e);
                return NoContent();
            }
            catch (Exception)
            {

                return StatusCode(500, "Erreur interne de la base de données.");
            }
        }
    }
}
