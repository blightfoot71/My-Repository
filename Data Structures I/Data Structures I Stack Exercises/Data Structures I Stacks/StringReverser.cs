using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_I_Stacks
{
    public class StringReverser
    {
        private readonly List<char> leftBrackets = new List<char>() { '(', '<', '[', '{' };
        private readonly List<char> rightBrackets = new List<char>() { ')', '>', ']', '}' };


        public String reverse(String input)
        {
            if (input == null)
                throw new ArgumentNullException();

            var stack = new Stack<char>();

            foreach (char ch in input)
                stack.Push(ch);

            var reversed = new StringBuilder();
            while (stack.Count > 0)
            {
                reversed.Append(stack.Pop());
            }
            return reversed.ToString();
        }

        public bool IsBalanced(String input)
        {
            var stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (isLeftBracket(ch))
                    stack.Push(ch);

                if (isRightBracket(ch))
                {
                    if (!stack.Any()) return false;

                    var top = stack.Pop();
                    if (!bracketsMatch(top, ch)) return false;
                }
            }

            return !stack.Any(); // Apparently this is a linq extension.  .count is probably the most efficient

            //if (stack.Count == 0)
            //    return true;
            //else
            //    return false;
        }
            private bool isLeftBracket(char ch)
            {
                return leftBrackets.Contains(ch);
            
            }

            private bool isRightBracket(char ch)
            {
                return rightBrackets.Contains(ch);
        }

            private bool bracketsMatch(char left, char right)
            {
                return leftBrackets.IndexOf(left) == rightBrackets.IndexOf(right); //Refactored into this.
                //return  (right == ')' && left != '(') ||
                        //(right == '>' && left != '<') ||
                        //(right == ']' && left != '[') ||
                        //(right == '}' && left != '{');
            }
    }
}
