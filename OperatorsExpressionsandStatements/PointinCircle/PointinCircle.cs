using System;
//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
    class PointinCircle
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of x cordinate");
            string xnumber = Console.ReadLine();
            double pointX = double.Parse(xnumber);

            Console.WriteLine("Enter the value of y cordinate");
            string ynumber = Console.ReadLine();
            double pointY = double.Parse(ynumber);
           
            byte radius = 2;
            //Pythagorean Theorem a^2 + b^2 = c^2 ==> (x*x) + (y*y) <= radius * radius.
            //Operator * is faster than Math.Pow()
            bool isInCircle = pointX * pointX + pointY * pointY <= radius * radius;
            Console.WriteLine("Is the point in the circle?\n{0}", isInCircle);
        }
    }

