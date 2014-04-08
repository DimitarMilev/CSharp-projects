using System;

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter number one: ");
        double numberOne = double.Parse(Console.ReadLine());
        Console.Write("Enter number two: ");
        double numberTwo = double.Parse(Console.ReadLine());
        Console.Write("Enter number three: ");
        double numberThree = double.Parse(Console.ReadLine());
        Console.Write("Enter number four: ");
        double numberFour = double.Parse(Console.ReadLine());
        Console.Write("Enter number five: ");
        double numberFive = double.Parse(Console.ReadLine());
        double sum = numberOne + numberTwo + numberThree + numberFour + numberFive;
        Console.WriteLine("{0} {1} {2} {3} {4}  {5}", numberOne, numberTwo, numberThree, numberFour, numberFive, sum);
    }
}
