using BaseClasses.BinaryTrees;

namespace Questions._601To700._691To700
{
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