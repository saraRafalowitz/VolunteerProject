using Microsoft.AspNetCore.Mvc;
using VolunteerHub.Models;
using System.Collections.Generic;

namespace VolunteerHub.Controllers.TabelsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatorsController : ControllerBase
    {
        private static readonly List<Coordinator> Coordinators = new();

        [HttpGet]
        public IActionResult GetAll() => Ok(Coordinators);

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var coordinator = Coordinators.Find(c => c.Id == id);
            return coordinator == null ? NotFound() : Ok(coordinator);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Coordinator coordinator)
        {
            coordinator.Id = Coordinators.Count + 1;
            Coordinators.Add(coordinator);
            return CreatedAtAction(nameof(GetById), new { id = coordinator.Id }, coordinator);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Coordinator updated)
        {
            var existing = Coordinators.Find(c => c.Id == id);
            if (existing == null) return NotFound();

            existing.FullName = updated.FullName;
            existing.Projects = updated.Projects;
            return Ok(existing);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var coordinator = Coordinators.Find(c => c.Id == id);
            if (coordinator == null) return NotFound();

            Coordinators.Remove(coordinator);
            return Ok($"Coordinator {id} deleted");
        }
    }
}
