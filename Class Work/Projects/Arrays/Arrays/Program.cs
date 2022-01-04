using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = { 14, 15, 23, 4, 56, 67, 43, 23, 28, 12 };
            Console.WriteLine("the arre cotain the below element");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "");

            }
            Console.WriteLine();

             Array.Sort(arr, brr, 5);

            int[] brr = new int[10];
            Console.WriteLine("the new array element are ");
            Array.Copy(arr, brr, 5);
            Console.WriteLine("the array element after sorting");
            foreach (int i in arr)
            {
                Console.WriteLine(i + "");

            }


            // Array.Copy(arr, brr, 5);

            foreach (int i in brr)
            {
                Console.WriteLine(i + "");
            }



            {
            }
        }
    }
}