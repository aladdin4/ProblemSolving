using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode_Easy
{
    public class _0026
    {

        //26. Remove Duplicates from Sorted Array
        //Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.The relative order of the elements should be kept the same.Then return the number of unique elements in nums.

        //Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

        //Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially.The remaining elements of nums are not important as well as the size of nums.
        //Return k.
        public int RemoveDuplicates(int[] nums)
        {
            var numsDict = new Dictionary<int, int>();
            var k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!numsDict.ContainsKey(nums[i]))
                {
                    numsDict.Add(nums[i], 1);
                    k++;
                    nums[k - 1] = nums[i];
                }
            }
            return nums.Length;
        }
        public void printListOrArray(IEnumerable myList)
        {
            foreach (var item in myList)
            {
                Console.Write($"{item}, ");

            }
            Console.WriteLine("");
        }
        public void test()               
        {
           // RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);
            RemoveDuplicates([1, 1, 2]);
        }

       
    }
}
