﻿using System;

namespace 程序结构
{
    public class Stack
    {
        Entry top;
        public void Push(object data)
        {
            top = new Entry(top,data);
        }
        public object Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException();
            }
            object result = top.data;
            top = top.next;
            return result;
        }
    }
    class Entry
    {
        public Entry next;
        public object data;
        public Entry(Entry next,object data)
        {
            this.next = next;
            this.data = data;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
