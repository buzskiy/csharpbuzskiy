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
            double number1 = 0.00;
            double number2 = 0.00;
            bool inputnumber = false;
                do {
                    Console.WriteLine("Enter 1st number");
                    inputnumber = Double.TryParse(Console.ReadLine(), out number1);
                    }
                while (!inputnumber);
                
                do {
                    Console.WriteLine("Enter 2nd number");
                    inputnumber = Double.TryParse(Console.ReadLine(), out number2);
                    }
                while (!inputnumber);
                
            Console.WriteLine("Choose desired operation. 1 - Addition, 2 - Substraction, 3 - Multiplication, 4 - Division");
            int input3 = Convert.ToInt32(Console.ReadLine());
            double result = 0.0;
            switch (input3)
            {
                case 1:
                result = number1 + number2;
                break;

                case 2:
                result = number1 - number2;
                break;

                case 3:
                result = number1 * number2;
                break;

                case 4:
                result = number1 / number2;
                break;
            }

            Console.WriteLine($"Result of your calculation is {Math.Round(result,2)}"); 
        }
    }
    
}
