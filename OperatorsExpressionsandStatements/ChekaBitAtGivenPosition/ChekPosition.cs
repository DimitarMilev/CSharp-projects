using System;
//Write a Boolean expression that returns if the bit at position p
//(counting from 0, starting from the right) in given integer number n has value of 1.
    class ChekPosition
    {
        static void Main()
        {
        Console.WriteLine("Enter integer number n");
        int numberN = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter index p");
        int indexP = int.Parse(Console.ReadLine());
        
        Convert.ToString(numberN, 2).PadLeft(16, '0');
        int moveNumberN = numberN >> indexP;
        int bit = moveNumberN & 1;
        bool one = true;
        if (bit == 1)
        {
            Console.WriteLine(one);
        }
        else
        {
            bool zero = false;
            Console.WriteLine(zero);
        }
        }
    }

