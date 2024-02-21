using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Main_Game_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            bool debug = false;
            Random rnd = new Random();
            int number;
            string startMsg = "";
            int ii = 0;

            //keep running while "isRunning == true"
            while (isRunning)
            {
                number = rnd.Next(1, 10);
                if ( ii < 1)
                {
                    ii++;
                    Console.WriteLine("Would you like to ender debug mode?");
                    Console.WriteLine();
                    string userChoiceDebug = Console.ReadLine();
                    if (userChoiceDebug == "y" || userChoiceDebug == "Y")
                    {
                        debug = true;
                    }
                    else
                        debug = false;
                }

                // promt the user to start guess ournumber
                if (debug == true)
                {
                    startMsg = "debuggin on || ";
                }
                else
                {
                    startMsg = "";
                }
                Console.WriteLine(startMsg + "guess my number within 5 turns!");

                for (int i = 0; i < 5; i++)
                {
                    int guess = int.Parse(Console.ReadLine());

                    if (guess == number)
                    {
                        Console.WriteLine("congrats! you guessed correct");
                        break;
                    }
                    else if (guess > number) // player guessed too high 
                    {
                        Console.WriteLine("lower...");
                        if (debug == true)
                        {
                            Console.Write("number is " + number + " btw.");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("higher");
                        if (debug == true)
                        {
                            Console.Write("number is " + number + " btw.");
                            Console.WriteLine();
                        }
                    }
                }

                //ask the player if the want to play again
                Console.WriteLine("would you like to play again? (y/n) ?");
                string userChoice = Console.ReadLine();
                if (userChoice == "y" || userChoice == "Y")
                {
                    isRunning = true;
                }
                else
                    isRunning = false;
            }
            Console.WriteLine("thanks for playing");
            Console.ReadKey();
        }
    }
}
