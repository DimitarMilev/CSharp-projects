using System;

//Write a program that gets two numbers from the console and prints the greater of them. 
//Try to implement this without if statements.

class NumberComparer
{
    static void Main()
    {
        Console.Write("First Number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("SecondNumber:");
        double secondNum = double.Parse(Console.ReadLine());
        double greater = firstNum > secondNum ? firstNum : secondNum;
        Console.WriteLine(greater);

    }
}
