﻿using System;

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

class ExchangeKbitsFromPtoQ
{
    static void Main()
    {
        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine(
  Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.Write("Please enter start position P: ");
        byte p = byte.Parse(Console.ReadLine());
        Console.Write("Please enter start position Q: ");
        byte q = byte.Parse(Console.ReadLine());
        Console.Write("Please enter length K: ");
        byte k = byte.Parse(Console.ReadLine());
        //WARNING: unchecked code, bad things can happen
        for (byte i = 0; i < k; i++)
        {
            bool bitA = findBitInt(number, (byte)(p + i));
            bool bitB = findBitInt(number, (byte)(q + i));
            insertBit(ref number, (byte)(p + i), bitB);
            insertBit(ref number, (byte)(q + i), bitA);
        }
        Console.WriteLine(
  Convert.ToString(number, 2).PadLeft(32, '0'));
    }
    static bool findBitInt(uint number, byte bitNumber)
    {

        uint mask = (uint)(1 << bitNumber);        // 00000000 00100000
        uint nAndMask = (number & mask);  // 00000000 00100000
        uint bit = nAndMask >> bitNumber;  // 00000000 00000001
        return bit == 1;
        //Console.WriteLine(bit);
    }
    static void insertBit(ref uint number, byte bitPosition, bool bitValue)
    {
        //to 0
        if (!bitValue)
        {
            uint mask = (uint)(~(1 << bitPosition));
            number = (number & mask);
        }

        //to 1

        else
        {
            uint mask = (uint)(1 << bitPosition);
            number = (number | mask);
        }

    }
}
