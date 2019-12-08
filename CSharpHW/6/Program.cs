/**Create a WPF application. Application should pick a number.
The number is generated randomly from 1 to 10.
User enters a number and if he guesses the number, then program returns success.
Otherwise the program prints the number that was picked and then generates a new number.
Please use exception handling for cases when user enters not valid data.*/

using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int RandomNumber = 0;
            int UserNumber = 0;

            do 
            {
                RandomNumber = rnd.Next(1,11);
                Console.WriteLine("Please enter number from 1 to 10:");
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
                if (UserNumber==RandomNumber)
                    {
                        Console.WriteLine($"Success! Computer guessed {RandomNumber}. Your guess was {UserNumber}.");
                        break;
                    }
                Console.WriteLine($"Your Guess is Wrong. Computer guessed {RandomNumber}. Your guess was {UserNumber}");
            }
            while (UserNumber!=RandomNumber) ;
        }
    }
}
