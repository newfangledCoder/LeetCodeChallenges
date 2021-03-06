using System;
using System.Collections.Generic;
using System.Text;

namespace May
{
    public class Problem_2
    {
        /*
            You're given strings J representing the types of stones that are jewels, and S representing the stones you have.
            Each character in S is a type of stone you have. You want to know how many of the stones you have are also jewels.

            The letters in J are guaranteed distinct, and all characters in J and S are letters.
            Letters are case sensitive, so "a" is considered a different type of stone from "A".

            Example 1:

            Input: J = "aA", S = "aAAbbbb"
            Output: 3
            Example 2:

            Input: J = "z", S = "ZZ"
            Output: 0
        */

        // Solution start

        public static int CountJewels(string J, string S)
        {
            int jewelCount = 0;

            Dictionary<char, int> Jewels = new Dictionary<char, int>();

            for(int i = 0; i < J.Length; i++)
            {
                Jewels.Add(J[i], i+1);
            }

            for(int j = 0; j < S.Length; j++)
            {
                if(Jewels.ContainsKey(S[j]))
                {
                    jewelCount++;
                }
            }

            return jewelCount;
        }

        // Solution ends
    }
}