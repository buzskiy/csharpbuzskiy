//Условие задачи:
//Создайте консольное приложение.Программу лотерея.Программа предоставляет пользователю ввести 6 чисел от 1 до 9.
// Далее с помощью индексатора и генератора случайных чисел программа проверяет соотвествует ли данная комбинация чисел
// сгенерированной случайности.Продемонстрируйте работу программы.Сделайте использование программы интуитивно понятной.
// Добавьте валидацию.

using System;

namespace _14._3
{
    class Program
    {
        static void Main()
        {
            //play lottery
            string playagain = "";
            while (playagain != "no")
            {
                Console.WriteLine("This is a lottery.");
                Console.WriteLine($"\nYou are required to enter 6 numbers in a range from 1 to 9.");
                Console.WriteLine($"The system will than generate it's own numbers and match them with yours. Let's see who wins.");
                Console.WriteLine("\nCAUTION: Please enter single number in a row. \n");
                
                //generate user and lottery ticket
                Ticket lotteryticket = Ticket.CreateLotteryTicket();
                Ticket userticket = Ticket.CreateUserTicket();
                
                //compare tickets
                Lottery.PlayLottery(userticket, lotteryticket);

                Console.WriteLine("\nDo you want to play again? Type 'yes' or 'no'");
                playagain = Console.ReadLine();
                switch (playagain)
                {
                    case "yes":
                        continue;
                    case "no":
                        break;
                }
            }
            Console.WriteLine("\nThanks for playing! Bye!");
        }
    }

    public static class Lottery
    {
        //method to compare user and lottery tickets and get lottery result
        public static void PlayLottery(Ticket userticket, Ticket lotteryticket)
        {
            bool lotteryresult = true;
            for (int i = 0; i < userticket.ticketsize; i++)
            {
                lotteryresult = Array.Exists(lotteryticket.ticketnumbers, element => element == userticket[i]); 
            }
            PrintLotteryResultForUser(lotteryresult);
        }


        public static void PrintLotteryResultForUser(bool lotteryresult)
        {
            Console.WriteLine();
            if (lotteryresult == true)
                WonMessage();
            else
                LostMessage();
        }

        public static void WonMessage()
        {
            Console.WriteLine("\n \n \n \n                              Congrats! You want $1 000 000 000! \n \n \n");
            Console.WriteLine(
             @"                                                        .''.                         " + "\n" +
             @"                              .''.             *''*    :_\/_:     .                  " + "\n" +
             @"                             :_\/_:   .    .:.*_\/_*   : /\ :  .'.:.'.               " + "\n" +
             @"                         .''.: /\ : _\(/_  ':'* /\ *  : '..'.  -=:o:=-               " + "\n" +
             @"                        :_\/_:'.:::. /)\*''*  .|.* '.\'/.'_\(/_'.':'.'               " + "\n" +
             @"                        : /\ : :::::  '*_\/_* | |  -= o =- /)\    '  *               " + "\n" +
             @"                         '..'  ':::'   * /\ * |'|  .'/.\'.  '._____                  " + "\n" +
             @"                             *        __*..* |  |     :      |.   |' .---'|          " + "\n" +
             @"                              _*   .-'   '-. |  |     .--'|  ||   | _|    |          " + "\n" +
             @"                           .-'|  _.|  |    ||   '-__  |   |  |    ||      |          " + "\n" +
             @"                           |' | |.    |    ||       | |   |  |    ||      |          " + "\n" +
             @"                        ___|    '-'     '    ""       '-'   '-.'    '`     |____     " + "\n \n \n");
        }

        public static void LostMessage()
        {
            Console.WriteLine("You have lost. Please try again.");
        }
    }

    public class Ticket
    {
        public int ticketsize = 6;
        public int maxnumber = 9;
        public int minnumber = 1;
        public int[] ticketnumbers;

        public Ticket()
        {
            ticketnumbers = new int[ticketsize];
        }

        public int this[int index]
        {
            get
            {
                return ticketnumbers[index];
            }
            set
            {
                if (value <= maxnumber && value >= minnumber)
                {
                    ticketnumbers[index] = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        //method to get input from user and generate user ticket
        public static Ticket CreateUserTicket()
        {
            Ticket userticket = new Ticket();
            for (int i = 0; i < userticket.ticketsize; i++)
            {
                
                    try
                    {
                        Console.WriteLine("Enter number to fill ticket:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        userticket[i] = number;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Wrong input format. Please Enter Numbers from 1 to 9");
                    i--;    
                    continue;
                        
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong input format. Please Enter Numbers only");
                    i--;
                    continue;
                }
                }
            return userticket;
        }

        //method to randomly generate lottery ticket
        public static Ticket CreateLotteryTicket()
        {
            Ticket lotteryticket = new Ticket();
            Random randNum = new Random();
            for (int i = 0; i < lotteryticket.ticketsize; i++)
            {
                lotteryticket[i] = randNum.Next(lotteryticket.minnumber, lotteryticket.maxnumber);
            }
            return lotteryticket;
        }
    }
}
