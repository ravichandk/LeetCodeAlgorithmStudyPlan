namespace LeetCode75
{
    public class ArrayToListNode
    {
        public static ListNode ConvertToListNode(int[] array)
        {
            var output = new ListNode(array[0]);
            var listNode = output;

            for(var i = 1; i < array.Length; i++)
            {
                listNode.next = new ListNode(array[i]);
                listNode = listNode.next;
            }

            return output;
        }
    }

    public class ListNode
    {
        public ListNode(int value, ListNode next = null)
        {
            val = value;
            this.next = next;
        }

        public int val { get; }

        public ListNode next { get; set; }
    }
}
