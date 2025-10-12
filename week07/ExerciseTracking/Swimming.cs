using System;
public class Swimming : Activity
{
    private int _laps;
    // in min/m

    public Swimming(List<string> activities, string name, int duration, string date, int laps, int distance)
        : base(activities, name, duration, date, distance)
    {
        _laps = laps;

    }
    
    public int GetLaps()
    {
        return _laps;
    }

    public void SetLaps(int laps)
    {
        _laps = laps;
    }






    public override int GetDistance()
    {
        // Distance in meters
        return _laps * 50;
    }
    public override int GetSpeed()
    {
        // Speed in meters per minute
        return GetDistance() / GetDuration();
    }
    public override int GetPace()
    {
        // Pace in minutes per 100 meters
        return (int)Math.Round((double)GetDuration() / (GetDistance() / 100.0));
    }
    public new string GetSummary()
    {
        return $"{GetDate()} - {GetName()} - Duration: {GetDuration()} min, Distance: {GetDistance()} m, Speed: {GetSpeed():0.00} m/min, Pace: {GetPace():0.00} min/m, Laps: {_laps}";
    }
}