namespace TestWebApp.Models;

public class Geometry
{
    public string Type => "Point";
    public float[] Coordinates { get; set; }
}