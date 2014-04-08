using System;

    class PrintLongSequence
    {
        static void Main()
        {
            int i = 2;
            while (i <= 1000)
            {
                Console.Write(i);
                Console.Write(" ");
                Console.Write(-(i + 1));
                Console.Write(" ");
                i = i + 2;


            }
        }
    }
