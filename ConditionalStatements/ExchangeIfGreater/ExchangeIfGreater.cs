using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                double firstChange = secondNum;
                double secondChange = firstNum;
                Console.Write(firstChange);
                Console.Write(" ");
                Console.WriteLine(secondChange);
            }
            else
            {
                Console.Write(firstNum);
                Console.Write(" ");
                Console.WriteLine(secondNum);
            }
        }
    }
}
