using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Problems.String
{
    public class Q20
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach(var c in s)
            {
                if(c is '(' or '{' or '[')
                {
                    stack.Push(c);
                }
                else if(
                    stack.Count > 0 && (
                    (c == ')' && stack.Peek() == '(') ||
                    (c == '}' && stack.Peek() == '{') ||
                    (c == ']' && stack.Peek() == '['))
                    )
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}