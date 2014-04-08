using System;

    class Biggest
    {
        static void Main()
        {
        Console.Write("First Number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Second Number:");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Third Number:");
        double thirdNum = double.Parse(Console.ReadLine());
            Console.Write("Fourth Number:");
        double fourthNum = double.Parse(Console.ReadLine());
            Console.Write("Fifth Number:");
        double fifthNum = double.Parse(Console.ReadLine());

        if (firstNum > secondNum && firstNum > thirdNum && firstNum > fourthNum && firstNum > fifthNum)
        {
            Console.WriteLine(firstNum);
        }
        else if (secondNum > firstNum && secondNum > thirdNum && secondNum > fourthNum && secondNum > fifthNum)
        {
            Console.WriteLine(secondNum);
        }
        else if (thirdNum > firstNum && thirdNum > secondNum && thirdNum > fourthNum && thirdNum > fifthNum)
        {
            Console.WriteLine(thirdNum);
        }
        else if (fourthNum > firstNum && fourthNum > secondNum && fourthNum > thirdNum && thirdNum > fifthNum)
        {
            Console.WriteLine(thirdNum);
        }
        else if (fifthNum > firstNum && fifthNum > secondNum && fifthNum > fourthNum && fifthNum > thirdNum)
        {
            Console.WriteLine(thirdNum);
        }
        else
        {
            Console.WriteLine("The numbers are equal");
        }

        }
    }

