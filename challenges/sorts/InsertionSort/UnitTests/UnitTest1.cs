using System;
using Xunit;
using InsertionSort;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that backwards - sorted array returns the array sorted
        /// </summary>
        [Fact]
        public void CanSortBackwardSortedArray()
        {
            int[] unsorted = new int[] { 5, 4, 3, 2, 1 };
            int[] sorted = new int[] { 1, 2, 3, 4, 5 };
            Assert.Equal(sorted, Program.InsertionSort(unsorted));
        }

        /// <summary>
        /// verifies that a sorted array returns the same sorted array
        /// </summary>
        [Fact]
        public void CanReturnAlreadySortedArray()
        {
            int[] unsorted = new int[] { 1, 2, 3, 4, 5 };
            int[] sorted = new int[] { 1, 2, 3, 4, 5 };
            Assert.Equal(sorted, Program.InsertionSort(unsorted));
        }

        /// <summary>
        /// verifies that an empty array returns the same empty array
        /// </summary>
        [Fact]
        public void CanReturnEmptyArray()
        {
            int[] unsorted = new int[] {  };
            int[] sorted = new int[] {  };
            Assert.Equal(sorted, Program.InsertionSort(unsorted));
        }

        /// <summary>
        /// verifies that an array of one element returns the same single-element array
        /// </summary>
        [Fact]
        public void CanReturnSingleElementArray()
        {
            int[] unsorted = new int[] { 1 };
            int[] sorted = new int[] { 1 };
            Assert.Equal(sorted, Program.InsertionSort(unsorted));
        }

        /// <summary>
        /// verifies that a randomly generated unsorted array returns the array sorted
        /// </summary>
        [Fact]
        public void CanSortRandomArray()
        {
            int[] test = new int[5];
            for (int i = 0; i < test.Length; i++)
            {
                Random rnd = new Random();
                test[i] = rnd.Next(-100, 100);
            }
            test = Program.InsertionSort(test);
            bool check = true;
            for (int i = 1; i < test.Length; i++)
            {
                if (test[i] < test[i-1])
                {
                    check = false;
                }
            }
            Assert.True(check);
        }
    }
}
