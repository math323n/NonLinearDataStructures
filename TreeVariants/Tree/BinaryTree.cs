using System;
using System.Collections.Generic;
using System.Text;

namespace TreeVariants
{
    public class BinaryTree<T> : IBinaryTree<T>
    {
        private BinaryTreeNode<T> _root;

        public BinaryTree(BinaryTreeNode<T> root)
        {
            _root = root;
        }

        public BinaryTreeNode<T> Root
        {
            get
            {
                return _root;
            }
        }

        public int Count
        {
            get
            {
                return GetCount(_root, 1);
            }
        }

        // Code to count number of elements in the structure
        public int GetCount(BinaryTreeNode<T> node, int count)
        {
            if(node.LeftChild != null && node.RightChild != null)
            {
                count += GetCount(node.LeftChild, count) + GetCount(node.RightChild, count);
            }
            else if(node.LeftChild != null && node.RightChild == null)
            {
                count += GetCount(node.LeftChild, count);
            }
            else if(node.LeftChild == null && node.RightChild != null)
            {
                count += GetCount(node.RightChild, count);
            }
            return count;
        }

        public void AddLeftChildTo(BinaryTreeNode<T> parent, T leftChildItem)
        {
            parent.AddLeftChild(leftChildItem);
        }

        public void AddRightChildTo(BinaryTreeNode<T> parent, T rightChildItem)
        {
            parent.AddRightChild(rightChildItem);
        }

        // Method of knowing the total height from Root to lowest Node
        public int GetHeight(BinaryTreeNode<T> root)
        {
            // If root = null return 0
            if(root == null)
            {
                return 0;
            }
            else
            {
                // Set height of left TreeNode to GetHeight
                int leftHeight = GetHeight(root.LeftChild) + 1;

                // Set height of right TreeNode to GetHeight
                int rightHeight = GetHeight(root.RightChild) + 1;

                // Return height of lowest TreeNode + 1
                if(leftHeight > rightHeight)
                {
                    return leftHeight;
                }
                else
                {
                    // Else return the right node
                    return rightHeight;
                }
            }
        }

        // Function to construct string from binary tree level
        public string ToStringLevel(int level, BinaryTreeNode<T> root)
        {
            if(root == null)
            {
                return null;
            }
            else
            {
                BinaryTreeNode<T> left = root.LeftChild;
                BinaryTreeNode<T> right = root.RightChild;
                for(int i = 0; i < level; i++)
                {
                    left = FindChildren(left);
                    right = FindChildren(right);
                }

                return $"level {level}:  Left: {left}, right: {right} \n";
            }
        }

        // Method of findind children nodes
        public BinaryTreeNode<T> FindChildren(BinaryTreeNode<T> root)
        {
            if(root != null)
            {
                if(root.LeftChild != null && root.RightChild != null)
                {
                    FindChildren(root.LeftChild);
                    FindChildren(root.RightChild);
                }

                if(root.LeftChild != null)
                {
                    return root.LeftChild;
                }

                if(root.RightChild != null)
                {
                    return root.RightChild;
                }

                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        
        // Function to print string from binary tree
        public string ToStringLevelOrder()
        {
            int length = GetHeight(Root);
            string tree = "";
            for(int i = 0; i < length; i++)
            {
                tree += ToStringLevel(i, Root);
            }
            return tree;
        }

        public string PostOrder(BinaryTreeNode<T> node)
        {
            string toReturn = "";
            if(node != null)
            {
                toReturn += PostOrder(node.LeftChild);
                toReturn += PostOrder(node.RightChild);
                toReturn += node + " ";
            }

            return toReturn;
        }

        public string InOrder(BinaryTreeNode<T> node)
        {
            string toReturn = "";
            if(node.LeftChild != null)
            {
                toReturn += InOrder(node.LeftChild);
            }

            toReturn += node + " ";

            if(node.RightChild != null)
            {
                toReturn += InOrder(node.RightChild);
            }

            return toReturn;
        }

        public string PreOrder(BinaryTreeNode<T> node)
        {
            string toReturn = "";

            if(node != null)
            {
                toReturn += node + " ";
                toReturn += PreOrder(node.LeftChild);
                toReturn += PreOrder(node.RightChild);
            }

            return toReturn;
        }





    }
}