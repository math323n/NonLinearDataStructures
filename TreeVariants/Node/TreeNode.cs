using System;
using System.Collections.Generic;

namespace TreeVariants
{
    public class TreeNode<T> : Node<T>
    {
        private TreeNode<T> _parent;

        // Constructor for empty TreeNode
        public TreeNode()
        {

        }

        // Constructor for TreeNode without parent
        public TreeNode(T item)
        {
            _item = item;
        }

        // Constructor for complete TreeNode
        public TreeNode(T item, TreeNode<T> parent)
        {
            _parent = parent;
            _item = item;
        }

        // Constructor for TreeNode without data
        public TreeNode(TreeNode<T> parent)
        {
            _parent = parent;
        }

        // TreeNode parent
        public TreeNode<T> Parent
        {
            get
            {
                return _parent;
            }
        }
    }
}