using TestWebApp.Models;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace TestWebApp.Repository;

public static class MockRepository
{
    private static string jsonString = File.ReadAllText("Repository/MockData.json");

    private static List<TrainingSession> context =
        Newtonsoft.Json.JsonConvert.DeserializeObject<List<TrainingSession>>(jsonString);

    public static TrainingSession[] GetTrainingSessionsForAthlete(string ibuId, DateTime fromDate, DateTime toDate)
    {
        toDate = toDate.AddDays(1).AddMilliseconds(-1);
        return context.Where(ts => ts.Date >= fromDate && ts.Date <= toDate)
            .ToArray();
    }
}