using System;
using System.Collections.Generic;
using TreeVariants;
using TreeVariants.Node;
using TreeVariants.Tree;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            BinaryTreeNode<int> root = new(1);
            BinaryTree<int> tree = new(root);
            tree.AddLeftChildTo(root, 2);
            tree.AddRightChildTo(root, 3);
            tree.AddLeftChildTo(root.LeftChild, 532);
            tree.AddRightChildTo(root.RightChild, 1);
            tree.AddRightChildTo(root.RightChild.RightChild, 89);
            tree.AddRightChildTo(root.RightChild.RightChild, 12);

            Console.WriteLine(tree.ToStringLevelOrder());


         


            //// Traverse left subtree, traverse right subtree, visit the root.
            Console.WriteLine(tree.PostOrder(root));

            //// Visit the root, traverse left subtree, traverse right subtree.
           Console.WriteLine(tree.PreOrder(root));

            //// Traverse left subtree, visit the root, traverse right subtree.
            Console.WriteLine(tree.InOrder(root));

            // Create new Binary Search Tree
            BinarySearchTree<int> searchTree = new();
            searchTree.Insert(2);
            searchTree.Insert(1);
            searchTree.Insert(0);
            searchTree.Insert(3);
            searchTree.InsertMany(new List<int> {4, 45, 98 });

            // print out tree in order
            Console.WriteLine(searchTree.InOrder(searchTree.Root));
            // Print a very fancy tree.
            searchTree.Root.Print();

            tree.Root.Print();


            // Min Heap Tree
            MinHeapTree<int> minHeap = new(new BinaryTreeNode<int>(5));
            minHeap.Insert(new BinaryTreeNode<int>(2));
            minHeap.Insert(new BinaryTreeNode<int>(13));
            minHeap.Insert(new BinaryTreeNode<int>(28));
            minHeap.Insert(new BinaryTreeNode<int>(30));
            minHeap.Insert(new BinaryTreeNode<int>(12));
            minHeap.Insert(new BinaryTreeNode<int>(14));
            minHeap.Insert(new BinaryTreeNode<int>(25));
            minHeap.Insert(new BinaryTreeNode<int>(13));
            minHeap.Insert(new BinaryTreeNode<int>(12));
            minHeap.Insert(new BinaryTreeNode<int>(18));
            minHeap.Insert(new BinaryTreeNode<int>(4));

            MaxHeapTree<int> MaxHeap = new(new BinaryTreeNode<int>(5));
            MaxHeap.Insert(new BinaryTreeNode<int>(2));




        }

    }
}