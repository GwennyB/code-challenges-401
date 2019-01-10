using System;

namespace array_binary_search
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] inputArrayEven = { -1, 2, 18, 73, 99, 10422 }; // test input for even length case
            int[] inputArrayOdd = { -4, -3, -1, 0, 2, 18, 73, 99, 10422 }; // test input for odd length case
            int searchKeyExists = 18; // test input - search key (exists in array)
            int searchKeyDNE = -2; // test input - search key (DNE in array)

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
            foundAtIndex = BinarySearch(inputArrayOdd, searchKeyExists); // build even length case
            Console.Write($"Index where found = {foundAtIndex}");
            // search key DNE in array
            Console.WriteLine($"\nNumber to locate = {searchKeyDNE}");
            foundAtIndex = BinarySearch(inputArrayOdd, searchKeyDNE); // build even length case
            Console.Write($"Index where found = {foundAtIndex}");

            // assigned test case
            int[] inputArrayOne = { 4, 8, 15, 16, 23, 42 }; // test input for even length case
            int searchKey = 15; // test input - search key (exists in array)

            Console.WriteLine("\n\nASSIGNED CASE - KEY FOUND"); // print even length case
            Console.Write("Input array = ");
            PrintArray(inputArrayOne);
            Console.WriteLine($"Number to locate = {searchKey}");
            foundAtIndex = BinarySearch(inputArrayOne, searchKey); // build even length case
            Console.Write($"Index where found = {foundAtIndex}");

            // assigned test case - DNE
            int[] inputArrayTwo = { 11,22,33,44,55,66,77 }; // test input for even length case
            searchKey = 90; // test input - search key (exists in array)

            Console.WriteLine("\n\nASSIGNED CASE - KEY NOT FOUND"); // print even length case
            Console.Write("Input array = ");
            PrintArray(inputArrayTwo);
            Console.WriteLine($"Number to locate = {searchKey}");
            foundAtIndex = BinarySearch(inputArrayTwo, searchKey); // build even length case
            Console.Write($"Index where found = {foundAtIndex}");

            Console.ReadLine();

        }

        public static int BinarySearch(int[] inputArray, int searchKey)
        {
            // set up temp vars with initial search parameters
            int start = 0;
            int end = inputArray.Length - 1;
            int middle = FindMiddle(start, end);

            string compare = CompareToKey(searchKey, inputArray[middle]); // initial check to start 'switch'

            while ( end - start > 1 && compare != "match")
            {
                switch ( compare )
                {
                    case "match":
                        end = start;
                        break;
                    case "lower":
                        end = middle; // reset boundaries to check lower half of last checked segment
                        middle = FindMiddle(start, end);
                        compare = CompareToKey(searchKey, inputArray[middle]);
                        break;
                    case "higher":
                        start = middle; // reset boundaries to check upper half of last checked segment
                        middle = FindMiddle(start, end);
                        compare = CompareToKey(searchKey, inputArray[middle]);
                        break;
                    default:
                        break;
                }
            }

            if (compare == "match")
            {
                return middle;
            }
            return -1;
        }

        public static int FindMiddle(int start, int end)
        {
            int middle = 0;
            if ( (end-start) % 2 != 0)
            {
                middle = (end+start+1) / 2;
            }
            else
            {
                middle = (end+start) / 2;
            }
            return middle;
        }

        public static string CompareToKey(int searchKey, int currentEl)
        {
            if ( searchKey == currentEl )
            {
                return "match";
            }
            else if ( searchKey < currentEl )
            {
                return "lower";
            }
            else
            {
                return "higher";
            }
        }


        // prints an array to console
        public static void PrintArray(int[] arrayToPrint)
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
