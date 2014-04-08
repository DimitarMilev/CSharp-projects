using System;

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).
    
class InOut
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coordinate x:");
        decimal pointX = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinate y:");
        decimal pointY = decimal.Parse(Console.ReadLine());
        decimal radius = 1.5m;
   
        bool isInCircle = (pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1) <= radius * radius;
        
        if (isInCircle && pointY > 1)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

