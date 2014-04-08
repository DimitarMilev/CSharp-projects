using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReturnNumberName
{
    class NumberAsWord
    {
        static void Main(string[] args)
        {
            int number;
            string[,] numbers ={
                                     {"one","two","three","four","five","six","seven","eight","nine"},
                                     {"eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"},
                                     {"ten","twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninety"},
                              };
            do
            {
                Console.WriteLine("Enter the number:");
                number = int.Parse(Console.ReadLine());
            }
            while ((number / 1000) > 0);//Провери дали числото е между 0 i 999

            if (number / 100 > 0)//има ли стотици
            {
                Console.Write("{0} hundred ", numbers[0, (number / 100) - 1]);
                if ((number % 100) / 10 > 0)//има ли десетици
                {
                    Console.Write("and ");
                    if ((number % 100) / 10 == 1 && (number % 100) % 10 > 0)//десетиците между 10 и 20 ли са
                    {
                        Console.WriteLine(numbers[1, ((number % 100) % 10) - 1]);
                    }
                    else
                    {
                        Console.Write(numbers[2, ((number % 100) / 10) - 1]);
                        if ((number % 100) % 10 > 0)//има ли единици
                        {
                            Console.WriteLine(" {0}", numbers[0, ((number % 100) % 10) - 1]);
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                }
                else if (((number % 100) % 10) > 0)//има ли единици
                {
                    Console.Write("and ");
                    Console.WriteLine(numbers[0, ((number % 100) % 10) - 1]);
                }
                else
                {
                    Console.WriteLine();
                }
            }
            else if (number / 10 > 0 && number / 10 < 10)//има ли само десетици и единици
            {
                if (number / 10 == 1 && number % 10 > 0)//десетиците между 10 и 20 ли са
                {
                    Console.WriteLine(numbers[1, ((number % 100) % 10) - 1]);
                }
                else
                {
                    Console.Write(numbers[2, (number / 10) - 1]);
                    if (number % 10 > 0)
                    {
                        Console.WriteLine(" {0}", numbers[0, ((number % 100) % 10) - 1]);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
            else if (number == 0)//числото 0 ли е
            {
                Console.WriteLine("zero");
            }
            else//има само единици
            {
                Console.WriteLine(numbers[0, number - 1]);
            }
        }
    }
}