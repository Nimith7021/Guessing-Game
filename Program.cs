using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool wannaPlayAgain = true;
            while (wannaPlayAgain)
            {
                Random rnd = new Random();
                int numberToBeGuessed = rnd.Next(1, 101);
                int noOfGuesses = 1;
                while (noOfGuesses <= 3)
                {
                    Console.WriteLine("Enter a number from 1 to 100");
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    if (inputNumber > numberToBeGuessed)

                        Console.WriteLine("Sorry,Too high");
                    else if (inputNumber < numberToBeGuessed)

                        Console.WriteLine("Sorry,Too Low");
                    else
                    {
                        Console.WriteLine($"Bingo!!You found the answer in {noOfGuesses} attempts");
                        break;
                    }

                    noOfGuesses++;
                }
                if (noOfGuesses > 3)
                    Console.WriteLine("Sorry You Lose , attempts exhausted");

                Console.WriteLine("Wanna Play again? If Yes Type : 1 if No Type 0");
                int wannaPlay = Convert.ToInt32(Console.ReadLine());
                if(wannaPlay==0)
                    wannaPlayAgain=false;
            }

            Console.WriteLine("Thank You For Playing");

        }
    }
}