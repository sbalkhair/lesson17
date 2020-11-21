using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson17
{
    public class Stack
    {

        List<string> mylist;
        public Stack()
        {
            mylist = new List<string>();
        }


        public void Push(string item)
        {
            mylist.Add(item);
        }

        public void Pop()
        {
            mylist.Remove(mylist[mylist.Count - 1]);
        }

        public int Size()
        {
            return mylist.Count;
        }

        public void Print()
        {
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
