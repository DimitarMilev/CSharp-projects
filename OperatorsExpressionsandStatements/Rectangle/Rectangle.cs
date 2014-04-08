using System;

//Write an expression that calculates rectangle’s perimeter and area by given width and height

class Rectanle
{
    static void Main()
    {
        Console.WriteLine("Enter the width:");
        string width = Console.ReadLine();
        double a = Convert.ToDouble(width);

        Console.WriteLine("Enter the height:");
        string height = Console.ReadLine();
        double b = Convert.ToDouble(height);

        double Perimeter = (2 * a) + (2 * b);
        Console.WriteLine("The perimeter is : {0} ", Perimeter);

        double Area = (a * b);
        Console.WriteLine("The area is : {0} ", Area);

    }
}

