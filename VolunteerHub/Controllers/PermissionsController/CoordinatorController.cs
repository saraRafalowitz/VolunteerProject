//using Microsoft.AspNetCore.Mvc;
//using VolunteerHub.Core.Models;

//[Route("api/[controller]")]
//[ApiController]
//public class CoordinatorController : ControllerBase
//{
//    // צפייה בפרויקטים שלו
//    [HttpGet("projects")]
//    public IActionResult GetProjects()
//    {
//        // TODO: החזרת רשימת פרויקטים של הרכז
//        return Ok("List of coordinator projects");
//    }

//    // פתיחת פרויקט חדש
//    [HttpPost("projects")]
//    public IActionResult CreateProject([FromBody] Project project)
//    {
//        // TODO: יצירת פרויקט חדש
//        return Ok("Project created");
//    }

//    // עריכת פרויקט קיים
//    [HttpPut("projects/{id}")]
//    public IActionResult EditProject(int id, [FromBody] Project project)
//    {
//        // TODO: עדכון פרויקט
//        return Ok($"Project {id} updated");
//    }

//    // צפייה במתנדבים של פרויקט
//    [HttpGet("projects/{id}/volunteers")]
//    public IActionResult GetProjectVolunteers(int id)
//    {
//        // TODO: החזרת רשימת מתנדבים
//        return Ok($"Volunteers for project {id}");
//    }

//    // מחיקת/סגירת פרויקט
//    [HttpDelete("projects/{id}")]
//    public IActionResult DeleteProject(int id)
//    {
//        // TODO: מחיקת פרויקט
//        return Ok($"Project {id} deleted");
//    }
//}

