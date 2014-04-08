using System;
class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int temp;

        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("Ater exchange a={0} and b={1}", a, b);
    }
}
