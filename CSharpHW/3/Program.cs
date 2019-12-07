/**
1. Create console application which gets user's birth date and returns his Age and Zodiac sign. 
Please use recursion for birth date validation.
Application should accept date only in the following format: DD/MM/YYYY. 
In case if the format is incorrect the application should ask user to provide birth date again.
*/

using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace _3
{
    class Program
    {

        
        static void Main(string[] args)
        {
            
            var date = ValidateDate();
            Console.WriteLine($"Your age is {Age(date)}");
            Console.WriteLine($"Your Zodiac sign is {Findzodiac(date)}");

        }

        
        //recursive method to validate data in dd/MM/yyyy format 
        static DateTime ValidateDate()
        {
            Console.WriteLine("Enter your birth date:");
            DateTime date = DateTime.MinValue;
            bool datevalue = false;
            do
                {   
                    var input = Console.ReadLine();
                    datevalue = DateTime.TryParseExact(input, "dd/MM/yyyy", null, DateTimeStyles.None, out date);
                    Console.WriteLine("Wrong date format. Please try again.");

                }
            while(!datevalue);
                return date;
        }

        //method to calculate age = current date - birth date
        static int Age(DateTime date)
        {
            var age = DateTime.Now.Year - date.Year;
           
            return age;

        }
        //method to calculate zodiac sign with switch
        static string Findzodiac(DateTime date)
            {
            var month = date.Month;
            var day = date.Day;
                switch (month)
                {
                    case 1: if(day <= 20)
                        {return "Capricorn"; }
                        else
                        {return "Aquarius"; }
                    case 2: if (day <= 19)
                        {return "Aquarius"; }
                        else
                        {return "Pisces"; }
                    case 3: if (day <= 20)
                        {return "Pisces"; }
                        else
                        {return "Aries"; }
                    case 4: if (day <= 20)
                        {return "Aries"; }
                        else
                        {return "Taurus"; }
                    case 5: if (day <= 21)
                        {return "Taurus"; }
                        else
                        {return "Gemini"; }
                    case 6: if (day <= 22)
                        {return "Gemini"; }
                        else
                        {return "Cancer"; }
                    case 7: if (day <= 22)
                        {return "Cancer"; }
                        else
                        {return "Leo"; }
                    case 8: if (day <= 23)
                        {return "Leo"; }
                        else
                        {return "Virgo"; }
                    case 9: if (day <= 23)
                        {return "Virgo"; }
                        else
                        {return "Libra"; }
                    case 10: if (day <= 23)
                        {return "Libra"; }
                        else
                        {return "Scorpio"; }
                    case 11: if (day <= 22)
                        {return "Scorpio"; }
                        else
                        {return "Sagittarius"; }
                    case 12: if (day <= 21)
                        {return "Sagittarius"; }
                        else
                        {return "Capricorn"; }
                    default:
                        return "Something went wrong with calculation. Please try again.";
                }
            
             
        }

    }
}
