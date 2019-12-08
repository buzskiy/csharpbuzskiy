//3.2 Метод в качестве двух аргументов принимает натуральные числа и возвращает наибольший общий делитель.

using System;
using System.Collections.Generic;
namespace quiz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //вынес валидацию в отдельный класс и отдельный файл 
            int UserNumber1 = InputValidation.IsANumber("Enter 1st number");
            int UserNumber2 = InputValidation.IsANumber("Enter 2nd number");
            int MaxNumber = Math.Max(UserNumber1,UserNumber2);
            List<int> CommonDividers = new List<int>();

            for(int i=2; i<MaxNumber; i++)
                        {
                            if (UserNumber1%i==0&&UserNumber2%i==0)
                                {
                                    CommonDividers.Add(i);
                                }
                        }
            CommonDividers.Sort();
            if (CommonDividers.Count==0)
                {
                    Console.WriteLine("No common dividers, sorry");
                }
            else 
                {
                    int BiggestCommonDivider = CommonDividers[CommonDividers.Count - 1];
                    Console.WriteLine($"The biggest common divider is {BiggestCommonDivider}");
                }
        }
    }
}
