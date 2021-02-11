using System.Collections.Generic;
using TreeVariants.Node;
using TreeVariants.Tree;

namespace TreeVariants
{
    public class BinarySearchTree : IBinarySearchTree<int>
    {
        protected BinarySearchTreeNode _root;

        public BinarySearchTree()
        {

        }

        public BinarySearchTree(BinarySearchTreeNode root)
        {
            _root = root;
        }

        public virtual BinarySearchTreeNode Root
        {
            get
            {
                return _root;
            }
        }

        public virtual int Count
        {
            get
            {
                return GetCount(Root, 0);
            }
        }

        public virtual int GetCount(BinarySearchTreeNode node, int count)
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
        public void Print()
        {
            Root.Print();
        }

        public virtual void Insert(int item)
        {
            // Check if the root is present or not, if not then it’s the first element.
            if(_root == null)
            {
                // Then assign the item as Root.
                _root = new BinarySearchTreeNode(item);
            }
            else
            {
                // If the root is present then we need to find where to insert it.
                Root.Insert(item);
            }
        }

        public virtual void InsertMany(List<int> nodes)
        {
            foreach(int node in nodes)
            {
                Insert(node);
            }
        }

        public virtual string InOrder(BinarySearchTreeNode node)
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
    }
}