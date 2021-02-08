using System;
using System.Collections.Generic;
using System.Text;

namespace TreeVariants
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        private BinaryTreeNode<T> _leftChild;
        private BinaryTreeNode<T> _rightChild;

        public BinaryTreeNode()
        {

        }

        public BinaryTreeNode(T item)
        {
            _item = item;
        }

        public void AddLeftChild(T item)
        {
            if(_leftChild == null)
            {
                _leftChild = new BinaryTreeNode<T>(item);
            }
        }

        public void AddRightChild(T item)
        {
            if(_rightChild == null)
            {
                _rightChild = new BinaryTreeNode<T>(item);
            }
        }

        public BinaryTreeNode<T> LeftChild
        {
            get
            {
                return _leftChild;
            }
        }

        public BinaryTreeNode<T> RightChild
        {
            get
            {
                return _rightChild;
            }
        }
    }
}
