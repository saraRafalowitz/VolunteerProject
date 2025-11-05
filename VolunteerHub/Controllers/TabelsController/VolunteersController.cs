using Microsoft.AspNetCore.Mvc;
using VolunteerHub.Models;   // או Modules
using System.Collections.Generic;

namespace VolunteerHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteersController : ControllerBase
    {
        private static readonly List<Volunteer> Volunteers = new();

        [HttpGet]
        public IActionResult GetAll() => Ok(Volunteers);

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var volunteer = Volunteers.Find(v => v.Id == id);
            return volunteer == null ? NotFound() : Ok(volunteer);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Volunteer volunteer)
        {
            volunteer.Id = Volunteers.Count + 1;
            Volunteers.Add(volunteer);
            return CreatedAtAction(nameof(GetById), new { id = volunteer.Id }, volunteer);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Volunteer updatedVolunteer)
        {
            var existing = Volunteers.Find(v => v.Id == id);
            if (existing == null) return NotFound();

            existing.FullName = updatedVolunteer.FullName;
            existing.Email = updatedVolunteer.Email;
            existing.Phone = updatedVolunteer.Phone;
            existing.Status = updatedVolunteer.Status;
            return Ok(existing);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var volunteer = Volunteers.Find(v => v.Id == id);
            if (volunteer == null) return NotFound();

            Volunteers.Remove(volunteer);
            return Ok($"Volunteer {id} deleted");
        }
    }
}
