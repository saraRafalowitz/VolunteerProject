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
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;

        public ProjectsController(IProjectService projectService,IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            var projects =await _projectService.GetAllAsync();
            return Ok(_mapper.Map<List<ProjectDTO>>(projects));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var project =await _projectService.GetByIdAsync(id);
            if (project != null)
            {
                var prog=_mapper.Map<ProjectDTO>(project);
                return Ok(prog);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] ProjectPostModel project)
        {
            var prog=await _projectService.GetByIdAsync(project.Id);
            if (prog == null)
            {
                var pro=_mapper.Map<Project>(project);
                _projectService.Create(pro);
                return Ok(pro);
            }
            return Conflict();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] Project updated)
        {
            var existing =await _projectService.GetByIdAsync(id);
            if (existing == null) return NotFound();

            existing.Name = updated.Name;
            existing.Description = updated.Description;
            existing.Date = updated.Date;
            existing.Status = updated.Status;
            return Ok(existing);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var project =await _projectService.GetByIdAsync(id);
            if (project == null) return NotFound();

            _projectService.DeleteAsync(project.Id);
            return Ok($"Project {id} deleted");
        }
    }
}
