using System;
public class YogaActivity : Activity
{
    private string _yoganame;
    private int _rep;
    public YogaActivity(string name, string description, int duration, string yoganame, int rep) : base(name, description, duration)
    {
        _yoganame = yoganame;
        _rep = rep;
    }

    public string GetYogaName()
    {
        return _yoganame;
    }

    public int GetRep()
    {

        return _rep;
    }
    public string YogaAct()
    {
        return $"The yoganame is {_yoganame} done in {_rep} reps";
    }
    public void Run()
    {
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
        Console.WriteLine(" ");
        Console.WriteLine($"Start your yoga session with {_yoganame} for {_rep} reps.");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine(" ");
        for (int i = 1; i <= _rep; i++)
        {
            Console.WriteLine($"Performing rep {i} of {_rep}...");
            System.Threading.Thread.Sleep(2000); // Simulate time taken for each rep
        }
        Console.WriteLine(" ");
        DisplayEndingMessage();
        ShowSpinner(3);
    }
}