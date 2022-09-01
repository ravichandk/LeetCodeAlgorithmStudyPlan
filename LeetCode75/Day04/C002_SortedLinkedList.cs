namespace LeetCode75.Day04
{
    public class C002_SortedLinkedList
    {
        public static void Solution()
        {
            var array = new[] { 4, 2, 1, 3};

            var head = ArrayToListNode.ConvertToListNode(array);
            var sortedListNode = SortList(head);
            var x = sortedListNode;
        }

        private static ListNode SortList(ListNode head)
        {
            if (head == null) return null;

            var listNode = head;
            var array = new System.Collections.Generic.List<int>();

            while (true)
            {
                array.Add(listNode.val);

                if (listNode.next == null) break;
                listNode = listNode.next;
            }

            array.Sort();

            var newListNode = new ListNode(array[0]);
            listNode = newListNode;

            for (var i = 1; i < array.Count; i++)
            {
                listNode.next = new ListNode(array[i]);
                listNode = listNode.next;
            }

            return newListNode;
        }
    }
}
