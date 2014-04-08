using System;

    class NullValue
    {
        static void Main(string[] args)
        {
            int? integerNumber = null;
            double? doubleNumber = null;
            Console.WriteLine("The variables assigned with null values:");
            Console.WriteLine(integerNumber);
            Console.WriteLine(doubleNumber);

           integerNumber = 256;
           doubleNumber = 12.345d;
           Console.WriteLine("The variables assigned with number values:");
           Console.WriteLine(integerNumber);
           Console.WriteLine(doubleNumber);


        }
    }

