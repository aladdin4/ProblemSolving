
namespace LeetCode_Easy
{
    public class _0021
    {
        //                   21. Merge Two Sorted Lists
        //You are given the heads of two sorted linked lists list1 and list2.
        //Merge the two lists into one sorted list.The list should be made by splicing together the nodes of the first two lists.
        //Return the head of the merged linked list.
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var result = new ListNode();
            int count = 3;
            while (list1 != null && list2 != null && count > 0)
            {
                Console.WriteLine("Starting the next iteration with: " + list1.val + "," + list2.val);
                if (list1.val < list2.val)
                {
                    Console.WriteLine("list1.val < list2.val");
                    result.next = list1;
                    list1 = list1.next; //iterate 1 step in the bigger list. (= popping it)
                    result = list1;

                }
                else
                {
                    Console.WriteLine("list1.val >= list2.val");
                    result.next = list2;
                    list2 = list2.next; //iterate 1 step in the bigger list. (= popping it)
                    result = list2;
                }
                count--;
            }
            return result;
        }

                                         //why this works and mine wouldn't?
        public ListNode MergeTwoListsPerfect(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode(0);
            ListNode op = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    op.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    op.next = list2;
                    list2 = list2.next;
                }
                op = op.next;
            }

            op.next = list1 ?? list2;
            return dummy.next;
        }
        public void test()
        {
            //[1,2,4], list2 = [1,3,4]
            var list1 = new ListNode();
            list1.val = 1;
            list1.next = new ListNode();
            list1.next.val = 2;
            list1.next.next = new ListNode();
            list1.next.next.val = 4;
            var list2 = new ListNode();
            list2.val = 1;
            list2.next = new ListNode();
            list2.next.val = 3;
            list2.next.next = new ListNode();
            list2.next.next.val = 4;
            MergeTwoLists(list1, list2);
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

    }
}
