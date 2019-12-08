

/**Create console application. Using iteration statements please print the following figures to console:
1. Triangle
2. Square
3. Romb	 
Size of each figure should be specified by user.*/

using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int i,j;
            var r = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nTriangle");
            for (i=1; i<=r; i++)
            {
                for (j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\nSquare");
            for (i=1; i<=r; i++)
            {
                for (j=1; j<=r; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            } 

            Console.WriteLine("\nDiamond");
            for (i = 1; i <= r; i++)
                    {
                        for (j = 1; j <= r - i; j++)
                            Console.Write(" ");
                        for (j = 1; j <= 2 * i - 1; j++)
                            Console.Write("*");
                        Console.Write("\n");
                    }
            for (i = r-1; i >= 1; i--)
                        {
                            for (j = 1; j <= r- i; j++)
                                Console.Write(" ");
                            for (j = 1; j <= 2 * i - 1; j++)
                                Console.Write("*");
                            Console.Write("\n");
                        }
        }
    }
}
