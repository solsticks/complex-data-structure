using System;

namespace ComplexDataStructurees
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList();
            list.AddLast(24);
            list.AddLast(12);
             
           // list.PrintAllNodes();
            list.Check(24); 
            //list.empty();  
        }
    }
}
