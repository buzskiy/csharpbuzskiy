//3.1 Метод в качестве аргумента принимает натуральное число и выводит в консоль все делители аргумента.

using System;

namespace quiz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserNumber = 0;
            Console.WriteLine("Please enter number:");
            while (true)
                {
                    try
                        {
                            UserNumber = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    catch (Exception)
                        {
                            Console.WriteLine("Wrong Input Format");
                            continue;
                        }
                }
                    for(int i=1; i<=UserNumber; i++)
                        {
                            if (UserNumber%i==0)
                                {
                                    Console.Write(i + " ");
                                }
                        }
                    Console.WriteLine("\n");
        }
    }
}
