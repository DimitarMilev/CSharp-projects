using System;

    class Ageafter10Years
    {
        static void Main()
        {
            Console.Write("Enter your age here:");
            byte age = byte.Parse(Console.ReadLine());
            age += 10;
            Console.Write("Your age after 10 years will be:");
            Console.WriteLine(age);
        }
    }

