using System;

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
//Note that you may need to use a for-loop. 

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("number{0}=", i);
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("Sum={0}", sum);
    }
}