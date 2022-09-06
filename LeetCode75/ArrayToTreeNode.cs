namespace LeetCode75
{
    public class ArrayToTreeNode
    {
        public static TreeNode Convert(int[] data)
        {
            return BuildTree(data, 0);
        }

        private static TreeNode BuildTree(int[] data, int i)
        {
            if (i >= data.Length) return null;
            TreeNode next = new TreeNode(data[i]);
            next.left = BuildTree(data, 2 * i + 1);
            next.right = BuildTree(data, 2 * i + 2);

            return next;
        }
    }


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
}
