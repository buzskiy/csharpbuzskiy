using System;

namespace quiz_2
{
    public class InputValidation 
    {    
        
                    
        public static int IsANumber(string a)
        {
            Console.WriteLine(a);
            int number = 0;
            while (true)
            {
                try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                catch (Exception)
                    {
                        Console.WriteLine("Wrong Input Format");
                        continue;
                    }
            }
            return number;
        }
    }

}