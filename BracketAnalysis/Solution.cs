using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketAnalysis
{
    public class Solution
    {

        public bool IsValid(string s)
        {
            while (s.IndexOfAny(new char[] { '(', '{', '[', ')', '}', ']' }) != -1)
            {
                if (s.Length == 1)
                    return false;
                for (int i = 1; i < s.Length; i++)
                {
                    if ((s[i - 1] == '(' && s[i] == ')') || (s[i - 1] == '{' && s[i] == '}') || (s[i - 1] == '[' && s[i] == ']'))
                    {
                        s = s.Remove(i - 1, 2);
                        //break;
                        return IsValid(s);
                    }
                    else if (i == s.Length - 1)
                        return false;
                }
            }
            return true;
        }

    }
}
