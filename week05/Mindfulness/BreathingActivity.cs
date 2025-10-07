using System;
public class BreathingActivity : Activity
{

  public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
  {
    _name = "Breathing";
    _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    _duration = duration;
   }
    public void Run()
  {
    Console.WriteLine("Get ready to begin...");
    ShowSpinner(3);
    Console.WriteLine(" ");
    Console.WriteLine("Breathe in...");
    ShowCountDown(4);
    Console.WriteLine(" ");
    Console.WriteLine("Breathe out...");
    ShowCountDown(6);
    Console.WriteLine(" ");
    Console.WriteLine("Breathe in...");
    ShowCountDown(4);
    Console.WriteLine(" ");
    Console.WriteLine("Breathe out...");
    ShowCountDown(6);
    Console.WriteLine(" ");
    DisplayEndingMessage();
    ShowSpinner(3);
  }
}
