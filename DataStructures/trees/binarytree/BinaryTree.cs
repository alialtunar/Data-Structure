using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.trees.binarytree
{
   public class BinaryTree
    {
        private BinaryTreeNode root;

 
        public BinaryTree()
        {
            root = null;  
        }
        public void Insert(int data)
        {
            root = InsertRec(root, data);
        }

        // Rekürsif düğüm ekleme metodu
        private BinaryTreeNode InsertRec(BinaryTreeNode root, int data)
        {
            if (root == null)
            {
                return new BinaryTreeNode(data);
            }

            if (data < root.Data)
            {
                root.Left = InsertRec(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = InsertRec(root.Right, data);
            }

            return root;
        }

        // Ağacı LNR (In-Order) sırasında dolaşarak yazdırmak için genel metod
        public void InOrderTraversal()
        {
            InOrderTraversal(root);
        }

        // Rekürsif LNR (In-Order) sırasında dolaşma metodu
        private void InOrderTraversal(BinaryTreeNode root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InOrderTraversal(root.Right);
            }
        }

        // Belirli bir değeri aramak için genel metod
        public bool Search(int data)
        {
            return SearchRec(root, data);
        }

        // Rekürsif arama metodu
        private bool SearchRec(BinaryTreeNode root, int data)
        {
            if (root == null)
            {
                return false;
            }

            if (data == root.Data)
            {
                return true;
            }

            if (data < root.Data)
            {
                return SearchRec(root.Left, data);
            }

            return SearchRec(root.Right, data);
        }
    }
}
