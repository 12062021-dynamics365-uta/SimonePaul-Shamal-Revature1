using System;

namespace SweetnSaltyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Sweet and Salty Console Application");// greets the user
            Console.WriteLine("Numbers 1-1000 will be displayed, grouped in sets of twenty "); // Console write line prompts users of total numbers displayed
            Console.WriteLine(" ");
            /*
             * 
             * Initialize each of the variables below to be used for counting 
             * the amount of sweet, salty and sweetnsalty.
             * 
             */
            int Sweet = 0;
            int Salty = 0;
            int SweetnSalty = 0;

            /*
             * 
             * 
             * for loop to run through numbers 1-1000 and display to the screen 
             * 
             * 
            */
            Console.WriteLine("Number in sets of 20 per line: ");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            for (int num = 1; num <= 1000; num++)



            {
                if (num % 3 == 0 && num % 5 == 0) // if statement to test if numbers are divisible by 3 and 5 
                {
                    Console.Write("SweetnSalty" + " ");//  if the statement is true will print sweetnsalty  not number
                    SweetnSalty++;
                }
                else if (num % 5 == 0)// if statement to test if numbers are divisible by 5  
                {
                    Console.Write("Salty" + " ");// if the statement is true will print salty not number
                    Salty++;
                }
                else if (num % 3 == 0)// if statement to test if numbers are divisible by 3 
                {
                    Console.Write("Sweet" + " "); //if the statement is true will print sweet not number
                    Sweet++;
                }

                else
                {
                    Console.Write(num + " ");

                }

                if (num % 20 == 0) // this line checks if num is divisble by 20 if it is true it creates a new line 
                {

                    Console.WriteLine("\n");

                }



            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");


            Console.WriteLine(" ");
            Console.WriteLine("SweetnSalty Appears: " + SweetnSalty + " times"); // print the total amount of times sweetnsalty is displayed in console
            Console.WriteLine("Sweet Appears: " + Sweet + " times");// prints the total amount of times sweet is displayed in console
            Console.WriteLine("Salty Appears: " + Salty + " times");// print the total amount of time salty is displayed in console

        }
    }  }
        
    



