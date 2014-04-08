using System;

//Write a program that reads 3 integer numbers from the console and prints their sum.
class SumThreeInt
{

    static void Main()
    {

        Console.WriteLine("Enter the first integer number:");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer number:");
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third integer number:");
        int thirdNum = int.Parse(Console.ReadLine());

        int sum = firstNum + secondNum + thirdNum;
        Console.WriteLine("The sum of your three numbers is {0}", sum);
    }
}

