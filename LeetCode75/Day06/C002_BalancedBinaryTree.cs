namespace LeetCode75.Day06
{
    public class C002_BalancedBinaryTree
    {
        private static bool _isNodeBalanced = true;

        public static void Solution()
        {
            //var treeNode = ArrayToTreeNode.Convert(new int?[] { 3, 9, 20, null, null, 15, 7 });
            //var treeNode = ArrayToTreeNode.Convert(new int?[] { 1, 2, 2, 3, 3, null, null, 4, 4 });
            var treeNode = ArrayToTreeNode.Convert(new int?[] { 1, 2 });
            //var treeNode = ArrayToTreeNode.Convert(new int?[] { 1 });
            //var treeNode = ArrayToTreeNode.Convert(new int?[] { 1, null, 2, null, 3 });

            var isbalanced = IsBalanced(treeNode);
            var x = isbalanced;
        }

        private static bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            if (root.left == null && root.right == null) return true;

            NodeDepth(root);

            return _isNodeBalanced;
        }

        private static int NodeDepth(TreeNode node)
        {
            if (node == null)
                return 0;
            if (node.left == null && node.right == null)
                return 0;
            
            var leftNodeDepth = (node.left != null ? 1 : 0 ) + NodeDepth(node.left);
            var rightNodeDepth = (node.right != null ? 1 : 0) + NodeDepth(node.right);

            var nodeDepth = (leftNodeDepth > rightNodeDepth) ? leftNodeDepth : rightNodeDepth;

            if (System.Math.Abs(leftNodeDepth - rightNodeDepth) > 1)
            {
                _isNodeBalanced = false;
                return nodeDepth;
            }

            return nodeDepth;
        }

        //private static int _nodeDepth;

        //private static bool _isNodeBalanced = true;

        //public bool IsBalanced(TreeNode root)
        //{
        //    if (root == null) return true;
        //    if (root.left == null || root.right == null) return true;


        //    var leftNodeDepth = NodeDepth(root.left);
        //    var rightNodeDepth = NodeDepth(root.right);

        //    if (!_isNodeBalanced) return false;

        //    _isNodeBalanced = (leftNodeDepth - rightNodeDepth) <= 1;

        //    return _isNodeBalanced;
        //}

        //private static int NodeDepth(TreeNode node)
        //{
        //    if (node.left == null && node.right == null)
        //        return 0;

        //    var leftNodeDepth = NodeDepth(node.left);
        //    var rightNodeDepth = NodeDepth(node.right);

        //    var nodeDepth = 0;
        //    if (leftNodeDepth == 0 && rightNodeDepth == 0)
        //        nodeDepth = 1;
        //    else if (leftNodeDepth > 0 || rightNodeDepth > 0)
        //        nodeDepth = 1;

        //    _nodeDepth = _nodeDepth + nodeDepth;

        //    if (leftNodeDepth - rightNodeDepth > 1)
        //    {
        //        _isNodeBalanced = false;
        //    }

        //    return _nodeDepth;
        //}

        //private static int NodeDepth(TreeNode node)
        //{
        //    if (node == null)
        //        return 0;
        //    if (node.left == null && node.right == null)
        //        return 1;

        //    var leftNodeDepth = NodeDepth(node.left);
        //    var rightNodeDepth = NodeDepth(node.right);

        //    //var nodeDepth = 0;
        //    //if (leftNodeDepth == 1 && rightNodeDepth == 1)
        //    //    nodeDepth = 1;
        //    //else if (leftNodeDepth > 0 || rightNodeDepth > 0)
        //    //    nodeDepth = 1;

        //    //_nodeDepth = _nodeDepth + nodeDepth;

        //    //if(leftNodeDepth - rightNodeDepth > 1)
        //    //{
        //    //    _isNodeBalanced = false;
        //    //}

        //    return _nodeDepth;
        //}
    }

}
