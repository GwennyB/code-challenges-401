using DedupeLinkedList;
using linked_list.Classes;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that duplicate is properly removed when it's the head,
        /// and that head is still retrievable
        /// </summary>
        [Fact]
        public void CanRemoveDuplicateWhenHead()
        {
            LinkedList test = Program.BuildList(new int[] { 1, 3, 4, 1, 2, 5, 6 });
            Assert.Equal(3, Program.LLRemoveDupes(test).Head.Value);
        }

        /// <summary>
        /// verifies that a single node list is returned as sent
        /// </summary>
        [Fact]
        public void CanHandleSingleNodeList()
        {
            LinkedList test = Program.BuildList(new int[] { 1 });
            Assert.Equal(1, Program.LLRemoveDupes(test).Head.Value);
        }

        /// <summary>
        /// verifies that all duplicates are removed and a single node list returned
        /// when all nodes are the same
        /// </summary>
        [Fact]
        public void CanRemoveDupesWhenAllSameValue()
        {
            LinkedList test = Program.BuildList(new int[] { 1, 1, 1, 1, 1 });
            Assert.Null(Program.LLRemoveDupes(test).Head.Next);
        }

        /// <summary>
        /// verifies that an empty list returns an empty list
        /// </summary>
        [Fact]
        public void ReturnsNullWhenEmptyList()
        {
            LinkedList test = Program.BuildList(new int[] {  });
            Assert.Null(Program.LLRemoveDupes(test).Head);
        }
    }
}
