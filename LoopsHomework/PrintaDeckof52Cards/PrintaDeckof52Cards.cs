using Microsoft.Win32;
using System;
using System.Globalization;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

class PrintADeckOf52Cards
{
    static void Main()
    {

        char spades = '\u2663';
        char diamonds = '\u2666';
        char hearts = '\u2665';
        char clubs = '\u2660';

        for (int i = 2; i <= 14; i++)
        {
            switch (i)
            {
                case 11:
                    Console.WriteLine("J" + spades + " " + "J" + diamonds + " " + "J" + hearts + " " + "J" + clubs + " ");
                    break;
                case 12:
                    Console.WriteLine("Q" + spades + " " + "Q" + diamonds + " " + "Q" + hearts + " " + "Q" + clubs + " ");
                    break;
                case 13:
                    Console.WriteLine("K" + spades + " " + "K" + diamonds + " " + "K" + hearts + " " + "K" + clubs + " ");
                    break;
                case 14:
                    Console.WriteLine("A" + spades + " " + "A" + diamonds + " " + "A" + hearts + " " + "A" + clubs + " ");
                    break;
                default:
                    Console.WriteLine(i + " " + spades + " " + i + diamonds + " " + i + hearts + " " + i + clubs + " ");
                    break;
            }
        }
    }
}