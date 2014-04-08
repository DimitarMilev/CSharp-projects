using System;
//Write an expression that calculates trapezoid's area by given sides a and b and height h.
    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("You want to know what is the area of the Trapezoid ?\n");
            Console.WriteLine("Enter side a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter side b");
            double b = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the hight");
            double h = double.Parse(Console.ReadLine());

            double Area = ((a+b)/2) *h;
            Console.WriteLine("The area is:{0}", Area);
        }
    }

