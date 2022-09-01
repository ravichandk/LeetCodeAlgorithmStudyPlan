namespace LeetCode75.Day04
{
    public class C001_OddEvenLinkedList
    {
        public static void Solution()
        {
            var array = new[] { 1, 2, 3, 4, 5 };

            var head = ArrayToListNode.ConvertToListNode(array);
            var oddEvenListNode = OddEvenList(head);
            var x = oddEvenListNode;
        }

        private static ListNode OddEvenList(ListNode head)
        {
            if (head == null) return null;

            var index = 1;
            var listNode = head;
            var oddArray = new System.Collections.Generic.List<int>();
            var evenArray = new System.Collections.Generic.List<int>();

            while(true)
            {
                if(index % 2 == 1)
                {
                    oddArray.Add(listNode.val);
                }
                else
                {
                    evenArray.Add(listNode.val);
                }

                if (listNode.next == null) break;

                index++;
                listNode = listNode.next;
            }

            var newListNode = new ListNode(oddArray[0]);
            listNode = newListNode;

            for(var i = 1; i < oddArray.Count; i++)
            {
                listNode.next = new ListNode(oddArray[i]);
                listNode = listNode.next;
            }

            for (var i = 0; i < evenArray.Count; i++)
            {
                listNode.next = new ListNode(evenArray[i]);
                listNode = listNode.next;
            }

            return newListNode;
        }
    }
}
