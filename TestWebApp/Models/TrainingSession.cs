namespace TestWebApp.Models;

public class TrainingSession
{
    public Guid Id { get; set; }
    public string Shooter { get; set; } 
    public DateTime Date { get; set; } 
    public Geometry Geometry { get; set; } 
    public string Location { get; set; } 
    public string IbuId { get; set; } 
    public List<Series> Results { get; set; } 
}