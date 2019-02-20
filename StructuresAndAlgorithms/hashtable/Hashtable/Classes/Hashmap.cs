using System;
using System.Collections.Generic;
using System.Text;
using linked_list.Classes;

namespace Hashtable.Classes
{
    public class Hashmap
    {
        // associative array
        private int _size;
        public LinkedList[] Buckets { get; set; }

        /// <summary>
        /// CONSTRUCTOR: builds the associative array of specified length to store key-value pairs
        /// </summary>
        /// <param name="size"> desired length of associative array </param>
        public Hashmap(int size)
        {
            _size = size;
            Buckets = new LinkedList[size];
        }

        /// <summary>
        /// converts a key into an associated index
        /// </summary>
        /// <param name="key"> key to hash </param>
        /// <returns> hashed index </returns>
        public int Hash(Object key)
        {
            string keyString = (string)key;
            long num = 1;
            foreach (char item in keyString)
            {
                num *= item;
            }
            int idx = (int)(num*599 % _size);
            return idx;
        }

        /// <summary>
        /// creates a new linked list in the hashtable index if empty
        /// adds key/value pair to the appropriate location in the hashtable
        /// </summary>
        /// <param name="key"> value of 'Key' </param>
        /// <param name="value"> value of 'Value' </param>
        public void Add(Object key, Object value)
        {
            int idx = Hash(key);
            if (Buckets[idx] == null)
            {
                Buckets[idx] = new LinkedList();
            }
            if (Get(key) == null)
            {
                Buckets[idx].Append(key, value);
            }
        }

        /// <summary>
        /// locates a key in hashtable and returns its associated value
        /// </summary>
        /// <param name="key"> key to locate in hashtable </param>
        /// <returns> value associated with key, or 'null' if not found </returns>
        public Object Get(Object key)
        {
            int idx = Hash(key);
            if (Buckets[idx] == null)
            {
                return null;
            }
            return Buckets[idx].Find(key);
        }

        /// <summary>
        /// finds specified key in hashtable
        /// if present, compares values
        /// if matching, return true
        /// </summary>
        /// <param name="key"> value of 'key' to locate </param>
        /// <param name="value"> value of 'value' to confirm </param>
        /// <returns></returns>
        public bool Contains(Object key, Object value)
        {
            Object answer = Get(key);
            if (answer != null && answer.Equals(value))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// removes a node of specified key/value from a hashtable (if it exists)
        /// </summary>
        /// <param name="key"> key of node to remove </param>
        /// <param name="value"> value of node to remove </param>
        public void Remove(Object key, Object value)
        {
            int idx = Hash(key);
            Buckets[idx].Current = Buckets[idx].Head;
            Node temp = new Node("");
            temp.Next = Buckets[idx].Current;
            while (Buckets[idx].Current != null)
            {
                if (Buckets[idx].Current.Key.Equals(key)
                    && Buckets[idx].Current.Value.Equals(value))
                {
                    temp.Next = Buckets[idx].Current.Next;
                    return;
                }
                else
                {
                    temp = temp.Next;
                    Buckets[idx].Current = Buckets[idx].Current.Next;
                }
            }
            temp.Next = null;
        }

    }
}
