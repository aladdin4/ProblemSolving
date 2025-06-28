using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode_Easy
{
    public class _9
    {

        //    9. Palindrome Number
        //Given an integer x, return true if x is a palindrome, and false otherwise.
        //https://leetcode.com/problems/palindrome-number/description/?envType=problem-list-v2&envId=n745k391
        public bool IsPalindrome(int x)
        {
            string numInStr = x.ToString();
            int numLen = numInStr.Length;
            if (x < 0)
            {
                //Console.WriteLine($"{x} is false");
                return false;
            }
            if (numLen % 2 == 0)
            {
                //even
                for (int i = 0; i <= numLen / 2; i++)
                {
                    if (numInStr[i] != numInStr[numLen - i - 1])
                    {
                        // Console.WriteLine($"{x} is false");
                        return false;
                    }
                }
            }
            else
            {
                //odd
                for (int i = 0; i < numLen / 2; i++)
                {
                    if (numInStr[i] != numInStr[numLen - i - 1])
                    {
                        // Console.WriteLine($"{x} is false");
                        return false;
                    }
                }
            }
            //Console.WriteLine($"{x} is true");
            return true;
        }

        public void test()
        {
            Console.WriteLine("Hello, World!");
            IsPalindrome(121);
            IsPalindrome(-121);
            IsPalindrome(10);
        }

    }
}
