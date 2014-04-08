using System;
using System.Text;

    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            UnicodeEncoding unicode = new UnicodeEncoding();
            String encodingName = unicode.EncodingName;
            Console.WriteLine("Encoding name: " + encodingName);
        }
    }
