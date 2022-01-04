using System;
using static System.Console;
using System.Linq;

namespace MiniMaxSum
{
    class Program

    {

        static void Main(String[] args)
        {
            double[] arr = new double[] { 1, 3, 5, 7, 9 };

            double maxSum = 0;
            double minSum = 0;
            double sum = 0;
            double max;
            double min;

           
            max = arr[0];
            min = arr[0];


            
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }



            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    
                }
            }
            Console.Write("Maximum element = {0}\n", max);
            Console.Write("Minimum element = {0}\n\n", min);
            Console.Write("The sum of elements = {0}\n\n", sum);

            /*******/




            maxSum = sum - min;
                minSum = sum - max;

            
            Console.Write("The maxSum is:" + maxSum);
            Console.Write(" ");
            Console.Write(" ");
            Console.Write("The minSum is:" + minSum);

        }
    }
}
