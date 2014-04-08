using System;

//Write a program that reads two positive integer numbers and prints how many numbers p exist 
//between them such that the reminder of the division by 5 is 0.

class NumbersInInterval
{
    
    static void Main()
    {
        Console.Write("Start= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Stop= ");
        int b = int.Parse(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i);
                if (i < b - 2)
                {
                    Console.Write(",");
                  
                }
            }

        }
    }
}