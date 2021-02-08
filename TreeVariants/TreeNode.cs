using System;
using System.Collections.Generic;

namespace TreeVariants
{
    /// <summary>
    /// Generic class to specify the type of data to be stored in a node.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TreeNode<T>
    {
        // Data to be stored
        public T Data { get; set; }

        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; }
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while(current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
}