using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment quiz = new Assignment("monica", "love");
        Console.WriteLine(quiz.GetSummary());
        MathAssignment quiz1 = new MathAssignment("nomica", "love", "Problems", "7.3", "Sections", "7-9");
        Console.WriteLine(quiz1.GetSummary());
        Console.WriteLine(quiz1.GetHomeworkList());
        WritingAssignment titl = new WritingAssignment("monica", "love", "love of jo and monica");
        Console.WriteLine(titl.GetWritingInformation());
    }
}