using System.Collections.Generic;

namespace LeetCode75
{
    public class ArrayToTreeNode
    {
        public static TreeNode Convert(int?[] data)
        {
            var tree = BuildTree(data);
            return tree;
        }

        private static TreeNode BuildTree(int?[] data)
        {
            if (data.Length <= 0) return null;

            var root = new TreeNode(data[0]);

            var index = 1;
            var currentNodeList = new List<TreeNode>();
            currentNodeList.Add(root);

            while (index < data.Length)
            {
                var nodesToBeProcessed = new List<TreeNode>();

                foreach(var node in currentNodeList)
                {
                    if(data[index] != null)
                    {
                        node.left = new TreeNode(data[index]);
                        nodesToBeProcessed.Add(node.left);
                    }
                    index++;

                    if (index >= data.Length)
                        break;

                    if(data[index] != null)
                    {
                        node.right = new TreeNode(data[index]);
                        nodesToBeProcessed.Add(node.right);
                    }
                    index++;

                    if (index >= data.Length)
                        break;
                }

                if (index >= data.Length)
                    break;

                currentNodeList = nodesToBeProcessed;
            }

            return root;
        }

        //private static TreeNode BuildTree(int?[] data, int i)
        //{
        //    if (i >= data.Length) return null;
        //    if (data[i] == null) return null;

        //    TreeNode next = new TreeNode(data[i]);
        //    var leftNode = BuildTree(data, 2 * i + 1);

        //    if (leftNode != null)
        //    {
        //        next.left = BuildTree(data, 2 * i + 1);
        //        next.right = BuildTree(data, 2 * i + 2);
        //    }
        //    else
        //    {
        //        next.right = BuildTree(data, 2 * i + 1);
        //    }

        //    //TreeNode next = new TreeNode(data[i]);
        //    //i++;

        //    //TreeNode leftNode = null;
        //    //TreeNode rightNode = null;

        //    //if (i > 0)
        //    //{
        //    //    next.left = new TreeNode(data[i]);
        //    //    leftNode = next.left;
        //    //    i++;
        //    //}

        //    //if(i > 1)
        //    //{
        //    //    next.right = new TreeNode(data[i]);
        //    //    rightNode = next.right;
        //    //    i++;
        //    //}

        //    //while (i < data.Length)
        //    //{
        //    //    if(data[i] != null)
        //    //    {
        //    //        next.left = new TreeNode(data[i]);
        //    //        i++;
        //    //    }

        //    //    if (i >= data.Length) break;
        //    //}

        //    return next;
        //}
    }


    public class TreeNode
    {
        public int? val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int? val, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
