using System;

class Program
{
    static void Main(string[] args)
    {

        string input = "";

        int guess = -1;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        do
        {

            Console.Write("Enter a guess: ");
            input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guess != magicNumber);


    }
}