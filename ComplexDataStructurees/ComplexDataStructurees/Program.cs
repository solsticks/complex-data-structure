using ComplexDataStructurees.StackImplementation;
using System;

namespace ComplexDataStructurees
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new LinkedList();
            //list.AddLast(24);
            //list.AddLast(25);
            //list.AddLast(56);
            //Console.WriteLine(list.index(56));
            // list.empty();
            // Console.WriteLine(list.Size());
            //list.Exist(24);

            //var q = new Queue(5);
            //q.qEnqueue(12);
            //Console.WriteLine(q.Size());
            //Console.WriteLine(q.isEmpty());
            //q.qDisplay();

            var s = new Stack(5);
            s.Push(3);
            s.Push(12);
            s.Push(4);
            s.Pop();

           // Console.WriteLine(s.IsEmpty());
            Console.WriteLine(s.size());

            s.PrintStack();
        }
    }
}
