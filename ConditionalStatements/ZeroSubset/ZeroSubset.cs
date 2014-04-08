using System;
using System.Collections.Generic;
using System.Text;
class ZeroSubset
{
    public static int sumToFind = 0;
    public static Stack<int> stack = new Stack<int>();
    public static int tempSum = 0;
    public static int[] inputNumbers = { 1, 3, -4, -2, -1 };
    public static void RecursiveCalc(int[] data, int startIndex, int endIndex)
    {
        for (int currentIndex = startIndex; currentIndex < endIndex; currentIndex++)
        {
            stack.Push(data[currentIndex]);
            tempSum += data[currentIndex];
            RecursiveCalc(data, currentIndex + 1, endIndex);
            tempSum -= (int)stack.Pop();
        }
        if (tempSum == sumToFind)
        {
            printSet(stack);
        }
    }//end of RecursiveCalc()
    public static void printSet(Stack<int> stack)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(sumToFind).Append(" = ");
        foreach (int value in stack)
        {
            sb.Append(value).Append("+");
        }
        sb.Length--;
        if (sb.Length < 4) return;
        Console.WriteLine(sb.ToString());
    }// end of printSet()
    static void Main()
    {
        RecursiveCalc(inputNumbers, 0, inputNumbers.Length);
    }//end of Main()
}// end of class

