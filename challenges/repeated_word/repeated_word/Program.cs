using System;
using Hashtable.Classes;

namespace repeated_word
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[] { "Once upon a time, there was a brave princess who...",
            "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...",
            "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York..."};

            string[] returns = new string[] { "a", "it", "summer" };
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"expected: {returns[i]};  received: {RepeatedWord(lines[i])}");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// adds each word to hashmap if not already present; returns first duplicate
        /// </summary>
        /// <param name="line"> string to search for duplicate </param>
        /// <returns> first duplicate found, or 'no repeats found' if none </returns>
        public static string RepeatedWord(string line)
        {
            string[] words = line.Split(new char[] { ' ', ',', '.', ':', ';', '?','!','*','<','>', '(', ')', '{','}','[',']' });
            int idx = 0;
            Hashmap map = new Hashmap(1024);
            foreach (var word in words)
            {
                if(word != "")
                {
                    string wordLower = word.ToLower();
                    idx = map.Hash(wordLower);
                    if(map.Contains(wordLower, 0))
                    {
                        return wordLower;
                    }
                    else
                    {
                        map.Add(wordLower, 0);
                    }
                }
            }
            return "no repeats found"; 
        }

    }
}
