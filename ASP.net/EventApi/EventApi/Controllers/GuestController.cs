using Event.Fake;
using Event.Fake.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IContext _context;

        public GuestController(IContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType<IEnumerable<Guest>>(200)]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Guests);
            }
            catch (Exception)
            {

                return StatusCode(500, "Erreur interne de la base de données");
            }
        }


        [HttpGet("{id:int:min(1)}")]
        [ProducesResponseType<Guest>(200)]
        [ProducesResponseType<int>(404)]
        [ProducesResponseType<string>(500)]


        public IActionResult Get(int id)
        {
            try
            {
                Guest? data = _context.Guests.SingleOrDefault(g => g.Id == id);
                if (data is null) return NotFound(id);
                return Ok(data);
            }
            catch (Exception)
            {

                return StatusCode(500, "Erreur interne de la base de données");
            }
        }

        [HttpPost]
        [ProducesResponseType<Guest>(201)]
        [ProducesResponseType<string>(500)]

        public IActionResult Post(Guest entity)
        {
            try
            {
                int maxId = _context.Guests.Max(g => g.Id);
                entity.Id = maxId + 1;
                entity.IsComing = false;
                _context.Guests.Add(entity);
                
                return CreatedAtAction(nameof(Get), new { id = entity.Id }, entity);
            }
            catch (Exception)
            {

                return StatusCode(500, "Erreur interne de la base de données");
            }
        }

        [HttpPut("{id:int:min(1)}")]
        [ProducesResponseType<Guest>(201)]
        [ProducesResponseType<int>(404)]
        [ProducesResponseType<string>(500)]

        public IActionResult Put(int id, Guest entity)
        {
            try
            {
                entity.Id = id;
                entity.IsComing = true;
                int index = _context.Guests.FindIndex(g => g.Id == id);
                if (index == -1) return NotFound(id);
                entity.LastName = _context.Guests[index].LastName;
                entity.ForName = _context.Guests[index].ForName;

                _context.Guests[index]=entity;

                return CreatedAtAction(nameof(Get), new { id = entity.Id }, entity);
            }
            catch (Exception)
            {

                return StatusCode(500, "Erreur interne de la base de données");
            }
        }


        [HttpDelete("{id:int:min(1)}")]
        [ProducesResponseType(204)]
        [ProducesResponseType<int>(404)]
        [ProducesResponseType<string>(500)]

        public IActionResult Delete (int id) {
            try
            {
                Guest? g = _context.Guests.SingleOrDefault(g => g.Id == id);
                if (g == null) return NotFound(id);
                _context.Guests.Remove(g);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "Erreur interne de la base de données"); throw;
            }

    }
}
