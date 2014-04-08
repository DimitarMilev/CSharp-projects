using System;
using System.Text;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it
//(prints its real roots). 


    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter the coefficient a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coefficient b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coefficient c: ");
            float c = float.Parse(Console.ReadLine());
            float D = (b * b) - 4 * a * c;
            Console.WriteLine("The Discriminant is {0}", D);
            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("The number of real roots is infinity!");
            }
            else if (a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine("There are no real roots");
            }
            else if (a == 0 && b != 0)
            {
                float x1 = -(c / b);
                Console.WriteLine("The equation have one real root: {0}", x1);
            }
            else if (D >= 0)
            {
                double x1 = (float)(-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (float)(-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("The real roots of the equation are: {0} and {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("The equation do not have real roots!");
            }
        }
    }
