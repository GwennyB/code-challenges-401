using System;
using Xunit;
using Hashtable.Classes;
using linked_list.Classes;

namespace UnitTests
{

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
            Assert.Equal(value, map.Buckets[(int)value].Find(key));
        }

        /// <summary>
        /// REQMT: Successfully handle a collision within the hashtable
        /// verifies that colliding pairs are stored in the same bucket
        /// </summary>
        /// <param name="keyOne"> key of 1st colliding pair </param>
        /// <param name="keyTwo"> key of 2nd colliding pair</param>
        /// <param name="value"> value of both pairs, and of bucket index </param>
        [Theory]
        [InlineData("dogs", "gods", 596)]
        [InlineData("cats", "stac", 652)]
        public void Add_AddsCollidingPairs(Object keyOne, Object keyTwo, Object value)
        {
            Hashmap map = new Hashmap(1024);
            map.Add(keyOne, value);
            map.Add(keyTwo, value);
            Assert.Equal(map.Buckets[(int)value].Find(keyOne), map.Buckets[(int)value].Find(keyTwo));
        }


        /// <summary>
        /// REQMT: Retrieving based on a key returns the value stored
        /// returns value from associated key in a bucket with collisions
        /// </summary>
        /// <param name="key"> value of 'key' </param>
        /// <param name="value"> value of 'value' </param>
        [Theory]
        [InlineData("cats", 652)]
        [InlineData("dogs", 596)]
        [InlineData("people", 0)]
        [InlineData("llamas", 144)]
        [InlineData("bears", 836)]
        [InlineData("goats", 420)]
        public void Get_ReturnsValueFromKey(Object key, Object value)
        {
            Hashmap map = new Hashmap(1024);
            map.Add(key, value);
            Assert.Equal(value, map.Get(key));
        }


        /// <summary>
        /// REQMT: Successfully retrieve a value from a bucket within the hashtable that has a collision
        /// returns value from associated key in a bucket with collisions
        /// </summary>
        /// <param name="keyOne"> first key </param>
        /// <param name="keyTwo"> second key </param>
        [Theory]
        [InlineData("dogs", "gods")]
        [InlineData("cats", "stac")]
        public void Get_ReturnsValueFromCollidingKey(Object keyOne, Object keyTwo)
        {
            Hashmap map = new Hashmap(1024);
            map.Add(keyOne, 1);
            map.Add(keyTwo, 2);
            Assert.Equal(2, map.Get(keyTwo));
        }


        /// <summary>
        /// REQMT: Successfully returns null for a key that does not exist in the hashtable
        /// </summary>
        [Fact]
        public void Get_ReturnsNullWhenNotPresent()
        {
            Hashmap map = new Hashmap(1024);
            map.Add("key", 1);
            map.Add("other key", 2);
            Assert.Null(map.Get("not there"));
        }
    }
}
