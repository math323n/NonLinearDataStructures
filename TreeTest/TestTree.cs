using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeVariants;

namespace TreeTest
{
    [TestClass]
    public class TreeTest
    {
        [TestMethod]
        public void TestCreation()
        {
            BinaryTreeNode<int> root = new(2);
            BinaryTree<int> tree = new(root);
        }


        [TestMethod]
        public void TestChildAdditions()
        {
            BinaryTreeNode<int> root = new(2);
            BinaryTree<int> tree = new(root);
            tree.AddLeftChildTo(root, 1);
            tree.AddRightChildTo(root, 1);
            tree.AddLeftChildTo(root.LeftChild, 1);
            tree.AddRightChildTo(root.RightChild, 1);
            tree.AddRightChildTo(root.RightChild.RightChild, 1);
        }
      

        [TestMethod]
        public void TestCount()
        {
            BinaryTreeNode<int> root = new(2);
            BinaryTree<int> tree = new(root);
            tree.AddLeftChildTo(root, 1);
            tree.AddRightChildTo(root, 1);
            tree.AddLeftChildTo(root.LeftChild, 1);
            tree.AddRightChildTo(root.RightChild, 1);
            tree.AddRightChildTo(root.RightChild.RightChild, 1);
            Assert.IsTrue(tree.Count == 6);

        }
       
    }
}
