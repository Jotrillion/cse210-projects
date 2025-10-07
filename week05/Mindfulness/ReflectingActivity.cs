using System;
using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }
    public void Run()
    {
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
        Console.WriteLine(" ");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine(" ");
        DisplayQuestions();
        DisplayEndingMessage();
        ShowSpinner(3);
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine(" ");
        
    }
    public void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine($"- {question}");
        }
    }
}