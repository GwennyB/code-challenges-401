using System;
using Xunit;
using merge_lists;
using linked_list.Classes;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that BuildList builds and returns a list of correct size
        /// </summary>
        [Fact]
        public void BuildList_ReturnsListOfCorrectSize()
        {
            LinkedList list = Program.BuildList(4);
            list.Current = list.Head;
            int counter = 1;
            while (list.Current.Next != null)
            {
                list.Current = list.Current.Next;
                counter++;
            }
            Assert.Equal(4, counter);
        }

        /// <summary>
        /// verifies that BuildList can build an empty list
        /// </summary>
        [Fact]
        public void BuildList_ReturnsEmptyList()
        {
            LinkedList list = Program.BuildList(0);

            Assert.Null(list.Head);
        }

        /// <summary>
        /// returns properly merged list when lists are same length
        /// </summary>
        [Fact]
        public void Merge_MergesWhenListsSameLength()
        {
            LinkedList listA = Program.BuildList(3);
            LinkedList listB = Program.BuildList(3);
            listA.Current = listA.Head;
            listB.Current = listB.Head;
            int[] correctMerge = new int[6];
            for (int i = 0; i < 6; i+=2)
            {
                correctMerge[i] = listA.Current.Value;
                correctMerge[i + 1] = listB.Current.Value;
                listA.Current = listA.Current.Next;
                listB.Current = listB.Current.Next;
            }
            Program.Merge(listA, listB);
            listA.Current = listA.Head;
            bool match = true;
            for (int i = 0; i < 6; i++)
            {
                if(listA.Current.Value != correctMerge[i])
                {
                    match = false;
                }
                listA.Current = listA.Current.Next;
            }
            Assert.True(match);
        }

        /// <summary>
        /// returns properly merged list when lists are same length
        /// </summary>
        [Fact]
        public void Merge_MergesWhenListsSameLength()
        {
            LinkedList listA = Program.BuildList(3);
            LinkedList listB = Program.BuildList(3);
            listA.Current = listA.Head;
            listB.Current = listB.Head;
            int[] correctMerge = new int[6];
            for (int i = 0; i < 6; i += 2)
            {
                correctMerge[i] = listA.Current.Value;
                correctMerge[i + 1] = listB.Current.Value;
                listA.Current = listA.Current.Next;
                listB.Current = listB.Current.Next;
            }
            Program.Merge(listA, listB);
            listA.Current = listA.Head;
            bool match = true;
            for (int i = 0; i < 6; i++)
            {
                if (listA.Current.Value != correctMerge[i])
                {
                    match = false;
                }
                listA.Current = listA.Current.Next;
            }
            Assert.True(match);
        }
    }
}
