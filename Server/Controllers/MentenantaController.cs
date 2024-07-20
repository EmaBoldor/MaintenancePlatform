using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MaintenancePlatform.Shared;

namespace MaintenancePlatform.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentenantaController : ControllerBase
    {
        private readonly MentenantaService _mentenantaService;

        public MentenantaController(MentenantaService mentenantaService)
        {
            _mentenantaService = mentenantaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Mentenanta>>> Get()
        {
            return await _mentenantaService.GetAll();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Mentenanta mentenanta)
        {
            await _mentenantaService.Add(mentenanta);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mentenantaService.Remove(id);
            return Ok();
        }
    }
}

