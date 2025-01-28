using System;
using System.Collections.Generic;

namespace C43_G05_ADV01
{

    internal class Program
    {
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            string input = "loveleetcode";

            int result = FirstUniqChar(input);
            
            Console.WriteLine(result);
        }
    }
}
