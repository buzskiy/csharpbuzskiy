using System;
using System.Collections.Generic;

namespace _14._2
{
    class Program
    {
        static void Main()
        {
            string playagain = "";
            Lottery lotozabava = new Lottery();
            while (playagain != "no")
                {
                    Console.WriteLine("Hi. This is a lottery.");
                    LotteryTicket lotterydeal = new LotteryTicket();
                    Startgame:
                    Console.WriteLine($"\nYou are required to enter {lotozabava.ticketsize} numbers in a range from {lotozabava.minrange} to {lotozabava.maxrange}.");
                    Console.WriteLine($"The system will than generate it's own {lotozabava.ticketsize} numbers and match them with yours. Let's see who wins :)");
                    Console.WriteLine("\nCAUTION: Please enter single number in a row. \n");
                    UserTicket happyticket = lotozabava.FillTicket();
                    lotozabava.LotteryResult(happyticket, lotterydeal);

                    lotozabava.SaveLotteryDealHistory(happyticket, lotterydeal, lotozabava); 
                
                    ContinuePlaying:
                        Console.WriteLine("\nDo you want to play again? Type 'yes' or 'no'. If you want to see play history, type 'h'");
                        playagain = Console.ReadLine();
                        switch (playagain)
                        {
                            case "yes":
                                goto Startgame;
                            case "no":
                                continue;
                            case "h":
                                for (int i = 0; i < lotozabava.results.Count; i++)
                                {

                                    Console.WriteLine(lotozabava.results[i]);
                                }
                                goto ContinuePlaying;

                            default:
                                goto ContinuePlaying;
                        }
                }
                Console.WriteLine("\nThanks for playing! Bye!");
        }
    }

    public class Lottery
    {
        protected int[] tickets;
        public readonly List <string> results;
        public readonly int maxrange;
        public readonly int minrange;
        public readonly int ticketsize;
        protected bool lotteryresult;
        ArgumentOutOfRangeException outOfRangeException = new ArgumentOutOfRangeException();

        public Lottery()
        {
            maxrange = 9;
            minrange = 1;
            ticketsize = 6;
            tickets = new int[ticketsize];
            results = new List<string>();

        }

        public int this[int index]
        {
            get
            {
                return tickets[index];
            }
            set
            {
                if (value <= maxrange && value >= minrange)
                {
                    tickets[index] = value;
                }

                else
                {
                    throw outOfRangeException;
                }
            }
        }

        public UserTicket FillTicket()
        {
            UserTicket ticket = new UserTicket();
            for (int i = 0; i <= ticketsize - 1; i++)
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



        public bool LotteryResult(UserTicket userticket, LotteryTicket lotteryticket)
        {
            lotteryresult = true;
            for (int i = 0; i <= ticketsize - 1; i++)
            {
                lotteryresult = Array.Exists(lotteryticket.tickets, element => element == userticket[i]);
                if (lotteryresult == false)
                {
                    Console.WriteLine("You lost, please try again :(");
                    break;
                }
            }

            if (lotteryresult == true)
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
            return lotteryresult;
        }

        public void SaveLotteryDealHistory(UserTicket userticket, LotteryTicket lotteryticket, Lottery lottery)
        {
            string userhistory = string.Join(" ", userticket.tickets); 
            string lotteryhistory = string.Join(" ", lotteryticket.tickets);
            string totalhistory = "Play History. User Ticket: " + userhistory + " Lottery Deal " + lotteryhistory + " Lottery won: " + lottery.lotteryresult;
            results.Add(totalhistory);
        }


}

public class UserTicket : Lottery
    {
    }

    public class LotteryTicket : Lottery
    {
       public LotteryTicket()
        {
            Random randNum = new Random();
            for (int i = 0; i <= ticketsize - 1; i++)
            {
                tickets[i] = randNum.Next(1, 1);
            }
        }  
    }
}
