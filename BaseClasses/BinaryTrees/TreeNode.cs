namespace BaseClasses.BinaryTrees
{
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;
    }

    public static class TreeNodeExtensions
    {
        public static int?[] ToArray(this TreeNode? root)
        {
            if (root == null)
                return Array.Empty<int?>();

            List<int?> result = new List<int?>();
            Queue<TreeNode?> queue = new Queue<TreeNode?>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode? node = queue.Dequeue();
                if (node != null)
                {
                    result.Add(node.val);
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
                else
                {
                    result.Add(null);
                }
            }

            // Trim trailing nulls
            int lastNonNull = result.Count - 1;
            while (lastNonNull >= 0 && result[lastNonNull] == null)
            {
                lastNonNull--;
            }

            return result.GetRange(0, lastNonNull + 1).ToArray();
        }

        public static TreeNode? ToTreeNode(this int?[] arr)
        {
            if (arr.Length == 0 || arr[0] == null)
                return null;

            TreeNode root = new TreeNode((int)arr[0]!);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int i = 1;
            while (i < arr.Length)
            {
                TreeNode current = queue.Dequeue();

                if (i < arr.Length && arr[i] != null)
                {
                    current.left = new TreeNode((int)arr[i]!);
                    queue.Enqueue(current.left);
                }
                i++;

                if (i < arr.Length && arr[i] != null)
                {
                    current.right = new TreeNode((int)arr[i]!);
                    queue.Enqueue(current.right);
                }
                i++;
            }

            return root;
        }
    }
}
