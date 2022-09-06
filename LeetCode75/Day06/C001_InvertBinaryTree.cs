namespace LeetCode75.Day06
{
    public class C001_InvertBinaryTree
    {
        public static void Solution()
        {
            var treeNode = ArrayToTreeNode.Convert(new[] { 4, 2, 7, 1, 3, 6, 9 });

            var invertedTree = InvertTree(treeNode);
            var x = invertedTree;
        }

        private static TreeNode InvertTree(TreeNode root)
        {
            InvertTreeNode(root);

            return root;
        }

        private static void InvertTreeNode(TreeNode node)
        {
            if (node == null) return;

            var temp = node.left;
            node.left = node.right;
            node.right = temp;

            InvertTreeNode(node.left);
            InvertTreeNode(node.right);
        }
    }

}
