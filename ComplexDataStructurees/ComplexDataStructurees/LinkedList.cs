using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace ComplexDataStructurees
{
    public class LinkedList
    {
        public Nodes Head { get; set; } // This is the first node in my list
        public Nodes Tail { get; set; } // this is the last node in my list
        public bool isEmpty { get; private set; }

        public int Count { get; private set; } // this takes the number of elements in my list
       
        public LinkedList() // this constructor initializes my first node and last node are the same when the list is empty.
        {
            Head = new Nodes();
            Tail = Head;
            
        }

        public void AddLast(object data) // this method will add an element to the end of the list i.e to the tail node.
        {
            Nodes newNode = new Nodes();
            newNode.Value = data;
            Tail.Next = newNode;
            Tail = newNode;
            Count++;
            isEmpty = false;
        }

        public int Size()
        {
            return Count;
        }

        public void empty()
        {
            if (Count > 0)
            {
                isEmpty = false;
            }
            else
                isEmpty = true;
            Console.WriteLine(isEmpty);
        }

        public Nodes Remove()// this method removes the last node
        {
            if (Head == null) return null;
            if (Head.Next == null) return null;

            var second_Last = Head;
            while(second_Last.Next.Next != null)
                second_Last = second_Last.Next;
               
            second_Last.Next = null;
            Count--;
            return Head;            
        }

        public void Check(object data) // this methods checks for an item and returns true if found, false if not found.
        {            
            Nodes curr = Head;
            while (curr.Next != null)
            {

                curr = curr.Next;

                if (curr.Value.Equals(data))
                {
                    Console.WriteLine(true);
                    break;
                }
                else
                    Console.WriteLine(false);
            }
                                           
        }

        public int index(object data) // this methods is used to generate the index of an element in the linked list
        {
            int iCount = 0;
            Nodes curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                iCount++;
                if (curr.Value.Equals(data))
                {
                    return iCount;
                }
                return -1;
            }
            return iCount;
        }

        public void Exist(object data) // this method looks through the list for a specified item and returns it if found.
        {

            Nodes curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                if (curr.Value.Equals(data))
                {
                    Console.WriteLine(data); ;
                }
            }
            Console.WriteLine("The element does not exist in the list!"); ;
        }

        
        public void PrintAllNodes()
        {
            //Traverse from head
            
            Nodes curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.WriteLine("NULL");
        }
    }
}
