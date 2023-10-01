using System;
using System.Collections.Generic;

namespace Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedlist = new DataStructures.LinkedList.SinglyLinkedList.SinglyLinkedList<int>();

            linkedlist.AddFirst(4);

            Console.ReadKey();
        }
    }
}
