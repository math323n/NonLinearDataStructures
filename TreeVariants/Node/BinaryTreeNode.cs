using System;
using System.Collections.Generic;
using System.Text;

namespace TreeVariants
{

    public class BinaryTreeNode<T> : TreeNode<T> where T : IComparable<T>
    {
        protected BinaryTreeNode<T> _leftChild;
        protected BinaryTreeNode<T> _rightChild;
        protected BinaryTreeNode<T> _parent;

        public BinaryTreeNode()
        {

        }

        public BinaryTreeNode(T item)
        {
            _item = item;
        }

        public BinaryTreeNode(T item, BinaryTreeNode<T> parent)
        {
            _item = item;
            _parent = parent;
        }

        public virtual void AddLeftChild(T item)
        {
            if(_leftChild == null)
            {
                _leftChild = new BinaryTreeNode<T>(item);
            }
        }

        public virtual void AddRightChild(T item)
        {
            if(_rightChild == null)
            {
                _rightChild = new BinaryTreeNode<T>(item);
            }
        }

        public virtual BinaryTreeNode<T> LeftChild
        {
            get
            {
                return _leftChild;
            }
            set
            {
                _leftChild = value;
            }
        }

        public virtual BinaryTreeNode<T> RightChild
        {
            get
            {
                return _rightChild;
            }
            set
            {
                _rightChild = value;
            }
        }

        public virtual new BinaryTreeNode<T> Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }
    }
}