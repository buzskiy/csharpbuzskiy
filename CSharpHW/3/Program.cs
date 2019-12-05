using System;
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
        static string ValidateDate()
        {
            Console.WriteLine("Enter your birth date:");
            var date = Console.ReadLine();
            Regex dateregex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            var isValid = dateregex.IsMatch(date);

            if (!isValid)
                {
                    Console.WriteLine("Wrong Date Format. Please try again:");
                    return ValidateDate();
                }
            return date;
        }

        //method to calculate age = current date - birth date
        static int Age(string date)
        {
            var age = DateTime.Now.Year - DateTime.ParseExact(date, "dd/MM/yyyy", null).Year;
           
            return age;

        }
        //method to calculate zodiac sign with switch
        static string Findzodiac(string date)
            {
            var month = DateTime.ParseExact(date, "dd/MM/yyyy", null).Month;
            var day = DateTime.ParseExact(date, "dd/MM/yyyy", null).Day;
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
                        return "";
                }
            
             
        }

    }
}
