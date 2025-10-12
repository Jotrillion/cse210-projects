using System;
using System.Collections.Generic;
public abstract class Activity
{
    private List<string> _activities = new List<string>();
    private string _name;

    protected int _duration; // in minutes
    protected int _distance; // in meters



    private string _date ;

    public Activity(List<string> activities, string name, int duration, string date, int distance)
    {
        _activities = activities;
        _name = name;

        _duration = duration;
        _date = date;
        _distance = distance;
    }

    public List<string> GetActivities()
    {
        return _activities;
    }
    public void SetActivities(List<string> activities)
    {
        _activities = activities;
    }




    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }


    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting activity: {_name}");

        Console.WriteLine($"Duration: {_duration} minutes");
    }

    public virtual void End()
    {
        Console.WriteLine($"Ending activity: {_name}");
        Console.WriteLine("Well done!");
    }
    public string GetDate()
    {
        return _date.ToString();
    }
    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetSummary()
    {
        return $"{_date} - {_name}  Duration: {_duration} min, Distance: {GetDistance()} m, Speed: {GetSpeed()} m/min, Pace: {GetPace()} min/m";
    }

    public abstract int GetDistance();

    public abstract int GetSpeed();
    public abstract int GetPace();

}