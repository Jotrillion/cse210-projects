using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1.Start breathing activity");
            Console.WriteLine("   2.Start reflecting activity");
            Console.WriteLine("   3.Start listing activity");
            Console.WriteLine("   4.Start yoga activity");
            Console.WriteLine("   5.Quit");
            Console.WriteLine("Select a choice from menu: ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {

                Console.WriteLine("Welcome to the Breathing Activity.");
                Console.WriteLine(" ");
                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                BreathingActivity activity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration);
                Console.WriteLine(activity.GetDescription());
                activity.Run();


                // Start breathing activity
            }
            else if (choice == "2")
            {
                Console.WriteLine("Welcome to the Reflecting Activity.");
                Console.WriteLine(" ");
                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                ReflectingActivity activity = new ReflectingActivity("Reflecting", "This activity will help you reflect on your thoughts and feelings.", duration, new List<string> { "Think of a time when you overcame a challenge.", "Recall a moment of personal achievement.", "Reflect on a time you helped someone in need." }, new List<string> { "Why was this experience meaningful to you?", "What did you learn about yourself?", "How can you apply this experience in the future?" });
                Console.WriteLine(activity.GetDescription());
                activity.Run();

                // Start reflecting activity
            }
            else if (choice == "3")
            {
                Console.WriteLine("Welcome to the Listing Activity.");
                Console.WriteLine(" ");
                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                ListingActivity activity = new ListingActivity("Listing", "This activity will help you list your thoughts and feelings.", duration, 0, new List<string> { "List as many things as you can that you are grateful for.", "List as many personal strengths as you can.", "List as many activities that make you happy." });
                Console.WriteLine(activity.GetDescription());
                activity.Run();

                // Start listing activity
            }
            else if (choice == "4")
            {
                Console.WriteLine("Welcome to the Yoga Activity.");
                Console.WriteLine(" ");
                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                Console.Write("What is the name of the yoga pose you would like to try? ");
                string Yoganame = Console.ReadLine();
                Console.Write("How many repetitions would you like to do? ");
                int reps = int.Parse(Console.ReadLine());
                YogaActivity activity = new YogaActivity("Yoga", "This activity will help you relax and focus through guided yoga poses.", duration, Yoganame, reps);
                Console.WriteLine(activity.GetDescription());
                activity.Run();
                Console.WriteLine(activity.YogaAct());
                // i have added the yoga activity to display the name and reps entered by the user and ran the yoga activity
            }
            else if (choice == "5")
            {
                break; // Exit the loop and end the program
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}