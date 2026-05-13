using System;

class Program
{

    static void DisplayGreeting()
        {
            Console.WriteLine("Johnny's got a new pair of pants! ");
        }
        

        static int AddNumbers(int n1, int n2, double n3)
        {
            double total = n1 + n2 + n3;
            return total;
        }
    static void Main(string[] args)
    {
        DisplayGreeting();
        // Console.WriteLine("Hello Sandbox World!");

        // int x = 10;
        
        // if (x==10)
        // {
        //     Console.WriteLine("Hey bob");
        // }
        // for (int i = 0; i < 10; i++ )
        // {
        //     Console.WriteLine(i);
        // }

        // int age = -1;

        // while (age < 0 || age > 120)
        // {
        //     Console.WriteLine("Please enter your age: ");
        //     age = int.Parse(Console.ReadLine());
        // }
        // int age2;

        // do
        // {
        //     Console.WriteLine("Please enter your age: ");
        //     age2 = int.Parse(Console.ReadLine());
        // }
        // while (age2 < 0 || age2 > 125);

        // for (int i = 0; i <= 32; ++i)
        // {
        // int powerNumber = (int)Math.Pow(2, i);
        // Console.Write($"2 to the power of {i}, is: {powerNumber}");
        // Console.WriteLine($", 0x{powerNumber.ToString("x")}");
        // }

        List<int> myData = new List<int>();
        myData.Add (1);
        myData.Add (2);
        myData.Add (3);
        myData.Add (4);
        myData.Add (5);
        myData.Add (99);
        myData.Add (-100);
        foreach(int i in myData)
        {
            Console.WriteLine(i);
        }
        

    }   

    
}