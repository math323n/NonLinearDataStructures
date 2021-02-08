using System;
using System.Collections.Generic;

namespace TreeVariants
{
    public class TreeNode<T> : Node<T>
    {
        private TreeNode<T> _parent;

        public TreeNode()
        {

        }

        public TreeNode(T item)
        {
            _item = item;
        }

        public TreeNode(T item, TreeNode<T> parent)
        {
            _parent = parent;
            _item = item;
        }

        public TreeNode(TreeNode<T> parent)
        {
            _parent = parent;
        }

        public TreeNode<T> Parent
        {
            get
            {
                return _parent;
            }
        }
    }
}