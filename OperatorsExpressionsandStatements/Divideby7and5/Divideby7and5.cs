using System;

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time

class Divideby7and5
{
    static void Main()
    {
        Console.WriteLine("Enter the number here:");
        int number = int.Parse(Console.ReadLine());

        bool x = number % 5 == 0;
        bool y = number % 7 == 0;
        Console.WriteLine(x && y);
    }
}
