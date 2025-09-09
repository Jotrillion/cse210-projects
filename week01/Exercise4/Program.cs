using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        int number;
        List<int> numbers = new List<int>();
        do
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                int sum = 0;
                foreach (int num in numbers)
                {
                    sum += num;
                }
                Console.WriteLine($"The sum is: {sum}");
            }

        } while (number != 0);
        if (numbers.Count > 0)
        {
            
            double average = numbers.Average();
            int max = numbers.Max();

            
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Largest number: {max}");
        }
        else
        {
            Console.WriteLine("\nNo numbers were entered.");
        }
    }
}