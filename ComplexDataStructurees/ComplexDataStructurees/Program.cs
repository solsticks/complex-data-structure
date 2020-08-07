using ComplexDataStructurees.StackImplementation;
using System;

namespace ComplexDataStructurees
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new Queue<int>(6);
            q.qEnqueue(5);
            q.qDisplay();
            Console.WriteLine(q.isEmpty());

            var s = new Stack<string>(6);
            s.Push("nato");
            s.Print();
        }
    }
}
