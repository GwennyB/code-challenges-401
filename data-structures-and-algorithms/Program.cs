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
            int[] shiftedArray = insertShiftArray(inputArray, newNum);
        }

        static int[] insertShiftArray(int[] inputArray, int newNum)
        {
            int[] shiftedArray = new int[findArrayLength(inputArray)];
            // for loop to length - set shiftedArray[i] = inputArray[i] for left half, 
            //                          shiftedArray[i] = newNum at middle, 
            //                          shiftedArray[i+1] = inputArray[i] for right half
            return shiftedArray;
        }

        // finds length of inputArray and returns length of shiftedArray (1 more than inputArray)
        static int findArrayLength(int[] inputArray)
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
                    Console.Write($"inputArray contains ${counter} elements");
                    counter++; // shiftedArray length is 1 longer than inputArray length, or (counter + 1)
                }
            }
            return counter; // returns length of shiftedArray
        }
    }
}
