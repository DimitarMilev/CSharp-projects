using System;
//Write a program that reads the radius r of a circle and prints its perimeter and area
//formatted with 2 digits after the decimal point.
class PerimeterandArea
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of the circle:");
        float radius = float.Parse(Console.ReadLine());
        float PI = 3.14f;
        float Area = PI * (radius * radius);
        float Perimeter = (2 * PI) * radius;
        Console.WriteLine("The area of the circle is {0:f2}", Area);
        Console.WriteLine("The perimeter of the circle is {0:f2}", Perimeter);

    }
}

