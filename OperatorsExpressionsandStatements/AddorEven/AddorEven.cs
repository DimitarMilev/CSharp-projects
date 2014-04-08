using System;

//Write an expression that checks if given integer is odd or even.

class AddorEven
{
    static void Main()
    {
        Console.WriteLine("Enter your number here");
        string AddorEven = Console.ReadLine();
        int ToNumber = Convert.ToInt32(AddorEven);

        if (ToNumber % 2 == 0)
        {
            Console.WriteLine("The entered number is even");
        }
        else
        {
            Console.WriteLine("The entered number is odd");
        }
    }
}

