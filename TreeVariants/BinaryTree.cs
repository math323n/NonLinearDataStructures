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

        public int GetHeight(BinaryTreeNode<T> root)
        {
            if(root == null)
            {
                return 0;
            }
            else
            {
                int leftHeight = GetHeight(root.LeftChild) + 1;
                int rightHeight = GetHeight(root.RightChild) + 1;
                if(leftHeight > rightHeight)
                {
                    return leftHeight;
                }
                else
                {
                    return rightHeight;
                }
            }
        }

        public string ToStringLevel(int level, BinaryTreeNode<T> root)
        {
            if(root == null)
            {
                return null;
            }
            else
            {
                string left = "";
                string right = "";
                for(int i = 0; i < level; i++)
                {
                    left = ToStringLevel(level, root.LeftChild);
                    right = ToStringLevel(level, root.RightChild);
                }
                return $"level {level}:  Left: {left}, right: {right} \n";
            }
        }

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
    }
}
