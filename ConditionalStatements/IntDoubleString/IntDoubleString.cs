using System;

    class IntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Please enter an integer number:");
                    int intNum = int.Parse(Console.ReadLine());
                    int IntPlusOne = intNum + 1;
                    Console.WriteLine(IntPlusOne);
                    break;
                case "2":
                    Console.WriteLine("Please enter double number:");
                    double doubleNum = double.Parse(Console.ReadLine());
                    double DoublePlusOne = doubleNum + 1;
                    Console.WriteLine(DoublePlusOne);
                    break;
                case "3":
                    Console.WriteLine("Please enter string:");
                    string text = Console.ReadLine();
                    string newText = text + "*";
                    Console.WriteLine(newText);
                    break;
                             
            }
        }
    }

