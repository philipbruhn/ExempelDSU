using Microsoft.AspNetCore.Mvc;
using TestWebApp.Models;
using static TestWebApp.Repository.MockRepository;


namespace TestWebApp.Controllers;
[ApiController]
[Route("api")]
public class ApiController : Controller
{
    [HttpGet("{ibuId}")]
    public ActionResult<TrainingSession[]> Training(string ibuId, DateTime fromDate, DateTime toDate)
    {
        var trainingSessions = GetTrainingSessionsForAthlete(ibuId, fromDate, toDate);
        return Ok(trainingSessions);
    }
}