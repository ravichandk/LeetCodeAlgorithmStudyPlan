namespace LeetCode75.Day03
{
    public class C001_RemoveNthNodeFromListNode
    {
        public static void Solution()
        {
            var array = new[] { 1, 2, 3, 4, 5 };
            var n = 2;

            var head = ArrayToListNode.ConvertToListNode(array);

            var listNodeAfterRemoving = RemoveNthFromEnd(head, n);

            var x = listNodeAfterRemoving;
        }

        private static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null) return null;

            var listNode = head;
            var numberOfNodes = 1;

            while(listNode.next != null)
            {
                listNode = listNode.next;
                numberOfNodes++;
            }

            var indexToSkip = numberOfNodes - n;

            if (indexToSkip < 0) return null;

            listNode = head;
            ListNode newListNode = null;
            ListNode output = null;

            for(var i = 0; i < numberOfNodes; i++)
            {
                if (i == indexToSkip)
                {
                    listNode = listNode.next;
                    continue;
                }

                if (newListNode == null)
                {
                    newListNode = new ListNode(listNode.val);
                    output = newListNode;
                }
                else
                {
                    newListNode.next = new ListNode(listNode.next.val);
                    newListNode = newListNode.next;
                    listNode = listNode.next;
                }
            }

            return output;
        }
    }
}
