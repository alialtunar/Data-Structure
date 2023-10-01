using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.trees.binarytree
{
    public class BinaryTreeNode
    {
        public int Data;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;

        public BinaryTreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

    }
}
