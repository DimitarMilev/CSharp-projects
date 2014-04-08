using System;

class BonusScore
{
    static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 9:");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    num = num * 10;
                    Console.WriteLine(num);
                    break;
                case 2:
                    num = num * 10;
                    Console.WriteLine(num);
                    break;
                case 3:
                    num = num * 10;
                    Console.WriteLine(num);
                    break;
                case 4:
                    num = num * 100;
                    Console.WriteLine(num);
                    break;
                case 5:
                    num = num * 100;
                    Console.WriteLine(num);
                    break;
                case 6:
                    num = num * 100;
                    Console.WriteLine(num);
                    break;
                case 7:
                    num = num * 1000;
                    Console.WriteLine(num);
                    break;
                case 8:
                    num = num * 1000;
                    Console.WriteLine(num);
                    break;
                case 9:
                    num = num * 1000;
                    Console.WriteLine(num);
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
       }
}

