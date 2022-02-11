namespace TestWebApp.Models;

public class Series
{
    public string Stance { get; set; }
    public DateTime DateTime { get; set; }
    public List<Shot> Shots { get; set; }
}