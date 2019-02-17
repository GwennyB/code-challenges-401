using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  A backwards - sorted array returns the array sorted
            int[] testOne = new int[] { 5, 4, 3, 2, 1 };
            Console.WriteLine("Test One: A backwards - sorted array returns the array sorted");
            PrintArray(testOne);
            PrintArray(InsertionSort(testOne));

            //  A sorted array returns the same sorted array
            int[] testTwo = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nTest Two: A sorted array returns the same sorted array");
            PrintArray(testTwo);
            PrintArray(InsertionSort(testTwo));

            //  An empty array returns the same empty array
            int[] testThree = new int[] { };
            Console.WriteLine("\nTest Three: An empty array returns the same empty array");
            PrintArray(testThree);
            PrintArray(InsertionSort(testThree));

            //  An array of one element returns the same single-element array
            int[] testFour = new int[] { 1 };
            Console.WriteLine("\nTest Four: An array of one element returns the same single-element array");
            PrintArray(testFour);
            PrintArray(InsertionSort(testFour));

            //  A randomly generated unsorted array returns the array sorted
            int[] testFive = new int[5];
            for(int i = 0; i<testFive.Length; i++)
            {
                Random rnd = new Random();
                testFive[i] = rnd.Next(-100, 100);
            }
            Console.WriteLine("\nTest Five: A randomly generated unsorted array returns the array sorted");
            PrintArray(testFive);
            PrintArray(InsertionSort(testFive));

            Console.ReadLine();

        }

        /// <summary>
        /// sorts an int array in place, in ascending order
        /// </summary>
        /// <param name="arr"> int array to sort </param>
        /// <returns> sorted array </returns>
        public static int[] InsertionSort(int[] arr)
        {
            if (arr.Length < 2)
            {
                return arr;
            }
            int current;
            for(int i = 1; i < arr.Length; i++)
            {
                current = arr[i];
                for(int k = i-1; k>=0; k--)
                {
                    while (current < arr[k])
                    {
                        arr[k + 1] = arr[k];
                        arr[k] = current;
                    }
                }

            }
            return arr;

        }

        /// <summary>
        /// prints an int array to console
        /// </summary>
        /// <param name="arr"> int array to print </param>
        private static void PrintArray(int[] arr)
        {
            Console.Write("ARRAY: ");
            if(arr.Length == 0)
            {
                Console.Write("(empty)");
            }
            foreach (int item in arr)
            {
                Console.Write($"  {item}  ");
            }
            Console.WriteLine();
        }
    }
}
