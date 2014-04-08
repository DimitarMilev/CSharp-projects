using System;
class TheBiggest
{
    static void Main(string[] args)
    {
        Console.Write("First Number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Second Number:");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Third Number:");
        double thirdNum = double.Parse(Console.ReadLine());

        if (firstNum > secondNum && firstNum > thirdNum)
        {
            Console.WriteLine(firstNum);
        }
        else if (secondNum > firstNum && secondNum > thirdNum)
        {
            Console.WriteLine(secondNum);
        }
        else if (thirdNum > firstNum && thirdNum > secondNum)
        {
            Console.WriteLine(thirdNum);
        }
        else
        {
            Console.WriteLine("The numbers are equal");
        }

    }
}

