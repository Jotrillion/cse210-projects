using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Activity> activities = new List<Activity>
        {
            new Running(new List<string> { "Running" }, "Morning Run", 30, "10/01/2024", 5000),
            new Cycling(new List<string> { "Cycling" }, "Evening Ride", 45, "10/01/2024", 15000),
            new Swimming(new List<string> { "Swimming" }, "Afternoon Swim", 60, "10/01/2024", 30, 1500)
        };

        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}