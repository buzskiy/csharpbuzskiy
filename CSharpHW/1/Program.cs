/** 7. Create Hello World console application and print your name there. Colour of your text should be yellow.
*/

using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.Yellow;
            var name = "Alex";
            Console.WriteLine($"Hello {name}!");
        }
    }
}
