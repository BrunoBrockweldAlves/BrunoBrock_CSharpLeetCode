using BaseClasses.BinaryTrees;

namespace Tests.Models.TestData.Trees
{
    public class TreeNodeInputIntOutput
    {
        public int?[] Input { get; set; }
        public TreeNode? Root { get; set; }
        public int Output { get; set; }

        public TreeNodeInputIntOutput(int?[] input, int output) 
        {
            Input = input;
            Root = input.ToTreeNode();
            Output = output;
        }

        public TreeNodeInputIntOutput(TreeNode? input, int output) 
        {
            Root = input;
            Input = input.ToArray();
            Output = output;
        }
    }
}
