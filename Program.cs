using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace lesson17
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("saeed");
            stack.Push("Roya");
            stack.Push("Nonoy");
            stack.Pop();
            Console.WriteLine(stack.Size());
            stack.Print();

            Console.ReadKey();
        }
    }


}
