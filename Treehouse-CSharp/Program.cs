/*
@author: Peter Pyne <pyne.peter@gmail.com>
@organization: Peter Pyne
@copyright: Copyright (c) 2018 Peter Pyne
@license: GPL-3.0
*/
using System;
namespace Treehouse_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            double runningTotal = 0;

            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Write("Enter the number of times to print \"Yay!\": ");
                string entry = Console.ReadLine();
                try
                {
                    int times = int.Parse(entry);
                    if (times < 0)
                    {
                        Console.WriteLine("You must enter a positive number.");
                    }
                    while (times > 0)
                    {
                        Console.WriteLine("Yay!");
                        times--;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a whole number.");

                }



                // Prompt user for minutes exercised 
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string entry2 = Console.ReadLine().ToLower();

                if (entry2 == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    // Add minutes exercised to total 
                    try
                    {
                        double minutes = double.Parse(entry2);
                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not a vaLId entry.");
                            continue;
                        }
                        else if (minutes <= 10)
                        {
                            Console.WriteLine("Better than nothing, am I right?");
                        }
                        else if (minutes <= 30)
                        {
                            Console.WriteLine("Way to go hot stuff!");
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("You must be a ninja warrior in training!");
                        }
                        else
                        {
                            Console.WriteLine("Okay, now you're just showing off!");
                        }

                        runningTotal += minutes;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not valid input.");
                        continue;
                    }

                    // Display total minutes exercised to the screen 
                    Console.WriteLine("You've entered " + runningTotal + " minutes.");
                }
                // Repeat until user quits
            }

            Console.WriteLine("Goodbye");

        }
    }
}

