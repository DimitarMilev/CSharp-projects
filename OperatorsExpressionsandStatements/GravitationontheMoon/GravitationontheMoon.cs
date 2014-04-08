using System;

//The gravitational field of the Moon is approximately 17% of that on the Earth. 
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth

class GravitationontheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your weight:");
        string weight = Console.ReadLine();
        float ToInt = float.Parse(weight);
        float moonweight = ToInt * (17.0f / 100f);
        Console.WriteLine("Your weight on the moon will be:{0}", moonweight);
    }
}

