using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaintenancePlatform.Server.Services;
using MaintenancePlatform.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MaintenancePlatform.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentenanteController : ControllerBase
    {
        private readonly MentenantaService _service;

        public MentenanteController(MentenantaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mentenanta>>> GetMentenante()
        {
            return await _service.GetMentenanteAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Mentenanta>> GetMentenanta(int id)
        {
            var mentenanta = await _service.GetMentenantaByIdAsync(id);

            if (mentenanta == null)
            {
                return NotFound();
            }

            return mentenanta;
        }

        [HttpPost]
        public async Task<ActionResult<Mentenanta>> PostMentenanta(Mentenanta mentenanta)
        {
            await _service.AddMentenantaAsync(mentenanta);
            return CreatedAtAction("GetMentenanta", new { id = mentenanta.Id }, mentenanta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMentenanta(int id, Mentenanta mentenanta)
        {
            if (id != mentenanta.Id)
            {
                return BadRequest();
            }

            await _service.UpdateMentenantaAsync(mentenanta);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMentenanta(int id)
        {
            await _service.DeleteMentenantaAsync(id);
            return NoContent();
        }
    }
}
