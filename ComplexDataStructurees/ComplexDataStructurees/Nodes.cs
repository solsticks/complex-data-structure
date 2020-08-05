using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexDataStructurees
{
    //this is the node class which has two fields, the next; which points to the next node and the value which holds the object in the node
    public class Nodes<T>
    {
        public Nodes<T> Next;
        public T Value;
    }

}
