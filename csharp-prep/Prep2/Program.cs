using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?  ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        if (number >= 90 && number <= 100)

        {
            Console.WriteLine("Your grade is an A! ");
        }
        else if (number >= 80 && number <= 89)
        {
            Console.WriteLine("Your grade is a B ");
        }
        else if (number >= 70 && number <= 79)
        {
            Console.WriteLine("Your grade is a C ");
        }
        else if (number >= 60 && number <= 69)
        {
            Console.WriteLine("Your grade is a F :( ");
        }
        else if (number >= 0 && number <= 59)
        {
            Console.WriteLine("Your grade is a B ");
        }
        else if (number > 100)
        {
            Console.WriteLine("Okay Big-Shot! Youre cool! ;) ");
        }
        else
        {
            Console.WriteLine("I didnt think that was possible... ");
        }


    }
}