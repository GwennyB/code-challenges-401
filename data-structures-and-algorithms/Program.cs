using System;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayShift();
        }
        static void ArrayShift()
        {
            int[] inputArrayEven = { 0, 0, 0, 0 }; // test input for even length case
            int[] inputArrayOdd = { 0, 0, 0, 0, 0 }; // test input for odd length case
            int newNum = 9999; // test input for both cases

            // even length case
            Console.WriteLine("EVEN LENGTH CASE"); // print even length case
            Console.Write("Input array = ");
            PrintArray(inputArrayEven);
            Console.WriteLine($"Number to insert = {newNum}");
            int[] shiftedArrayEven = InsertShiftArray(inputArrayEven, newNum); // build even length case
            Console.Write("Output array = ");
            PrintArray(shiftedArrayEven);

            // odd length case
            Console.WriteLine("\nODD LENGTH CASE"); // print odd length case
            Console.Write("Input array = ");
            PrintArray(inputArrayOdd);
            Console.WriteLine($"Number to insert = {newNum}");
            int[] shiftedArrayOdd = InsertShiftArray(inputArrayOdd, newNum); // build odd length case
            Console.Write("Output array = ");
            PrintArray(shiftedArrayOdd);
            Console.ReadLine();
        }

        static int[] InsertShiftArray(int[] inputArray, int newNum)
        {
            // set up shiftedArray
            int arrayLength = FindArrayLength(inputArray);
            int[] shiftedArray = new int[arrayLength];

            // get shift index
            int shiftIndex = ShiftIndex(arrayLength);

            // populate shiftedArray
            // for (left end of shiftedArray) - set shiftedArray[i] = inputArray[i] for left half, 
            for (int i = 0; i < shiftIndex; i++)
            {
                shiftedArray[i] = inputArray[i];
            }
            // for shiftIndex - set shiftedArray[i] = newNum at middle, 
            shiftedArray[shiftIndex] = newNum;
            // for (right end of shiftedArray) - set shiftedArray[i+1] = inputArray[i] for right half
            for (int i = shiftIndex; i < arrayLength-1; i++)
            {
                shiftedArray[i+1] = inputArray[i];
            }

            return shiftedArray;
        }

        // finds length of inputArray and returns length of shiftedArray (1 more than inputArray)
        static int FindArrayLength(int[] inputArray)
        {
            int counter = 0;
            int tester = 0;
            bool endOfArray = false;
            while (!endOfArray)
            {
                try
                {
                    tester = inputArray[counter]; // exception when ( counter = (last_index)+1 )
                    counter++;
                }
                catch
                {
                    // counter = (last_index) + 1
                    // inputArray_length = counter
                    endOfArray = true;
                    Console.WriteLine($"  FINDING: inputArray contains {counter} elements");
                    counter++; // shiftedArray length is 1 longer than inputArray length, or (counter + 1)
                }
            }
            return counter; // returns length of shiftedArray
        }

        // finds shift index
        static int ShiftIndex(int arrayLength)
        {
            int shiftIndex = 0; // set variable to hold shift index

            // find index to insert new element
            if (arrayLength%2 == 0)
            {
                shiftIndex = arrayLength / 2;
            }
            else
            {
                shiftIndex = (arrayLength - 1) / 2;
            }

            Console.WriteLine($"  FINDING: shiftIndex = {shiftIndex}");

            return shiftIndex;
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
