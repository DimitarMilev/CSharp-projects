using System;
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
//(at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may
//need to learn how to use loops. 
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        int f0 = 0;
        int f1 = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(f0 + " ");
            int temp = f0;
            f0 = f1;
            f1 = temp + f1;
        }
    }
}