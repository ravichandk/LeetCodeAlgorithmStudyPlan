namespace LeetCode75.Day03
{
    public class C002_PalindromeLinkedList
    {
        public static void Solution()
        {
            var isPalindrome = IsPalindrome(ArrayToListNode.ConvertToListNode(new[] { 1, 2}));
            var x = isPalindrome;
        }

        private static bool IsPalindrome(ListNode head)
        {
            if (head == null) return false;

            var array = new int[100000];

            var index = 0;
            var listNode = head;

            while(listNode != null)
            {
                array[index] = listNode.val;
                listNode = listNode.next;
                index++;
            }

            var arrayLength = index;

            var startIndex = index / 2 - 1;
            var midIndex = index % 2 == 0 ? startIndex + 1 : startIndex + 2;
            var j = 0;
            var isPalindrome = true;

            for (var i = startIndex; i >= 0; i--)
            {
                if (array[i] != array[midIndex + j])
                {
                    isPalindrome = false;
                    break;
                }
                j++;
            }

            return isPalindrome;
        }
    }
}
