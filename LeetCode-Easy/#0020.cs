using System.Collections.Generic;

namespace LeetCode_Easy
{
    public class _0020
    {

        //        20. Valid Parentheses
        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        //An input string is valid if:
        //Open brackets must be closed by the same type of brackets.
        //Open brackets must be closed in the correct order.
        //Every close bracket has a corresponding open bracket of the same type.

        public bool IsValid(string s)
        {
            var pairs = new Dictionary<char, char>()
            {
                ['('] = ')',
                ['{'] = '}',
                ['['] = ']'

            };
            var openedBrackets = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                //opening
                if (pairs.ContainsKey(s[i]))
                {
                    //adding to the opened brackets list
                    openedBrackets.Add(s[i]);
                }
                else
                {
                    //closing without opened one: fails
                    if (openedBrackets.Count == 0)
                    {
                        Console.WriteLine("failed because closing before opening");
                        return false;
                    }
                    //closing with opened one: check if they match. If not: fails
                    if (pairs[openedBrackets[openedBrackets.Count - 1]] != s[i])
                    {
                        Console.WriteLine("failed because closing one other than the opened");
                        return false;
                    }
                    else
                    {
                        //closing with opened one: remove from the opened brackets list
                        openedBrackets.RemoveAt(openedBrackets.Count - 1);
                    }
                }
            }
            Console.WriteLine("passed");
            if (openedBrackets.Count > 0)
            {
                Console.WriteLine("failed because leaving opened without close");

                return false;
            }
            return true;
        }

        public void test()
        {
            IsValid("()");
            IsValid("()[]{}");
            IsValid("(]");
            IsValid("([])");
        }
    }
}
