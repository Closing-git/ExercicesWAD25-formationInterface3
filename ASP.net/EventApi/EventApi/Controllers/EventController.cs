using Event.Fake;
using Event.Fake.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IContext _context;

        public EventController(IContext context)
        {
            _context = context;
        }


        [HttpGet]
        [ProducesResponseType<Evenement>(200)]
        [ProducesResponseType<string>(500)]

        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Evenement);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erreur interne de la base de données");
            }
        }

        [HttpPut]
        [ProducesResponseType<Evenement>(201)]
        [ProducesResponseType<string>(500)]
        public IActionResult Put(Evenement entity)
        {
            try
            {
                _context.Evenement = entity;
                return CreatedAtAction(nameof(Get), null, entity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erreur interne de la base de données");
            }
        }
    }
}
