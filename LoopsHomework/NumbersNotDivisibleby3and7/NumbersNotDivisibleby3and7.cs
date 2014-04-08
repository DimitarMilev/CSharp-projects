using System;

class NumbersNotDivisibleby3and7
    {
        static void Main()
        {
            Console.WriteLine("Enter positive integer number");
            uint num = uint.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.Write(i +  " ");
            }
            Console.ReadLine();
      
        }
    }

