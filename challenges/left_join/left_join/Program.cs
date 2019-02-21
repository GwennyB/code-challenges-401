using Hashtable.Classes;
using linked_list.Classes;
using System;
using System.Collections.Generic;

namespace left_join
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static List<string> LeftJoin(Hashmap mapA, Hashmap mapB)
        {
            List<string> list = new List<string>();
            string temp = "";
            foreach (LinkedList item in mapA.Buckets)
            {
                item.Current = item.Head;
                while(item.Current != null)
                {
                    temp = (string)(mapB.Get(item.Current.Key)) ?? "no antonym";
                    temp = $"{(string)item.Current.Key}, {(string)item.Current.Value}, {temp}";
                    list.Add(temp);
                    temp = "";
                    item.Current = item.Current.Next;
                }
            }
            return list;
        }

        /// <summary>
        /// TEST HELPER: prints values in list
        /// </summary>
        /// <param name="list"></param>
        private static void PrintList(List<string> list)
        {
            Console.Write("List: ");
            foreach (string item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("(end)");
        }

    }
}
