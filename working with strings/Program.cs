
using System;

namespace workingStrings 
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "simon katampoi academy";
            
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase + "is the best" );
            Console.WriteLine(phrase.Contains("academy"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("academy"));
            Console.WriteLine(phrase.Substring(11, 4));

            Console.ReadLine();
        }
    }
    
}
