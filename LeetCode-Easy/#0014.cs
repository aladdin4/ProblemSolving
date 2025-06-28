using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Easy
{
    public class _0014
    {

        //                                      14. Longest Common Prefix
        // Write a function to find the longest common prefix string amongst an array of strings.
        // If there is no common prefix, return an empty string "".

        public string LongestCommonPrefix(string[] strs)
        {
            if(strs.Length == 0) return "";
            var commonPrefix = "";
            var sorted = strs.OrderBy(w => w.Length).ToArray();
            for (int i = 0; i < sorted[0].Length; i++)
            {
                if (sorted[0].Length == 0) return "";

                for (int j = 1; j < sorted.Length; j++)
                {
                    if (sorted[0][i] != sorted[j][i])
                    {
                        Console.WriteLine(commonPrefix);
                        return commonPrefix; 
                    }
                }
                commonPrefix += sorted[0][i];
            }
            Console.WriteLine(commonPrefix);
            return commonPrefix;
        }
        public void test()
        {
            LongestCommonPrefix([ "banana", "apple", "fig", "kiwi" ]);
            LongestCommonPrefix(["flower", "flow", "flight"]);
            LongestCommonPrefix(["dog", "racecar", "car"]);
        }
    }
}
