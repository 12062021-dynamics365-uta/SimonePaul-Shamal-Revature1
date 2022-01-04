using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {



            // string to int
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("Please enter this sentence (I control text)");
            Console.WriteLine("");
            string usersString = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("Please enter a whole number not an integer");
            Console.WriteLine("");
            string usersString1 = Console.ReadLine();
            Console.WriteLine("");

            if (string.IsNullOrEmpty(usersString))
            {
                Console.WriteLine("String can't be empty! Please input a string!");
                usersString = Console.ReadLine();
            }

            if (string.IsNullOrEmpty(usersString1))
            {
                Console.WriteLine("String can't be empty! Please input a string!");
                usersString1 = Console.ReadLine();
            }

            Program.StringToInt(usersString);
            Console.WriteLine($"Your converted string is: " + usersString);
            Console.WriteLine("______________________________________________________________________");

            Program.StringToInt(usersString1);
            Console.WriteLine($"Your converted string is: " + usersString1);
            Console.WriteLine("______________________________________________________________________");


            /**************************/

            string stringValue = "This is a string";
            PrintValues(stringValue);
            Console.WriteLine(stringValue);
            Console.WriteLine();


            double doubleValue = -12.1231250;
            PrintValues(doubleValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine();

            sbyte sbyteValue = -127;
            PrintValues(sbyteValue);
            Console.WriteLine(sbyteValue);
            Console.WriteLine();

            ulong ulongValue = 18446744073709551615;
            PrintValues(ulongValue);
            Console.WriteLine(ulongValue);
            Console.WriteLine();

            int int32Value = 2147483647;
            PrintValues(int32Value);
            Console.WriteLine(int32Value);


            byte byteValue = 255;
            PrintValues(byteValue);
            Console.WriteLine(byteValue);
            Console.WriteLine();



            decimal decimalValue = 3.001002003m;
            PrintValues(decimalValue);
            Console.WriteLine(decimalValue);
            Console.WriteLine();


            float floatValue = -31.1289f;
            PrintValues(floatValue);
            Console.WriteLine(floatValue);
            Console.WriteLine();



            short shortValue = -32767;
            PrintValues(shortValue);
            Console.WriteLine(shortValue);
            Console.WriteLine();


            uint uintValue = 4294967295;
            PrintValues(uintValue);
            Console.WriteLine(uintValue);
            Console.WriteLine();


            ushort ushortValue = 65535;
            PrintValues(ushortValue);
            Console.WriteLine(ushortValue);
            Console.WriteLine();


            long longValue = 9223372036854775807;
            PrintValues(longValue);
            Console.WriteLine(longValue);
            Console.WriteLine();


            char charValue = 'C';
            PrintValues(charValue);
            Console.WriteLine(charValue);
            Console.WriteLine();

            //bool booleanValue = false;
            //PrintValues(booleanValue);
            //Console.WriteLine(booleanValue);
            //Console.WriteLine();

          
            //int int16Value = 2147483647;
            //PrintValues(int16Value);
            //Console.WriteLine(int16Value);
            //Console.WriteLine();

            //int int64Value = 2147483647;
            //PrintValues(int64Value);
            //Console.WriteLine(int64Value);
            //Console.WriteLine();















            //
            //
            // Insert code here.
            //
            //
        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        ///
        public static string PrintValues(object obj)
        {
            //throw new NotImplementedException($"PrintValues() has not been implemented");


            //static void WriteObjectInfo(object testObject)
            //{
            TypeCode typeCode = Type.GetTypeCode(obj.GetType());

            switch (typeCode)
            {

                 case TypeCode.String:
                 return "Data type => string";

                 case TypeCode.Double:
                 return "Data type => double";

                 case TypeCode.SByte:
                 return "Data type => sbyte";

                 case TypeCode.UInt64:
                 return "Data type => ulong";

                case TypeCode.Int32:
                return "Data type => int";

                case TypeCode.Byte:
                    return "Data type => byte";

                case TypeCode.Decimal:
                    return "Data type => decimal";


                case TypeCode.Single:
                    return "Data type => float";

                case TypeCode.Int16:
                    return "Data type => short";

                case TypeCode.UInt32:
                    return "Data type => uint";



                case TypeCode.UInt16:
                 return "Data type => ushort";


                case TypeCode.Int64:
                    return "Data type => long";

                case TypeCode.Char:
                 return "Data type => char";

        

                default:
                    return "{0}: {1}" + typeCode.ToString();



            }
        }

        /// <summary>
        /// THis method has a string parameter.
        /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
        /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
        /// 3. If the string cannot be converted to a integer, return 'null'. 
        /// 4. Investigate how to use '?' to make non-nullable types nullable.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        public static int? StringToInt(string numString)
        {
            //throw new NotImplementedException($"StringToInt() has not been implemented");

            int number = 0;

            bool isParsable = Int32.TryParse(numString, out number);

            if (!isParsable)
            {
                return null;
            }
            else
            {
                return number;
            }


            //int number;


            //bool success = int.TryParse(numString, out number);
            //if (!success)
            //{
            //    return null;//($"Converted '{numString}' to {number}.");
            //}
            //else
            //{
            //    return number;
            //}

        }
    }           //end of class
}// End of Namespace
