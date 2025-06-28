
using System;

namespace LeetCode_Easy
{
    public class _0013
    {
        //                                13. Roman to Integer
        //  Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

        //  Symbol Value
        //  I  1
        //  V  5
        //  X  10
        //  L  50
        //  C  100
        //  D  500
        //  M  1000
        //For example, 2 is written as II in Roman numeral, just two ones added together.
        //12 is written as XII, which is simply X + II.The number 27 is written as XXVII, which is XX + V + II.

        //Roman numerals are usually written largest to smallest from left to right.
        //However, the numeral for four is not IIII. Instead, the number four is written as IV.
        //Because the one is before the five we subtract it making four.
        //The same principle applies to the number nine, which is written as IX.

        //There are six instances where subtraction is used:
        //I can be placed before V (5) and X(10) to make 4 and 9. 
        //X can be placed before L(50) and C(100) to make 40 and 90. 
        //C can be placed before D(500) and M(1000) to make 400 and 900.
        //Given a roman numeral, convert it to an integer.

        //my solution  (6 ms)
        public int RomanToInt(string s)
        {
            var totalValue = 0;
            bool skipNext = false;
            Dictionary<string, int> RomanValues = new()
            {
                ["I"] = 1,
                ["V"] = 5,
                ["X"] = 10,
                ["L"] = 50,
                ["C"] = 100,
                ["D"] = 500,
                ["M"] = 1000
            };
            for (int i = 0; i < s.Length; i++)
            {
                if (skipNext)
                {
                    skipNext = false;
                    continue;
                }
                var currentIndex = i;

                var nextIndex = i + 1;
                var currentIndexLetter = s[i].ToString();
                var currentIndexLetterValue = RomanValues[currentIndexLetter];



                if (nextIndex < s.Length)
                {
                    var nextIndexLetter = s[i + 1].ToString();
                    var nextIndexLetterValue = RomanValues[nextIndexLetter];

                    if (currentIndexLetterValue < nextIndexLetterValue)
                    {
                        skipNext = true;
                        totalValue += nextIndexLetterValue - currentIndexLetterValue;
                        //Console.WriteLine($"Current Val: {totalValue}");
                    }
                    else
                    {
                        totalValue += currentIndexLetterValue;
                        //Console.WriteLine($"Current Val: {totalValue}");
                    }
                }
                else
                {
                    totalValue += currentIndexLetterValue;
                    //Console.WriteLine($"Current Val: {totalValue}");
                }

            }
            //Console.WriteLine($"Final Val: {totalValue}");

            return totalValue;
        }



        //better solution (3 ms)    *How enhanced: 1) Inserted Dictionary as part of the method
                                                 //2) Used char instead of string
                                                 //3) decreased comparison by moving the other way around and substracting the less values
                                                 //this is less of how a human mind works. but it's faster for a computer.
        public int RomanToInt2(string s)
        {
            var totalValue = 0;
            var previousLetter = 'I';
            Dictionary<char, int> RomanValues = new()
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };
            for (int i = s.Length - 1; i >= 0; i--)
            {
                var currentIndex = i;
                var nextIndex = i - 1;

                var currentIndexLetter = s[i];
                var currentIndexLetterValue = RomanValues[currentIndexLetter];

                if (RomanValues[previousLetter] > currentIndexLetterValue)
                {
                    totalValue -= currentIndexLetterValue;
                    //Console.WriteLine($"Removing Val: {totalValue}");
                }
                else
                {
                    totalValue += currentIndexLetterValue;
                    //Console.WriteLine($"Adding Val: {totalValue}");
                    previousLetter = currentIndexLetter;
                }
            }
            //Console.WriteLine($"Final Val: {totalValue}");
            return totalValue;
        }

        public void test()
        {
            Console.WriteLine("III :", RomanToInt2("III"));
            Console.WriteLine("LVIII :", RomanToInt2("LVIII"));
            Console.WriteLine("MCMXCIV :", RomanToInt2("MCMXCIV"));
        }
    }
}
