﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Array
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerList;

        public int Count { get; private set; }
        public int Capacity => InnerList.Length;


        public Array()
        {
            InnerList = new T[2];
            Count = 0;
        }

        public Array(params T[] initilaze)
        {
            InnerList = new T[initilaze.Length];
            Count = 0;
            foreach (var item in initilaze)
            {
                Add(item);
            }
        }

        public Array(IEnumerable<T> collection)
        {
            InnerList = new T[collection.ToArray().Length];
            Count = 0;
            foreach(var item in collection)
            {
                Add(item);
            }
        }

        public void Add(T item)
        {
            if (InnerList.Length == Count)
            {
                DoubleArray();

            }
            InnerList[Count] = item;
            Count++;
        }

        public T Remove()
        {
            if (Count == 0)
                throw new Exception("Data Not Found");
            if (InnerList.Length / 4 == Count)
                HalfArray();
            var temp = InnerList[Count - 1];
            if (Count > 0)
                Count--;
            return temp;

        }

        private void HalfArray()
        {
            if (InnerList.Length > 2)
            {
                var temp = new T[InnerList.Length / 2];
                System.Array.Copy(InnerList, temp, InnerList.Length / 4);
                InnerList = temp;
            }
        }

        private void DoubleArray()
        {
            var temp = new T[InnerList.Length * 2];
            System.Array.Copy(InnerList, temp, InnerList.Length);
            InnerList = temp;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }   
    }
}
