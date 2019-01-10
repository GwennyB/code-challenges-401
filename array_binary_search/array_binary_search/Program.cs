using System;

namespace array_binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArrayEven = { -4, -3, -1, 2, 18, 73, 99, 10422 }; // test input for even length case
            int[] inputArrayOdd = { -4, -3, -1, 0, 2, 18, 73, 99, 10422 }; // test input for odd length case
            int searchKeyExists = 18; // test input - search key (exists in array)
            int searchKeyDNE = 18; // test input - search key (DNE in array)

            // even length case
            // search key exists in array
            Console.WriteLine("EVEN LENGTH CASE"); // print even length case
            Console.Write("Input array = ");
            PrintArray(inputArrayEven);
            Console.WriteLine($"Number to locate = {searchKeyExists}");
            int foundAtIndex = BinarySearch(inputArrayEven, searchKeyExists); // build even length case
            Console.Write($"Index where found = {foundAtIndex}");
            // search key DNE in array
            Console.WriteLine($"\nNumber to locate = {searchKeyDNE}");
            foundAtIndex = BinarySearch(inputArrayEven, searchKeyDNE); // build even length case
            Console.Write($"Index where found = {foundAtIndex}");


            // odd length case
            Console.WriteLine("\n\nODD LENGTH CASE"); // print odd length case
            Console.Write("Input array = ");
            PrintArray(inputArrayOdd);
            Console.WriteLine($"Number to locate = {searchKeyExists}");
            foundAtIndex = BinarySearch(inputArrayEven, searchKeyExists); // build even length case
            Console.Write($"Index where found = {foundAtIndex}");
            // search key DNE in array
            Console.WriteLine($"\nNumber to locate = {searchKeyDNE}");
            foundAtIndex = BinarySearch(inputArrayOdd, searchKeyDNE); // build even length case
            Console.Write($"Index where found = {foundAtIndex}");

            Console.ReadLine();

        }

        static int BinarySearch(int[] inputArray, int searchKey)
        {

        }

        // prints an array to console
        static void PrintArray(int[] arrayToPrint)
        {
            Console.Write("[ "); // print even length case
            foreach (int el in arrayToPrint)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine("]");
        }
    }
}
