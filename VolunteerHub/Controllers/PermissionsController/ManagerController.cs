//using Microsoft.AspNetCore.Mvc;
//using VolunteerHub.Core.Models;

//[Route("api/[controller]")]
//[ApiController]
//public class ManagerController : ControllerBase
//{
//    // כל הפרויקטים בעמותה
//    [HttpGet("projects")]
//    public IActionResult GetAllProjects()
//    {
//        // TODO: החזרת כל הפרויקטים
//        return Ok("All projects");
//    }

//    // כל המתנדבים
//    [HttpGet("volunteers")]
//    public IActionResult GetAllVolunteers()
//    {
//        // TODO: החזרת רשימת מתנדבים
//        return Ok("All volunteers");
//    }

//    // כל הרכזים
//    [HttpGet("coordinators")]
//    public IActionResult GetAllCoordinators()
//    {
//        // TODO: החזרת רשימת רכזים
//        return Ok("All coordinators");
//    }

//    // הוספת רכז חדש
//    [HttpPost("coordinators")]
//    public IActionResult AddCoordinator([FromBody] Coordinator coordinator)
//    {
//        // TODO: הוספת רכז חדש
//        return Ok("Coordinator added");
//    }

//    // הסרת מתנדב
//    [HttpDelete("volunteers/{id}")]
//    public IActionResult RemoveVolunteer(int id)
//    {
//        // TODO: מחיקת מתנדב
//        return Ok($"Volunteer {id} removed");
//    }
//}

