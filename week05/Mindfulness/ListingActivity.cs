using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }
    public void Run()
    {
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
        Console.WriteLine(" ");
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine(" ");
        List<string> responses = GetListFromUser();
       
        Console.WriteLine($"You listed {responses.Count} items!");
        DisplayEndingMessage();
        ShowSpinner(3);
    }
    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        Console.WriteLine(" ");

       }
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }
        return responses;

    }
}