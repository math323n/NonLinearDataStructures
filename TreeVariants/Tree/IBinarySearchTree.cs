using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeVariants.Node;

namespace TreeVariants.Tree
{
    public interface IBinarySearchTree<T> : INonLinearDataStructure<T>
    {

        public BinarySearchTreeNode Root
        {
            get;
        }

        public void Insert(int item);

     
    }
}
