using System;
using System.Collections;
using System.Collections.Generic;

namespace UdemyProblems
{
    class NonRepeatingCharacter
    {
        public static void Main(String[] args)
        {
            // NOTE: The following input values will be used for testing your solution.
            var result = NonRepeating("abcab"); // should return 'c'
            result = NonRepeating("abab"); // should return null
            result = NonRepeating("aabbbc"); // should return 'c'
            result = NonRepeating("aabbdbc"); // should return 'd'
        }

        public static char? NonRepeating(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return null;
            }

            var inputChars = s.ToCharArray();

            var hm = new Hashtable();
            foreach (var c in inputChars)
            {
                if (hm.ContainsKey(c))
                {
                    var currentCount = (int) hm[c];
                    hm[c] = currentCount + 1;
                }
                else
                {
                    hm.Add(c, 1);
                }
            }
            foreach (var c in inputChars)
            {
                if ((int)hm[c] == 1)
                    return c;
            }
            return null;
        }
    }
}
    
