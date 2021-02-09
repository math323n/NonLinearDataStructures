using System;
using TreeVariants;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            BinaryTreeNode<string> root = new("root");
            BinaryTree<string> tree = new(root);
            tree.AddLeftChildTo(root, "sdas");
            tree.AddRightChildTo(root, "fds");
            tree.AddLeftChildTo(root.LeftChild, "fdsfs");
            tree.AddRightChildTo(root.RightChild, "fhguh");
            tree.AddRightChildTo(root.RightChild.RightChild, "fdsf");
            tree.AddRightChildTo(root.RightChild.RightChild, "fds");

            Console.WriteLine(tree.ToStringLevelOrder());
            
        }
    }
}