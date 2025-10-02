using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("C# Tutorial", "John Doe", 600);
        Video video2 = new Video("Learn Python", "Jane Smith", 900);
        Video video3 = new Video("JavaScript Basics", "Mike Johnson", 750);
        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Eve", "Could you explain more about classes?"));
        // Add comments to video2
        video2.AddComment(new Comment("Charlie", "I love Python!"));
        video2.AddComment(new Comment("Dave", "This was a bit fast-paced."));
        video2.AddComment(new Comment("Eve", "Can you make a follow-up video?"));
        // Add comments to video3
        video3.AddComment(new Comment("Frank", "JavaScript is awesome!"));
        video3.AddComment(new Comment("Grace", "Thanks for the clear explanations."));
        video3.AddComment(new Comment("Heidi", "Looking forward to more content!"));
        // Display information about video1
        Console.WriteLine(video1.GetDisplayText());
        foreach (Comment comment in video1.GetComments())
        {
            Console.WriteLine(comment.GetDisplayText());
        }

        Console.WriteLine(); // Blank line for separation

        // Display information about video2
        Console.WriteLine(video2.GetDisplayText());
        foreach (Comment comment in video2.GetComments())
        {
            Console.WriteLine(comment.GetDisplayText());
        }
        Console.WriteLine();
        // Blank line for separation
        // Display information about video3
        Console.WriteLine(video3.GetDisplayText());
        foreach (Comment comment in video3.GetComments())
        {
            Console.WriteLine(comment.GetDisplayText());
        }
        Console.WriteLine();

        // Blank line for separation
       

    }
}