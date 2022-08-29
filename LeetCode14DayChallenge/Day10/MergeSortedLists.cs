namespace LeetCode14DayChallenge.Day10
{
    public class MergeSortedLists
    {
        public static void Solution()
        {
            var list1 = ArrayToListNode.Convert(new[] { 1, 2, 4 });
            var list2 = ArrayToListNode.Convert(new[] { 1, 3, 4 });

            var listNode = MergeTwoLists(list1, list2);

            var x = listNode;
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var listNode = new ListNode();
            ListNode nextList1 = null;
            ListNode nextList2 = null;

            if(list1.val <= list2.val)
            {
                listNode.val = list1.val;
                listNode.next = new ListNode();
                nextList1 = list1.next;
            }
            else
            {
                listNode.val = list2.val;
                listNode.next = new ListNode();
                nextList2 = list2.next;
            }

            var nextNode = listNode.next;
            
            while(list1.next != null || list2.next != null)
            {
                if(nextList1 == null && nextList2 != null)
                {
                    nextNode.val = nextList2.val;
                    nextList2 = nextList2.next;
                }
                else if (nextList2 == null && nextList1 != null)
                {
                    nextNode.val = nextList1.val;
                    nextList1 = nextList1.next;
                }
                else if(nextList1.val <= nextList2.val)
                {
                    nextNode.val = nextList1.val;
                    nextList1 = nextList1.next;
                }
                else if(nextList2.val >= nextList1.val)
                {
                    nextNode.val = nextList2.val;
                    nextList2 = nextList2.next;
                }

                nextNode.next = new ListNode();
                nextNode = nextNode.next;
            }

            return null;
        }
    }
}
