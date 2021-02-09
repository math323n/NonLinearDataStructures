using System;

namespace TreeVariants
{
    public interface IBinaryTree<T> : INonLinearDataStructure<T>
    {
        public BinaryTreeNode<T> Root
        {
            get;
        }

        public int GetHeight(BinaryTreeNode<T> root);

        public string ToStringLevel(int level, BinaryTreeNode<T> root);

        public string ToStringLevelOrder();

        public void AddLeftChildTo(BinaryTreeNode<T> parent, T leftChildItem);

        public void AddRightChildTo(BinaryTreeNode<T> parent, T rightChildItem);
    }
}       