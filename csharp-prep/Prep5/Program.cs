using System;

class Program
{
// DisplayWelcome - Displays the message, "Welcome to the Program!"
// PromptUserName - Asks for and returns the user's name (as a string)
// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
// PromtUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born. The out parameter is set to their birth year. This function does not return a value. The user's birth year is given back from the function via the out parameter.
// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
// DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's name and squared number. Calculate hold many years old they will turn this year and display that.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your user name? ");
        string userName = Console.ReadLine();
        return userName;
    }   

    static double PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        double favNum = double.Parse(Console.ReadLine());
        return favNum;
    }

    static void PromtUserBirthYear(out int birthYear)
    {
        Console.Write("What is your birth year? ");
        birthYear = int.Parse(Console.ReadLine());        
    }

    static double SquareNumber(double number)
    {

        return number * number;
    }

    static void DisplayResult(string userName, double number, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int currentAge = currentYear - birthYear;
        Console.WriteLine($"{userName}, {SquareNumber(number)}, you will turn {currentAge} this year. ");        
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        double favnum = PromptUserNumber();
        
        int birthYear;
        PromtUserBirthYear(out birthYear);

        DisplayResult(userName, favnum, birthYear);
    }
}