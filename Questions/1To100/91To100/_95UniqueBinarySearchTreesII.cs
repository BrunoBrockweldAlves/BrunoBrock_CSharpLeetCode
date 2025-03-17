using BaseClasses.BinaryTrees;

namespace Questions._1To100._91To100
{
    public class _95UniqueBinarySearchTreesII
    {
        // TODO
        // Need to finish this exercise.
        public IList<TreeNode> GenerateTrees(int n)
        {
            throw new NotImplementedException();
            var result = new List<TreeNode>();
            for (int i = n; i > 0; i--)
            {

            }

            // TODO remove
            return default;

            void BuildAllCombinations(int value)
            {
                // Create only lefts
                for (int i = value; i > 0; i--)
                {
                    var left = new TreeNode();
                    new TreeNode(value);
                }

                // Create only rights
                for (int i = value; i > 0; i--)
                {
                    new TreeNode(i);
                }

                // Create LeftRights
                for (int i = value; i > 0; i--)
                {
                    new TreeNode(i);
                }
            }

        }
    }
}
