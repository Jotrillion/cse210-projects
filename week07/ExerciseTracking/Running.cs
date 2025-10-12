using System;
public class Running : Activity
{
    // in steps per minute
    public Running(List<string> activities, string name,  int duration,  string date, int distance)
        : base(activities, name, duration, date, distance)
    {

    }
    

    public override int GetPace()
    {
        // Pace in minutes per kilometer
        return (GetDuration() / GetDistance());

    }

    public override int GetSpeed()
    {
        // Speed in kilometers per hour
        return (GetDistance() * 60) / GetDuration();

    }
    public override int GetDistance()
    {
        // Distance in kilometers
        return _distance / 1000;
    }

    public new string GetSummary()
    {
        return $"{GetDate()} - {GetName()}  - Duration: {GetDuration()} min - Distance: {GetDistance()} m - Speed: {GetSpeed()} m/min - Pace: {GetPace()} spm";
    }
}