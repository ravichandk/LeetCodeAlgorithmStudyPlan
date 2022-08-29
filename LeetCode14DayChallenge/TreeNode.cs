namespace LeetCode14DayChallenge
{
    public class TreeNode
    {
        public int val;

        public TreeNode left;

        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class ArrayToTreeNode
    {
        public static TreeNode Convert(int[] array)
        {
            var index = 0;

            while (index < array.Length)
            {


                index++;
            }

            return null;
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

    public class ArrayToListNode
    {
        public static ListNode Convert(int[] array)
        {
            var listNode = new ListNode(array[0], new ListNode());
            var nextNode = listNode.next;

            for (var i = 1; i <= array.Length - 1; i++)
            {
                nextNode.val = array[i];

                if (i == array.Length - 1) break;

                nextNode.next = new ListNode();
                nextNode = nextNode.next;
            }

            return listNode;
        }
    }
}
