

using System.Collections;

namespace LeetCode_Easy
{
    public class _0027
    {
        //             27. Remove Element
        //Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.The order of the elements may be changed.
        //Then return the number of elements in nums which are not equal to val.

        //Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

        //  Change the array nums such that the first k elements of nums contain the elements which are not equal to val.
        //  The remaining elements of nums are not important as well as the size of nums.
        //  Return k.

        public int RemoveElement(int[] nums, int val)
        {
            var lastGoodIndexPointer = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                //we will use a pointer that points to the last good index.
                //we only care if the value is good value.
                //if it is, we will assign it to the next spot.
                //imagine a list of all good spots
                //the pointer will keep assigning them in the same order.
                //imaging now it has some bad spots inside.
                //the pointer will not see them because it's count issn't changed with the bad ones.
                //so, the pointer will re-order the array and fill out the gaps and ignore the rest of the array.

                if (nums[i] != val)    
                  
                {
                    nums[lastGoodIndexPointer] = nums[i];
                    lastGoodIndexPointer++;
                }
            }
            return lastGoodIndexPointer;
        }
        public void test()
        {
            RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2);
        }
        public void printListOrArray(IEnumerable myList)
        {
            foreach (var item in myList)
            {
                Console.Write($"{item}, ");

            }
            Console.WriteLine("");
        }
    }
}
