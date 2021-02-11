﻿using System;
using System.Collections.Generic;
using TreeVariants;
using TreeVariants.Node;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //BinaryTreeNode<string> root = new("root");
            //BinaryTree<string> tree = new(root);
            //tree.AddLeftChildTo(root, "sdas");
            //tree.AddRightChildTo(root, "fds");
            //tree.AddLeftChildTo(root.LeftChild, "fdsfs");
            //tree.AddRightChildTo(root.RightChild, "fhguh");
            //tree.AddRightChildTo(root.RightChild.RightChild, "fdsf");
            //tree.AddRightChildTo(root.RightChild.RightChild, "fds");

            //Console.WriteLine(tree.ToStringLevelOrder());

            //// Traverse left subtree, traverse right subtree, visit the root.
            //Console.WriteLine(tree.PostOrder(root));

            //// Visit the root, traverse left subtree, traverse right subtree.
            //Console.WriteLine(tree.PreOrder(root));

            //// Traverse left subtree, visit the root, traverse right subtree.
            //Console.WriteLine(tree.InOrder(root));

            // Create new Binary Search Tree
            BinarySearchTree searchTree = new();
            searchTree.Insert(2);
            searchTree.Insert(1);
            searchTree.Insert(3);
            searchTree.InsertMany(new List<int> {4, 45, 98 });

            // print out tree in order
            //Console.WriteLine(searchTree.InOrder(searchTree.Root));
            // Print a very fancy tree.
            searchTree.Root.Print();
    
        }

    }
}