using System;

namespace ComplexDataStructurees
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList();
            list.AddLast(24);
            list.empty();
            Console.WriteLine(list.Size()); 
        }
    }
}
