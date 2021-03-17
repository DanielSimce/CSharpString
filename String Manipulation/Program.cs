using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            string myString = "Daniel Simonovski";
            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.ToUpper());
    
            Console.WriteLine(myString.PadLeft(100));
            Console.WriteLine(myString.PadRight(100));

            char myChar = myString[1];
            Console.WriteLine(myChar);
            char[] myChars = myString.ToCharArray();
            foreach (char character in myString)
            {
                Console.Write($"{ character} ");
            }
            Console.WriteLine($"\nYou typed {myString.Length} characters. ");


            Console.WriteLine(myChars);
            Console.WriteLine(myChar);
            Console.ReadLine();
        }
    }
}
