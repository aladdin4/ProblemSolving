using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode_Easy
{
    //    1. Two Sum
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.

    public class _1
    {
        //my solution
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        //var val1 = nums[i];
                        //var val2 = nums[j];
                        //Console.WriteLine(val1 + "," + val2);
                        return [i, j];
                    }
                }
            }
            return result;
        }

        //best solution
        public int[] TwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> valuesToIndeies = new Dictionary<int, int>();
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (valuesToIndeies.ContainsKey(target - nums[i]))
                {
                    return [valuesToIndeies[target - nums[i]], i];
                }
                else
                {
                    valuesToIndeies.Add(nums[i], i);
                }
            }
            return result;
        }
        public void test()
        {
            Console.WriteLine("Hello, World!");
            var sol = new _1();
            var list1 = new int[] { 2, 7, 11, 15 };
            var target1 = 9;
            var list2 = new int[] { 3, 2, 4 };
            var target2 = 6;
            var list3 = new int[] { 3, 3 };
            var target3 = 6;
            var result1 = sol.TwoSum(list1, target1);
            var result2 = sol.TwoSum(list2, target2);
            var result3 = sol.TwoSum(list3, target3);

            Console.WriteLine("result 1:  " + result1[0] + "," + result1[1]);
            Console.WriteLine("result 2:  " + result2[0] + "," + result2[1]);
            Console.WriteLine("result 3:  " + result3[0] + "," + result3[1]);
        }
    }
}
