namespace Questions._601To700._691To700
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

    public class _700SearchInABinarySearchTree
    {
        public TreeNode? SearchBST(TreeNode? root, int val)
        {
            // Add to beat memory, remove to beat time
            // GC.Collect();
            if (root is null)
                return null;

            if (root.val == val)
                return root;

            if (root.val > val)
                return SearchBST(root.left, val);

            return SearchBST(root.right, val);
        }
    }
}