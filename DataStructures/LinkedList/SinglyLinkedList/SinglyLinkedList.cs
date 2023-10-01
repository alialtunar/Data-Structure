using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }

        private bool IsHeadNull => Head == null;

        public void AddFirst(T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);
            newNode.Next = Head;
            Head = newNode;

        }

        public void AddLast(T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);
            if (IsHeadNull)
            {
                Head = newNode;
                return;
            }

            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void AddAfter(SinglyLinkedListNode<T> node,T item)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }

            if (IsHeadNull)
            {
                AddFirst(item);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(item);

           var current = Head;
           while(current != null)
            {

                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }

                current = current.Next;
            }
            throw new Exception("Data Not Found");
        }


    }
}
