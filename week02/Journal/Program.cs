using System;

class Program
{


    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator._prompts.Add("What was the best part of your day ?");
        promptGenerator._prompts.Add("What was the most challenging part of your day?");
        promptGenerator._prompts.Add("What are you grateful for today?");
        promptGenerator._prompts.Add("What is one thing you learned today?");
        promptGenerator._prompts.Add("Describe a moment that made you smile today.");

        Journal journal = new Journal();


        int number = 0;


        while (number != 5)

        {

            Console.WriteLine("Welcome to the journal program.");
            //I wrote one of the causes that make people to not write in the journal 
            Console.WriteLine("One of those causes that make people to not write is they don't feel confident writing about what happened to them");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            number = int.Parse(choice);

            if (number == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string entry = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();


                Console.WriteLine($"Date: {dateText} - Prompt: {prompt}");
                Console.WriteLine(entry);

                //create a new entry
                Entry entries = new Entry();
                entries._date = dateText;
                entries._prompt = prompt;
                entries._response = entry;
                //add the entry to the journal
                journal.AddEntry(entries);



            }
            else if (number == 2)
            {
                journal.DisplayAll();
            }
            else if (number == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);

            }
            else if (number == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (number == 5)
            {
                Console.WriteLine("Thank you for using the journal program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }








    }
}