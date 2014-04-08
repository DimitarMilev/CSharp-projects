using System;
using System.Linq;

    class NNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            
            for (int i = 0; i < n; i++)
			{
                numbers[i] = int.Parse(Console.ReadLine());
			}
            Console.WriteLine("The maximal number is {0}",numbers.Max());
            Console.WriteLine("The minimal number is {0}", numbers.Min());
            Console.WriteLine("The average is {0}",numbers.Average());
            Console.WriteLine("The sum is {0}",numbers.Sum());
                
        }
    }

