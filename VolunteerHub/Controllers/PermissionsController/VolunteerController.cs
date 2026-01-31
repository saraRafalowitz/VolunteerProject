//using Microsoft.AspNetCore.Mvc;
//using VolunteerHub.Core.Models;

//[Route("api/[controller]")]
//[ApiController]
//public class VolunteerController : ControllerBase
//{
//    // הצטרפות לפרויקט
//    [HttpPost("projects/{projectId}/join")]
//    public IActionResult JoinProject(int projectId)
//    {
//        // TODO: הוספת המתנדב לרשימת המשתתפים
//        return Ok($"Volunteer joined project {projectId}");
//    }

//    // עריכת פרטים אישיים
//    [HttpPut("{id}")]
//    public IActionResult UpdateProfile(int id, [FromBody] Volunteer updatedVolunteer)
//    {
//        // TODO: עדכון פרטי מתנדב
//        return Ok($"Volunteer {id} updated");
//    }

//    // ביטול השתתפות בפרויקט
//    [HttpDelete("projects/{projectId}/leave")]
//    public IActionResult LeaveProject(int projectId)
//    {
//        // TODO: הסרה מרשימת משתתפים
//        return Ok($"Volunteer left project {projectId}");
//    }

//    // אין GET /volunteers/{id} → אין צפייה בפרטים
//}


