using System;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");
    }
    public void ShowSpinner(int seconds)
    {
        Console.Write("Spinner: ");
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            foreach (char c in "|/-\\")
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public string GetDescription()
    {
        return _description;
    }
}
