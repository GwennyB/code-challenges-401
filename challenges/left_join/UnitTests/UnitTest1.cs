using System;
using Xunit;
using Hashtable.Classes;
using linked_list.Classes;
using left_join;
using System.Collections.Generic;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that strings are returned for all left records when unmatched with right records
        /// </summary>
        [Fact]
        public void CanReturnSingleUnmatchedRecord()
        {
            Hashmap mapA = new Hashmap(1024);
            mapA.Add("cats", "blue");
            Hashmap mapB = new Hashmap(1024);
            mapB.Add("ants", "223");

            Assert.Contains("cats, blue, no antonym", Program.LeftJoin(mapA, mapB));
        }

        /// <summary>
        /// verifies that a string is returned for each left record
        /// </summary>
        [Fact]
        public void CanReturnAllLeftRecords()
        {
            Hashmap mapA = new Hashmap(1024);
            mapA.Add("cats", "blue");
            mapA.Add("dogs", "green");
            mapA.Add("llamas", "red");
            mapA.Add("cows", "purple");
            Hashmap mapB = new Hashmap(1024);
            mapB.Add("ants", "223");

            Assert.Equal(4, Program.LeftJoin(mapA, mapB).Count);
        }

        /// <summary>
        /// verifies that a matching record returns a string with correlating values
        /// </summary>
        [Fact]
        public void CanReturnMatchedRecordOfMany()
        {
            Hashmap mapA = new Hashmap(1024);
            mapA.Add("cats", "blue");
            mapA.Add("dogs", "green");
            mapA.Add("llamas", "red");
            mapA.Add("cows", "purple");
            Hashmap mapB = new Hashmap(1024);
            mapB.Add("llamas", "14");
            mapB.Add("cats", "73");
            mapB.Add("pigeons", "5");

            Assert.Contains("llamas, red, 14", Program.LeftJoin(mapA, mapB));
        }

        /// <summary>
        /// verifies that populated list is returned when right map is empty
        /// </summary>
        [Fact]
        public void CanHandleEmptyRight()
        {
            Hashmap mapA = new Hashmap(1024);
            mapA.Add("cats", "blue");
            mapA.Add("dogs", "green");
            mapA.Add("llamas", "red");
            mapA.Add("cows", "purple");
            Hashmap mapB = new Hashmap(1024);

            Assert.Equal(4, Program.LeftJoin(mapA, mapB).Count);
        }

        /// <summary>
        /// verifies that empty list is returned when left map is empty
        /// </summary>
        [Fact]
        public void CanHandleEmptyLeft()
        {
            Hashmap mapA = new Hashmap(1024);
            mapA.Add("cats", "blue");
            mapA.Add("dogs", "green");
            mapA.Add("llamas", "red");
            mapA.Add("cows", "purple");
            Hashmap mapB = new Hashmap(1024);

            Assert.Empty(Program.LeftJoin(mapB, mapA));
        }
    }
}
