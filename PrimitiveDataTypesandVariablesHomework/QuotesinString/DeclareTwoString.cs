using System;

class DeclareTwoString
{
    static void Main(string[] args)
    {
        string FirstString = "The \"use\" of quoatations causes difficulties";
        string SecondString = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("First variant: " + FirstString);
        Console.WriteLine("Second variant: " + SecondString);
    }
}
