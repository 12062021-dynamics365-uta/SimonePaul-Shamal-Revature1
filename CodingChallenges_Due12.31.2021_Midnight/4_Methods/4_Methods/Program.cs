using System;

namespace _4_MethodsChallenge
{
    public class Program
    {

        public static void Main(string[] args)
        {
            /**
                YOUR CODE HERE.
            **/
            Console.WriteLine("Please enter your name!");
            string userInput = Console.ReadLine();
            userInput = GetName();
            Console.WriteLine(userInput);

            Console.WriteLine("Please enter a number like 1.5, 12.5!");
            var userInputNum = Console.ReadLine();


            Console.WriteLine("Please choose one of the following: \n[1]Addition \n[2]Subtraction \n[3]Multiplcation \n[4]Division");





        }

        public static string GetName()
        {

            //throw new NotImplementedException("GetName() is not implemented yet0");
            string name;
            name = Console.ReadLine();
            return name;//Console.ReadLine();
        }

        public static string GreetFriend(string name)
        {

            return $"Hello, {name}. You are my friend.";
            //throw new NotImplementedException("GreetFriend() is not implemented yet");
        }

        public static double GetNumber()
        {

            double number;
            number = Convert.ToDouble(Console.ReadLine());

            return number;



            //throw new NotImplementedException("GetNumber() is not implemented yet");

        }

        public static int GetAction()
        { //1)add, 2)subtract, 3)multiply, or 4)divide. 


            //throw new NotImplementedException("GetAction() is not implemented yet");

            Console.WriteLine("Please choose one of the following: [1]Addition, [2]Subtraction, [3]Multiplcation, [4]Division.");
            //instantiate stored variable, bool statement to loop over the unselected range and an int type that evaluates the output of stored variable.
            string userInput;
            bool userInputConverted = false;
            int userInputConvertedNumber;

            //This loop iterates itself until int type specified in the data range below is selected.
            do
            {

                //store the user input in a string variable
                userInput = Console.ReadLine();

                //convert the string variable into int type using tryparse method
                userInputConverted = Int32.TryParse(userInput, out userInputConvertedNumber);

            } while (!userInputConverted || userInputConvertedNumber < 1 || userInputConvertedNumber > 4);

            //returns the user input as int type if specified within the data range else returns invalid error.
            if (userInputConvertedNumber >= 1 || userInputConvertedNumber <= 4)
            {
                return userInputConvertedNumber;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                GetAction();
                return 0;
            }

        }
            //var action = Console.ReadLine();


            //if (double.TryParse(userInputNum, out double num))
            //    Console.WriteLine(num);
            //else
            //    Console.WriteLine("This is not a number!");
            //    bool conAction = false;
            //    // you can get the question form a list by the index.


            //    Console.Write("Enter 1, 2 3 or 4: ");
            //    do
            //    {

            //        int action;
            //        int parsedAction = Int32.Parse(Console.ReadLine());
            //        action = parsedAction;


            //        if (parsedAction == 1 || parsedAction == 2 || parsedAction == 3 || parsedAction = 4)
            //        {
            //            conAction = true;
            //            switch (action)
            //            {
            //                case 1: action = 1; break;
            //                case 2: action = 2; break;
            //                case 3: action = 3; break;
            //                case 4: action = 4; break;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid answer. Please enter a, b or c.");
            //        }

            //    } while (conAction == false);
            //}

            ////Console.WriteLine("String can't be empty! Please input a string!");
            ////userInputNum = Console.ReadLine();


            ////KEVIN SOULUTION
            ///* string userSelection;
            // bool userSelectionConverted = false;
            // int userSelectionConvertedNumber;

            // do
            // {
            //     userSelection = Console.ReadLine();
            //     userSelectionConverted = Int32.TryParse(userSelection, out userSelectionConvertedNumber);

            // } while (!userSelectionConverted || userSelectionConvertedNumber < 1  || userSelectionConvertedNumber > 4);

            // if (userSelectionConvertedNumber >= 1 || userSelectionConvertedNumber <= 4)
            // {
            //     return userSelectionConvertedNumber;
            // }
            // else
            // {
            //     return 0;
            // }*/



            ////switch (a)
            ////{
            ////    case 1:
            ////        return action;

            ////        break;

            ////    case 2:
            ////        return action;
            ////        break;

            ////    case 3:
            ////        return action;
            ////        break;

            ////    case 4:
            ////        return action;

            ////    
            ////        break;
            ////}







            public static double DoAction(double x, double y, int action)
        {
            if (action < 1 || action > 4)
                throw new FormatException();


            //throw new NotImplementedException("DoAction() is not implemented yet");
            double z = 0;
            switch (action)
            {
                //select for addition
                case 1:
                    Console.WriteLine("You selected addition.");
                    z = x + y;
                    return z;
                   

                //select for subtraction
                case 2:
                    Console.WriteLine("You selected subtraction.");
                    z = y - x;
                    return z;
                   

                //select for multiplciation
                case 3:
                    Console.WriteLine("You selected multiplciation.");
                    z = x * y;
                    return z;
                    

                //select for division
                case 4:
                    Console.WriteLine("You selected division.");
                    try
                    {
                        z = (x / y);

                    }
                    catch (ArithmeticException) //In case the division is divided to zero to catch exception.
                                                    //And the README gave the name of the exception as: "Arithmetic Exceptions".
                    {
                        Console.WriteLine("You can't divide to zero!");
                    }
                    return z;
                    


                default:
                    return 0;
                    
                    //throw new NotImplementedException("DoAction() is not implemented yet");
            }
        }
    }
}
