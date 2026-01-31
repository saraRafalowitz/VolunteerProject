using Microsoft.AspNetCore.Mvc;
using VolunteerHub.Core.Models;
using System.Collections.Generic;
using VolunteerHub.Core.Services;
using AutoMapper;
using VolunteerHub.Core.DTO;
using VolunteerHub.Models;

namespace VolunteerHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteersController : ControllerBase
    {
        private readonly IVolunteerService _volunteerService;
        private readonly IMapper _mapper;

        public VolunteersController(IVolunteerService volunteerService,IMapper mapper)
        {
            _volunteerService = volunteerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            var volunteer=await _volunteerService.GetAllAsync();
            return Ok(_mapper.Map<List<ProjectDTO>>(volunteer));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var v=await _volunteerService.GetByIdAsync(id);
            if(v != null)
            {
                var vol= _mapper.Map<ProjectDTO>(v);
                return Ok(vol);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] VolunteerPostModel volunteer)
        {
            var vol=await _volunteerService.GetByIdAsync(volunteer.Id);
            if(vol == null)
            {
                var volunteer1 = _mapper.Map<Volunteer>(volunteer);
                _volunteerService.Create(volunteer1);
                return Ok(volunteer1);
            }
            return Conflict();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] Volunteer updatedVolunteer)
        {
            var existing =await _volunteerService.GetByIdAsync(id);
            if (existing == null) return NotFound();

            existing.FullName = updatedVolunteer.FullName;
            existing.Email = updatedVolunteer.Email;
            existing.Phone = updatedVolunteer.Phone;
            existing.Status = updatedVolunteer.Status;
            return Ok(existing);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var volunteer =await _volunteerService.GetByIdAsync(id);
            if (volunteer == null) return NotFound();

            _volunteerService.DeleteAsync(volunteer.Id);
            return Ok($"Volunteer {id} deleted");
        }
    }
}
