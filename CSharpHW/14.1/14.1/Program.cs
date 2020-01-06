//Создайте консольное приложение.Программу лотерея.Программа предоставляет пользователю ввести 6 чисел от 1 до 9.
// Далее с помощью индексатора и генератора случайных чисел программа проверяет соотвествует ли данная комбинация чисел
// сгенерированной случайности.Продемонстрируйте работу программы.Сделайте использование программы интуитивно понятной.
// Добавьте валидацию.

using System;

namespace _14
{
    class Program
    {
        static void Main()
        {
            int x = 6;
            string playagain="";

            Console.WriteLine("Hi. This is a lottery.");

            while (playagain!="no")
            {

                Console.WriteLine("\nYou are required to enter 6 numbers in a range from 1 to 9."); 
                Console.WriteLine("The system will than generate it's own 6 numbers and match them with yours. Let's see who wins :)");
                Console.WriteLine("\nCAUTION: Please enter single number in a row. \n");
                LotteryTicket userticket = LotteryTicket.FillTicketByUser(x);
                int[] lotteryticket = LotteryTicket.FillTicketForLottery(x);
                LotteryTicket.PlayLottery(userticket, lotteryticket);

                ContinuePlaying:
                Console.WriteLine("\nDo you want to play again? Type 'yes' or 'no'");
                playagain = Console.ReadLine();
                if (playagain != "yes" && playagain != "no")
                {
                    goto ContinuePlaying;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("\nThanks for playing! Bye!");

        }
    }
}

public class LotteryTicket
{
    private readonly int[] userlotterytickets;
    private readonly ArgumentOutOfRangeException outOfRangeException = new ArgumentOutOfRangeException();

    public LotteryTicket(int x)
    {
        userlotterytickets = new int[x];
    }

    public static LotteryTicket FillTicketByUser(int x)
    {
        LotteryTicket ticket = new LotteryTicket(x);
        for (int i = 0; i <= x - 1; i++)
        {
        step1:
            try
            {
                Console.WriteLine("Enter number to fill ticket:");
                int number = Convert.ToInt32(Console.ReadLine());
                ticket[i] = number;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Wrong input format. Please Enter Numbers from 1 to 9");
                goto step1;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input format. Please Enter Numbers only");
                goto step1;
            }
        }
        return ticket;
    }

    public static int[] FillTicketForLottery(int x)
    {
        int[] lotteryresult = new int[x];
        Random randNum = new Random();
        for (int i = 0; i <= x - 1; i++)
        {
            lotteryresult[i] = randNum.Next(1, 1);
        }
        return lotteryresult;
    }

    public int this[int index]
        {
            get
            {
                return userlotterytickets[index];
            }
            set
            {
                if (value <= 9 && value >= 1)
                {
                    userlotterytickets[index] = value;
                }

                else
                {
                    throw outOfRangeException;
                }
            }
        }

    public static void PlayLottery(LotteryTicket userticket, int[] lotteryticket)
    {
        bool equal = true;
        for (int i = 0; i <= lotteryticket.Length - 1; i++)
        {
            equal = Array.Exists(lotteryticket, element => element == userticket[i]);
            if (equal == false)
            {
                Console.WriteLine("You lost, please try again :(");
                break;
            }
        }

        if (equal == true)
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
    }
}