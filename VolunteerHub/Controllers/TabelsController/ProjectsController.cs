using Microsoft.AspNetCore.Mvc;
using VolunteerHub.Models;
using System.Collections.Generic;

namespace VolunteerHub.Controllers.TabelsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private static readonly List<Project> Projects = new();

        [HttpGet]
        public IActionResult GetAll() => Ok(Projects);

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var project = Projects.Find(p => p.Id == id);
            return project == null ? NotFound() : Ok(project);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Project project)
        {
            project.Id = Projects.Count + 1;
            Projects.Add(project);
            return CreatedAtAction(nameof(GetById), new { id = project.Id }, project);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Project updated)
        {
            var existing = Projects.Find(p => p.Id == id);
            if (existing == null) return NotFound();

            existing.Name = updated.Name;
            existing.Description = updated.Description;
            existing.Date = updated.Date;
            existing.Status = updated.Status;
            return Ok(existing);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var project = Projects.Find(p => p.Id == id);
            if (project == null) return NotFound();

            Projects.Remove(project);
            return Ok($"Project {id} deleted");
        }
    }
}
