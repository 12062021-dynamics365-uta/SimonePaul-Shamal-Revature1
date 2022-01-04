using System;
using System.Collections.Generic;

namespace _7_GuessingGameChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number (0-100)");
            int userGuess; 
            userGuess = GetUsersGuess();
            Console.WriteLine("You chose: " + userGuess);
            int randNum;
            randNum = GetRandomNumber();
            Console.WriteLine("The computer chose: " + randNum);
            int compNum;
            compNum = CompareNums(randNum,userGuess);

            if (compNum > 0)

                Console.WriteLine("{0} is greater than {1}", randNum, userGuess);

            else if (compNum < 0)

                Console.WriteLine("{0} is less than {1}", randNum, userGuess);

            else
                Console.WriteLine("{0} is equal to {1}", randNum, userGuess);




        }

        /// <summary>
        /// This method returns a randomly chosen number between 1 and 100, inclusive.
        /// </summary>
        /// <returns></returns>
        public static int GetRandomNumber()
        {
            int ranNum;
            Random rn = new Random();
            return ranNum = rn.Next(1,100);
            //throw new NotImplementedException();
        }

        /// <summary>
        /// This method gets input from the user, 
        /// verifies that the input is valid and 
        /// returns an int.
        /// </summary>
        /// <returns></returns>
        public static int GetUsersGuess()
        {
            return Convert.ToInt32(Console.ReadLine());
            //throw new NotImplementedException();
        }

        /// <summary>
        /// This method will has two int parameters.
        /// It will:
        /// 1) compare the first number to the second number
        /// 2) return -1 if the first number is less than the second number
        /// 3) return 0 if the numbers are equal
        /// 4) return 1 if the first number is greater than the second number
        /// </summary>
        /// <param name="randomNum"></param>
        /// <param name="guess"></param>
        /// <returns></returns>
        public static int CompareNums(int randNum, int userGuess)
        {
            int compNum;
           

            if (randNum < userGuess)
            {
                return compNum =  -1;
            }
            if (randNum > userGuess)
            {
                return compNum = 1;
            }

            else
            {
                return compNum = 0;
            }

            //throw new NotImplementedException();
            //compNum = randomNum.CompareTo(guess);
            //if(compNum == 0)
           
        }

        /// <summary>
        /// This method offers the user the chance to play again. 
        /// It returns true if they want to play again and false if they do not.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static bool PlayGameAgain()
        {
            throw new NotImplementedException();

        }
    }
}
