namespace TestWebApp.Models;

public class Shot
{
    public int ShotNr { get; set; }
    public string Result { get; set; }
    public int FiringIndex { get; set; }
    public float FiringAngle { get; set; }
    public Vector FiringCoords { get; set; }
    public List<Vector> ShotXY { get; set; }
    public int HeartRate { get; set; }
    public float TimeToFire { get; set; }
}