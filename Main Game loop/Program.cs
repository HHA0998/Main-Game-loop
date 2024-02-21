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
                    number = rnd.Next(1, 100);
                    if (ii < 1)
                    {
                        ii++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nWould you like to enter debug mode?\n");
                        Console.ResetColor();
                        string userChoiceDebug = Console.ReadLine();
                        if (userChoiceDebug == "y" || userChoiceDebug == "Y")
                        {
                            debug = true;
                            Console.Clear();
                        }
                        else
                            debug = false;
                            Console.Clear();
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(startMsg + "guess my number within 10 turns! 1-100 starting now!\n");
                    Console.ResetColor();
                    for (int i = 0; i < 10; i++)

                    {
                        int guess = int.Parse(Console.ReadLine());

                        if (guess == number)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            Console.WriteLine("\ncongrats! you guessed correct\n");
                            Console.ResetColor();
                            break;
                        }
                        else if (guess > number) // player guessed too high 
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("^ lower...\n");
                            Console.ResetColor();
                            if (debug == true)
                            {
                                Console.Write("\nnumber is " + number + " btw.\n");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("^ higher\n");
                            Console.ResetColor();
                            if (debug == true)
                            {
                                Console.Write("\nnumber is " + number + " btw.\n");
                            }
                        }
                    }

                    //ask the player if the want to play again
                    Console.WriteLine("\nwould you like to play again? (y/n) ?\n");
                    string userChoice = Console.ReadLine();
                    if (userChoice == "y" || userChoice == "Y")
                    {
                        Console.Clear();
                        isRunning = true;
                    }
                    else
                        isRunning = false;
                }
                Console.WriteLine("\nthanks for playing\n");
            }
    }
}
