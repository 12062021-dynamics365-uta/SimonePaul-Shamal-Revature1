using System;

namespace Rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, Computer;
            int randomnum;
            string loop;
            bool keepPlaying = true;

            while (keepPlaying)
            {

                int wins = 0;
                int Loses = 0;
                int ties = 0;


                while (keepPlaying)
                {

                    Random myRandomObject = new Random();
                    randomnum = myRandomObject.Next(1, 4);
                    Console.Write("To play: enter R for Rock, S for Scissors, P for Paper.");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    switch (randomnum)
                    {

                        case 1:
                            Computer = "Rock";
                            Console.WriteLine("The computer played Rock");
                            if (inputPlayer == "R")
                            {
                                Console.WriteLine("Tie!!\n\n");
                                ties++;
                            }
                            else if (inputPlayer == "P")
                            {
                                Console.WriteLine("You win!!\n\n");
                                wins++;
                            }
                            else if (inputPlayer == "S")
                            {
                                Console.WriteLine("Computer wins!!\n\n");
                                Loses++;
                            }
                            break;
                        case 2:
                            Computer = "Paper";
                            Console.WriteLine("The computer played Paper");
                            if (inputPlayer == "P")
                            {
                                Console.WriteLine("Tie!!\n\n");
                                ties++;
                            }
                            else if (inputPlayer == "R")
                            {
                                Console.WriteLine("Computer wins!!\n\n");
                                Loses++;
                            }
                            else if (inputPlayer == "S")
                            {
                                Console.WriteLine("You win!!\n\n");
                                wins++;
                            }
                            break;
                        case 3:
                            Computer = "Scissors";
                            Console.WriteLine("The computer played Scissors");
                            if (inputPlayer == "S")
                            {
                                Console.WriteLine("Tie!!\n\n");
                                ties++;
                            }
                            else if (inputPlayer == "R")
                            {
                                Console.WriteLine("You win!!\n\n");
                                wins++;
                            }
                            else if (inputPlayer == "P")
                            {
                                Console.WriteLine("Computer wins!!\n\n");
                                Loses++;
                            }
                            break;
                        default:                      
                            Console.WriteLine("Please enter a correct entry");  
                            break;
                    }

                    Console.WriteLine("Scores:\tWins:\t{0},\tLoses:\t{1},\tties:\t{2}", wins, Loses, ties);

                Console.WriteLine("Would you like to continue playing? (y/n)");
                loop = Console.ReadLine();
                if (loop == "y")
                {
                    keepPlaying = true;

                }
                else if (loop == "n")
                {
                    keepPlaying = false;
                }
                else
                {

                }

                }

            }

        }
    }
}