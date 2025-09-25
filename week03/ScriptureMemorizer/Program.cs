using System;



class Program

{

    static void Main(string[] args)

    {

        List<Scripture> scriptures = new List<Scripture>();



        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));

        scriptures.Add(new Scripture(new Reference("Psalm", 127, 1), "Unless the LORD builds the house, the builders labor in vain. Unless the LORD watches over the city, the guards stand watch in vain."));

        scriptures.Add(new Scripture(new Reference("James", 1, 5), "If any of you lacks wisdom, you should ask God, who gives generously to all without finding fault, and it will be given to you."));

        scriptures.Add(new Scripture(new Reference("Galatians", 6, 9), "Let us not become weary in doing good, for at the proper time we will reap a harvest if we do not give up."));



        // 3. Create a Random object.

        Random random = new Random();



        // 4. Generate a random index to select a scripture.

        int randomIndex = random.Next(0, scriptures.Count);



        // 5. Select the random scripture from the list.

        Scripture randomScripture = scriptures[randomIndex];



        while (true)

        {

            Console.Clear();



            // 6. Display the chosen scripture.

            randomScripture.Display();

            Console.WriteLine();



            if (randomScripture.AllWordsHidden())

            {

                Console.WriteLine("All words are hidden. Well done!");
                break;


            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")

            {

                break;

            }

            randomScripture.HideRandomWords(3);

        }



    }

}