using System;
using StacksAndQueues.Classes;

namespace MultiBracketValidationChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = new string[]
            {
                "{}",
                "{}(){}",
                "()[[Extra Characters]]",
                "(){}[[]]",
                "{}{Code}[Fellows](())",
                "[({}]",
                "(](",
                "{(})"
            };
            foreach (string item in inputs)
            {
                Console.WriteLine($"{item} balanced: {MultiBracketValidation(item)}");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Checks passed-in strings for whether any brackets it contains are balanced.
        /// ie - (), [], {}
        /// </summary>
        /// <param name="input"> string to check </param>
        /// <returns> 'true' if balanced, 'false' if not </returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack<char> openers = new Stack<char>();

            char[] brackets = new char[] { '[', ']','{','}', '(',')' };

            int isBracket = 0;

            for(int i=0; i<input.Length; i++)
            {
                isBracket = (Array.IndexOf(brackets, input[i]) == -1) ? -1 : (Array.IndexOf(brackets, input[i]) % 2);

                switch (isBracket)
                {
                    case 0:
                        openers.Push(input[i]);
                        break;
                    case 1:
                        if (openers.Top != null && openers.Top.Value == brackets[Array.IndexOf(brackets,input[i])-1])
                        {
                            openers.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    default:
                        break;
                }
            }
            if (openers.Top != null)
            {
                return false;
            }
            return true;
        }

    }
}
