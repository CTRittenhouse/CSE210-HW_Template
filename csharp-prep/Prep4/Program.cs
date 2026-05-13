using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = 1;
       
       while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0) {
                numbers.Add(userNumber);
            }
        }
        int totalSum = numbers.Sum();
        Console.WriteLine($"The sum is: {totalSum} ");
        
        double avg = numbers.Average();
        Console.WriteLine($"The average is: {avg} ");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest} ");

    }
}