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
            int[] inputArray = { 0, 0, 0, 0, 0 };
            int newNum = 9999;
            int[] shiftedArray = insertShiftArray(inputArray, newNum);
        }

        static int[] insertShiftArray(int[] inputArray, int newNum)
        {
            // set up shiftedArray
            int arrayLength = FindArrayLength(inputArray);
            int[] shiftedArray = new int[arrayLength];

            // get shift index
            int shiftIndex = ShiftIndex(arrayLength);

            // populate shiftedArray
            for (int i = 0; i < arrayLength; i++)
            {
                if()
            }
            // for (length of shiftedArray) - set shiftedArray[i] = inputArray[i] for left half, 
            //                          shiftedArray[i] = newNum at middle, 
            //                          shiftedArray[i+1] = inputArray[i] for right half
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
                    Console.Write($"inputArray contains ${counter} elements");
                    counter++; // shiftedArray length is 1 longer than inputArray length, or (counter + 1)
                }
            }
            return counter; // returns length of shiftedArray
        }

        // finds shift index
        static int ShiftIndex(int arrayLength)
        {
            int shiftIndex = 0; // set return value variable

            // shift in center if even, aim high if odd
            if (arrayLength%2 == 0)
            {
                shiftIndex = arrayLength / 2;
            }
            else
            {
                shiftIndex = (arrayLength + 1) / 2;
            }

            return shiftIndex;
        }
    }
}
