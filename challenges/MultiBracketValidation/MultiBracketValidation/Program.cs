using System;
using StacksAndQueues.Classes;

namespace MultiBracketValidation
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

        public static bool MultiBracketValidation(string input)
        {
            Stack<char> brackets = new Stack<char>();
            char[] charInput = input.ToCharArray();
            foreach (char character in charInput)
            {
                switch (character)
                {
                    case '[':
                        brackets.Push(character);
                        break;
                    case '(':
                        brackets.Push(character);
                        break;
                    case '{':
                        brackets.Push(character);
                        break;
                    case ']':
                        if(brackets.Top != null && brackets.Top.Value == '[')
                        {
                            brackets.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case ')':
                        if (brackets.Top != null && brackets.Top.Value == '(')
                        {
                            brackets.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (brackets.Top != null && brackets.Top.Value == '{')
                        {
                            brackets.Pop();
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
            if(brackets.Top != null)
            {
                return false;
            }
            return true;
        }

    }
}
