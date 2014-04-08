using System;

    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integer number");
            uint num = uint.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
                
            }
        }
    }
