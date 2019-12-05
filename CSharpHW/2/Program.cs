/**
2. Create calculator console application. Calculator should support basic operations with double type.
   The result should be displayed with two digits after the decimal point. */

using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose desired operation. 1 - Addition, 2 - Substraction, 3 - Multiplication, 4 - Division");
            int input3 = Convert.ToInt32(Console.ReadLine());
            double result = 0.0;
            switch (input3)
            {
                case 1:
                result = input1 + input2;
                break;

                case 2:
                result = input1 - input2;
                break;

                case 3:
                result = input1 * input2;
                break;

                case 4:
                result = input1 / input2;
                break;
            }

            Console.WriteLine($"Result of your calculation is {Math.Round(result,2)}");
        }
    }
}
