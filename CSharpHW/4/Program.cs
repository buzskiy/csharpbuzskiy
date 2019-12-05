using System;
using System.Text.RegularExpressions;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateFirstName();
            ValidateLastName();
            ValidateDate();
            ValidateGender();
            ValidateEmail();
            ValidatePhone();
            ValidateAdiitionalInfo();
            Console.WriteLine("Success!");
        }
                
                
        //First name 
        static void ValidateFirstName()
        {
            Console.WriteLine("Enter your First Name:");
            var FirstName = Console.ReadLine();
            Regex firstnameregex = new Regex(@"^[a-zA-Z]{1,255}$");
            var isValid = firstnameregex.IsMatch(FirstName);

            if (!isValid)
                {
                    Console.WriteLine("Wrong First Name Format. Please try again");
                    ValidateFirstName();
                }
            
        }

        //Last name
        static void ValidateLastName()
        {
            Console.WriteLine("Enter your Last Name:");
            var LastName = Console.ReadLine();
            Regex lastnameregex = new Regex(@"^[a-zA-Z]{1,255}$");
            var isValid = lastnameregex.IsMatch(LastName);

            if (!isValid)
                {
                    Console.WriteLine("Wrong Last Name Format. Please try again");
                    ValidateLastName();
                }
            
        }        

        //date of birth 
        static void ValidateDate()
        {
            Console.WriteLine("Enter your birth date in format dd/MM/yyyy:");
            var date = Console.ReadLine();
            Regex dateregex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            var isValid = dateregex.IsMatch(date);

            if (!isValid)
                {
                    Console.WriteLine("Wrong Date Format. Please try again");
                    ValidateDate();
                }
        }

        //gender
        static void ValidateGender()
        {
            Console.WriteLine("Enter your gender:");
            var gender = Console.ReadLine();

            if (gender != "male" && gender != "female")
            {
                    Console.WriteLine("Wrong gender. Please try again");
                    ValidateGender();
            } 
        }

        //Email
        static void ValidateEmail()
        {
            Console.WriteLine("Enter your Email:");
            var Email = Console.ReadLine();
            Regex emailregex = new Regex(@"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$");
            var isValid = emailregex.IsMatch(Email);

            if (!isValid)
                {
                    Console.WriteLine("Wrong Email Format. Please try again");
                    ValidateEmail();
                }
            
        }
        //phone number 
        static void ValidatePhone()
        {
            Console.WriteLine("Enter your Phone Number in format XXXXXXXXXX:");
            var Phone = Console.ReadLine();
            Regex phoneregex = new Regex("^[0-9]{1,12}$");
            var isValid = phoneregex.IsMatch(Phone);

            if (!isValid)
                {
                    Console.WriteLine("Wrong Phone Format. Please try again");
                    ValidatePhone();
                }
            
        }
        //additional info
        static void ValidateAdiitionalInfo()
        {
            Console.WriteLine("Enter additional info:");
            var AdditionalInfo = Console.ReadLine();

            if (AdditionalInfo.Length > 1999)
                {
                    Console.WriteLine("Wrong Additional Info Format. Please try again");
                    ValidateAdiitionalInfo();
                }
            
        }

    }
}
