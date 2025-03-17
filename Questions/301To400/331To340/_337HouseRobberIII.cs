using BaseClasses.BinaryTrees;

namespace Questions._301To400._331To340
{
    public static class _337HouseRobberIII
    {
        #region Description
        /// <summary>
        /// The thief has found himself a new place for his thievery again. There is only one entrance to this area, called root.
        //Besides the root, each house has one and only one parent house.After a tour, the smart thief realized that all houses in this place form a binary tree.It will automatically contact the police if two directly-linked houses were broken into on the same night.
        //Given the root of the binary tree, return the maximum amount of money the thief can rob without alerting the police.
        //The number of nodes in the tree is in the range[1, 104].
        //0 <= Node.val <= 104
        /// </summary>
        #endregion
        public static int Rob(TreeNode? root)
        {
            (var withRoot, var withoutRoot) = DepthFirstSearch(root);
            return Math.Max(withRoot, withoutRoot);
        }

        public static (int, int) DepthFirstSearch(TreeNode node)
        {
            if (node == null)
                return (0, 0);

            (var leftWithRoot, var leftWithoutRoot) = DepthFirstSearch(node.left);
            (var rightWithRoot, var rightWithoutRoot) = DepthFirstSearch(node.right);

            var withCurrentRoot = node.val + leftWithoutRoot + rightWithoutRoot;
            var withoutCurrentRoot = Math.Max(leftWithRoot, leftWithoutRoot) + Math.Max(rightWithRoot, rightWithoutRoot);

            return (withCurrentRoot, withoutCurrentRoot);
        }
    }
}