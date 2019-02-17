using System;
using Xunit;
using Hashtable.Classes;
using linked_list.Classes;

namespace UnitTests
{
    /// REQMT: Retrieving based on a key returns the value stored
    /// REQMT: Successfully returns null for a key that does not exist in the hashtable
    /// REQMT: Successfully handle a collision within the hashtable
    /// REQMT: Successfully retrieve a value from a bucket within the hashtable that has a collision

    public class UnitTest1
    {
        /// <summary>
        /// REQMT: Successfully hash a key to an in-range value
        /// verifies that hash function returns correct index values within range
        /// checks for clustering
        /// </summary>
        /// <param name="key"> keys to feed into Hash </param>
        /// <param name="idx"> expected hashed indices </param>
        [Theory]
        [InlineData("cats", 652)]
        [InlineData("dogs", 596)]
        [InlineData("people", 0)]
        [InlineData("llamas", 144)]
        [InlineData("bears", 836)]
        [InlineData("goats", 420)]
        public void Hash_CanReturnIndex(Object key, int idx)
        {
            Hashmap map = new Hashmap(1024);
            Assert.Equal(idx, map.Hash(key));
        }

        /// <summary>
        /// REQMT: Adding a key/value to your hashtable results in the value being in the data structure
        /// </summary>
        /// <param name="key"> keys to feed into Hash </param>
        /// <param name="idx"> expected hashed indices </param>
        [Theory]
        [InlineData("cats", 652)]
        [InlineData("dogs", 596)]
        [InlineData("people", 0)]
        [InlineData("llamas", 144)]
        [InlineData("bears", 836)]
        [InlineData("goats", 420)]
        public void Add_AddsPairToCorrectIndex(Object key, Object value)
        {
            Hashmap map = new Hashmap(1024);
            map.Add(key, value);
            Assert.Equal(value,map.Buckets[(int)value].Find(key));
        }
    }
}
