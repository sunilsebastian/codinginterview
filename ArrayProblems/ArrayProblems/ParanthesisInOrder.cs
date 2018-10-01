using System.Collections.Generic;

namespace ArrayProblems
{
    public class ParanthesisInOrder
    {
        public static bool Check(string inputString)
        {
            Stack<char> stk = new Stack<char>();
            List<char> paranthesis = new List<char> { '[', '{', '(' };
            Dictionary<char, char> pairs = new Dictionary<char, char>() { { '[', ']' }, { '{', '}' }, { '(', ')' } };

            foreach (char s in inputString)
            {
                if (paranthesis.Contains(s))
                {
                    stk.Push(s);
                }
                else
                {
                    if (stk.Count == 0)
                        return false;
                    else
                    {
                        char s1 = stk.Pop();
                        if (!s.Equals(pairs[s1]))
                            return false;
                    }
                }
            }

            return true;
        }
    }
}