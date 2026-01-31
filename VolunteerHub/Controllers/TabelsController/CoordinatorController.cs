using Microsoft.AspNetCore.Mvc;
using VolunteerHub.Core.Models;
using System.Collections.Generic;
using VolunteerHub.Core.Services;
using AutoMapper;
using VolunteerHub.Core.DTO;
using VolunteerHub.Models;

namespace VolunteerHub.Controllers.TabelsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatorController : ControllerBase
    {

        private readonly ICoordinatorService _coordinatorService;
        private readonly IMapper _mapper;

        public CoordinatorController(ICoordinatorService coordinatorService,IMapper mapper)
        {
            _coordinatorService = coordinatorService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var coordinator = _coordinatorService.GetAllAsync();
            return Ok(_mapper.Map<List<CoordinatorDTO>>(coordinator));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var coordinator =await _coordinatorService.GetByIdAsync(id);
            if (coordinator != null)
            {
                var coor= _mapper.Map<CoordinatorDTO>(coordinator);
                return Ok(coor);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] CoordinatorPostModel coordinator)
        {
            var coor=await _coordinatorService.GetByIdAsync(coordinator.Id);
            if(coor == null)
            {
                var coord=_mapper.Map<Coordinator>(coordinator);
                 _coordinatorService.Create(coord);
                return Ok(coord);
            }
            return Conflict();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] CoordinatorPostModel updated)
        {
            var coor =await _coordinatorService.GetByIdAsync(updated.Id);
            if (coor == null)
            {
                var coord = _mapper.Map<Coordinator>(updated);
                _coordinatorService.UpdateAsync(updated.Id,coord);
                return Ok(coord);
            }
            return Conflict();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var coordinator = await _coordinatorService.GetByIdAsync(id);
            if (coordinator == null) return NotFound();

            _coordinatorService.DeleteAsync(coordinator.Id);
            return Ok($"Coordinator {id} deleted");
        }
    }
}
