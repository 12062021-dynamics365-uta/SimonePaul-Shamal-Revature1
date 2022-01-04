using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            *
            * implement the required code here and within the methods below.
            *
            */

            //UPPERCASE
        Console.WriteLine("______________________________________________________________________");
        Console.WriteLine("");
            Console.WriteLine("Please enter a string (all lower-case) to be converted to UpperCase?");
            Console.WriteLine("");
            string usersString = Console.ReadLine();
        Console.WriteLine("");


            if (string.IsNullOrEmpty(usersString))
            {
                Console.WriteLine("String can't be empty! Please input a string!");
                usersString = Console.ReadLine();
            }

            string ustrCon = StringToUpper(usersString);
            Console.WriteLine($"Your converted string is: " + ustrCon);
        Console.WriteLine("______________________________________________________________________");


            // Lowercase
        Console.WriteLine("");
            Console.WriteLine("Please enter a string (all Upper-Case) to be converted to LowerCase?");
            Console.WriteLine("");
            usersString = Console.ReadLine();
        Console.WriteLine("");

            if (string.IsNullOrEmpty(usersString))
            {
                Console.WriteLine("String can't be empty! Please input a string!");
                usersString = Console.ReadLine();
            }

             ustrCon = StringToLower(usersString);
            Console.WriteLine($"Your converted string is: " + ustrCon);
         Console.WriteLine("______________________________________________________________________");



            // Trim
            Console.WriteLine("");
            Console.WriteLine("Please enter a string with spaces before and after. Watch me remove them!");
            Console.WriteLine("");
            usersString = Console.ReadLine();
            Console.WriteLine("");

            if (string.IsNullOrEmpty(usersString))
            {
                Console.WriteLine("String can't be empty! Please input a string!");
                usersString = Console.ReadLine();
            }

            ustrCon = StringTrim(usersString);
            Console.WriteLine($"Your converted string is: " + ustrCon);
            Console.WriteLine("______________________________________________________________________");


            //  returns the stringSubstring
            int firstElement;
            int lengthOfSubstring;
           // string substr = Program.StringSubstring("This is a long string",firstElement,lengthOfSubstring);

            Console.WriteLine("");
            Console.WriteLine("Please enter a string.");
            usersString = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Please enter a 1.");
            firstElement = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Please enter a 7.");
            lengthOfSubstring = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (string.IsNullOrEmpty(usersString))
            {
                Console.WriteLine("String can't be empty! Please input a string!");
                usersString = Console.ReadLine();
            }

            ustrCon = StringSubstring(usersString,firstElement, lengthOfSubstring);
            Console.WriteLine($"Your converted string is: " + ustrCon);
            Console.WriteLine($"The first element of the string is: " + firstElement);
            Console.WriteLine($"The length of the string is: " + lengthOfSubstring);



            Console.WriteLine("______________________________________________________________________");

            // return a char of a string
            string userInputString;
            char   charUserWants;

            Console.WriteLine("");
            Console.WriteLine("Please enter a string.");
            userInputString = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Please enter a letter of your string and I will return its position");
            charUserWants = Convert.ToChar(Console.ReadLine());
            int searchString = SearchChar(userInputString, charUserWants);
          
            Console.WriteLine("");

            if (string.IsNullOrEmpty(userInputString))
            {
                Console.WriteLine("String can't be empty! Please input a string!");
                usersString = Console.ReadLine();
            }

            Console.WriteLine($"Your converted string is: " + searchString);  
            Console.WriteLine("______________________________________________________________________");


            // return a concatenation of a string
            

            Console.WriteLine("");
            Console.WriteLine("Please enter a your firstname");
            string FName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Please enter a your last name.");
            string LName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(FName + " " +LName);

            string userInput = ConcatNames(FName, LName);

            Console.WriteLine("");

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("String can't be empty! Please input a string!");
                usersString = Console.ReadLine();
            }

            Console.WriteLine($"Your converted string is: " + userInput);
            Console.WriteLine("______________________________________________________________________");


        }








        /// <summary>
        /// This method has one string parameter and will: 
        /// 1) change the string to all upper case and 
        /// 2) return the new string.
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>
        public static string StringToUpper(string usersString)
        {
            //throw new NotImplementedException("StringToUpper method not implemented.");


            return usersString.ToUpper();




        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) change the string to all lower case,
        /// 2) return the new string into the 'lowerCaseString' variable
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>       
        public static string StringToLower(string usersString)
        {
            //throw new NotImplementedException("StringToUpper method not implemented.");
            return usersString.ToLower();
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) trim the whitespace from before and after the string, and
        /// 2) return the new string.
        /// HINT: When getting input from the user (you are the user), try inputting "   a string with whitespace   " to see how the whitespace is trimmed.
        /// </summary>
        /// <param name="usersStringWithWhiteSpace"></param>
        /// <returns></returns>
        public static string StringTrim(string usersStringWithWhiteSpace)
        {
            //throw new NotImplementedException("StringTrim method not implemented.");
            return usersStringWithWhiteSpace.Trim();


        }

        /// <summary>
        /// This method has three parameters, one string and two integers. It will:
        /// 1) get the substring based on the first integer element and the length 
        /// of the substring desired.
        /// 2) return the substring.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="firstElement"></param>
        /// <param name="lastElement"></param>
        /// <returns></returns>
        public static string StringSubstring(string x, int firstElement, int lengthOfSubstring)
        {
            //throw new NotImplementedException("StringSubstring method not implemented.");
            return x.Substring(firstElement,lengthOfSubstring);
        }

        /// <summary>
        /// This method has two parameters, one string and one char. It will:
        /// 1) search the string parameter for first occurrance of the char parameter and
        /// 2) return the index of the char.
        /// HINT: Think about how StringTrim() (above) would be useful in this situation
        /// when getting the char from the user. 
        /// </summary>
        /// <param name="userInputString"></param>
        /// <param name="charUserWants"></param>
        /// <returns></returns>
        public static int SearchChar(string userInputString, char charUserWants)
        {
            //throw new NotImplementedException("SearchChar method not implemented.");
            return userInputString.IndexOf(charUserWants);

            
        }

        /// <summary>
        /// This method has two string parameters. It will:
        /// 1) concatenate the two strings with a space between them.
        /// 2) return the new string.
        /// HINT: You will need to get the users first and last name in the 
        /// main method and send them as arguments.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <returns></returns>
        public static string ConcatNames(string fName, string lName)
        {
            //throw new NotImplementedException("ConcatNames method not implemented.");

            //return fName + "" + lName;
            return String.Concat(fName, lName);
        }
    }//end of program
}
