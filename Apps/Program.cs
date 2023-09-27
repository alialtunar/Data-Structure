using System;
using System.Collections.Generic;

namespace Apps
{
    class Program
    {
        static void Main(string[] args)     
        {
                        var arr = new DataStructures.Array.Array<int>();
           arr.Add(10);
            arr.Add(20);
            arr.Add(30);
            arr.Add(40);
            arr.Add(50);
            Console.WriteLine($"{arr.Count} / {arr.Capacity}");
            arr.Remove();
            arr.Remove();

            Console.WriteLine($"{arr.Count} / {arr.Capacity}");
            Console.ReadKey();
        }
    }
}
