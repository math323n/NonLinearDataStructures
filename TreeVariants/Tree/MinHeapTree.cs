using System;
using System.Collections.Generic;


namespace TreeVariants.Tree
{
    public class MinHeapTree<T> : BinaryTree<T> where T : IComparable<T>
    {
        protected List<BinaryTreeNode<T>> items;
        protected int count;

        public MinHeapTree()
        {
            items = new List<BinaryTreeNode<T>>() { null };
        }

        public MinHeapTree(BinaryTreeNode<T> root)
        {
            items = new List<BinaryTreeNode<T>>() { root };
        }

        public List<BinaryTreeNode<T>> Items
        {
            get
            {
                return items;
            }
        }

        public override BinaryTreeNode<T> Root
        {
            get
            {
                return items[0];
            }
        }

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public virtual void Insert(BinaryTreeNode<T> node)
        {
            if(Root == null)
            {
                Items[0] = node;
            }
            else
            {
                AddToHeap(node, Root);
            }
        }

        public virtual BinaryTreeNode<T> Extract(int index)
        {
            if(index <= count)
            {
                BinaryTreeNode<T> extractedNode = items[index];
                ReOrderOnExtraction(extractedNode);
                return extractedNode;
            }
            else
            {
                return null;
            }
        }

        public virtual BinaryTreeNode<T> Search(int index)
        {
            if(index <= count)
            {
                return items[index];
            }
            else
            {
                return null;
            }
        }

        public virtual void Delete()
        {
            Items.RemoveAll(null!);
        }

        public void ReOrderOnExtraction(BinaryTreeNode<T> node)
        {
            if(node.LeftChild != null && node.RightChild != null)
            {
                if(node.LeftChild.Item.CompareTo(node.RightChild.Item) == 1)
                {
                    node.Item = node.LeftChild.Item;
                    ReOrderOnExtraction(node.LeftChild);
                }
                else
                {
                    node.Item = node.RightChild.Item;
                    ReOrderOnExtraction(node.RightChild);
                }
            }

            else if(node.LeftChild != null && node.RightChild == null)
            {
                node.Item = node.LeftChild.Item;
                items.Remove(node.LeftChild);
            }

            else
            {
                return;
            }
        }

        public void ReOrderOnInsertion(BinaryTreeNode<T> node, BinaryTreeNode<T> root)
        {
            if(root.Item.CompareTo(node.Item) == 1)
            {
                (root.Item, node.Item) = (node.Item, root.Item);
                ReOrderOnInsertion(node, node.Parent);
            }
        }

        public void AddToHeap(BinaryTreeNode<T> node, BinaryTreeNode<T> root)
        {
            if(root.Item.CompareTo(node.Item) == -1)
            {
                if(root.LeftChild == null)
                {
                    Items.Add(node);
                    root.LeftChild = node;
                    node.Parent = root;
                }

                else if(root.RightChild == null)
                {
                    Items.Add(node);
                    root.RightChild = node;
                    node.Parent = root;
                }
                else
                {
                    if(root.LeftChild.LeftChild == null || root.LeftChild.RightChild == null)
                    {
                        AddToHeap(node, root.LeftChild);
                    }
                    else if(root.RightChild.LeftChild == null || root.RightChild.RightChild == null)
                    {
                        AddToHeap(node, root.RightChild);
                    }
                    else
                    {
                        AddToHeap(node, root.LeftChild.LeftChild);
                    }
                }
            }
            else
            {
                items.Add(node);
                node.Parent = root;
                ReOrderOnInsertion(node, root);
            }
        }
    }
}