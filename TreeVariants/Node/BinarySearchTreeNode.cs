using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeVariants.Node
{
    public class BinarySearchTreeNode : TreeNode<int>
    {
        protected BinarySearchTreeNode _leftChild;
        protected BinarySearchTreeNode _rightChild;

        public BinarySearchTreeNode()
        {

        }

        public BinarySearchTreeNode(int item)
        {
            _item = item;
        }

        public virtual void Insert(int item)
        {
            // If item is less than node item
            if(Item > item)
            {
                // If left child is null
                if(LeftChild == null)
                {
                    // Set a new Left child node with item as property
                    _leftChild = new BinarySearchTreeNode(item);
                }

                else
                {
                    // Insert item into left child
                    LeftChild.Insert(item);
                }
            }

            // If item is greater than item in node
            else if(Item < item)
            {
                // If right child is null
                if(RightChild == null)
                {
                    // Set a new Right child< node with item as property
                    _rightChild = new BinarySearchTreeNode(item);
                }

                else
                {
                    // Insert item into right child
                    RightChild.Insert(item);
                }
            }
        }

        public virtual BinarySearchTreeNode LeftChild
        {
            get
            {
                return _leftChild;
            }
        }

        public virtual BinarySearchTreeNode RightChild
        {
            get
            {
                return _rightChild;
            }
        }
    }
}