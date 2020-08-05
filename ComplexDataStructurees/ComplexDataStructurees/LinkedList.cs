using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace ComplexDataStructurees
{
    public class LinkedList<T>
    {
        public Nodes<T> Head { get; set; } // This is the first node in my list
        public Nodes<T> Tail { get; set; } // this is the last node in my list
        public bool isEmpty { get; private set; }

        public int Count { get; private set; } // this takes the number of elements in my list
       
        public LinkedList() // this constructor initializes my first node and last node are the same when the list is empty.
        {
            Head = new Nodes<T>();
            Tail = Head;
            
        }

        public void AddLast(T data) // this method will add an element to the end of the list i.e to the tail node.
        {
            Nodes<T> newNode = new Nodes<T>();
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

        public Nodes<T> Remove()// this method removes the last node
        {
            if (Head == null) return null;
            if (Head.Next == null) return null;

            var current = Head;
            var second_Last = current;
            while (current.Next != null)
            {
                second_Last = current;
                current = current.Next;
            }
            Tail = second_Last;
            Tail.Next = null;

            return current;
            
        }

        public void Check(T data) // this methods checks for an item and returns true if found, false if not found.
        {            
            Nodes<T> curr = Head;
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

        public Nodes<T> insertAt(int index, T data) // this methods adds the element at specified index
        {
            int iCount = 0;
            Nodes<T> curr = Head;
            var prev = curr;
            var temp = new Nodes<T>();
            temp.Value = data;
            while (curr.Next != null)
            {
                prev = curr;
                curr = curr.Next;
                //iCount++;
                if (iCount.Equals(index))
                {
                    prev.Next = temp;
                   // Console.WriteLine(curr.Value);
                    temp.Next = curr;                    
                }                
                else if (index - iCount > 1)
                {
                    Console.WriteLine("Unreachable index");
                    break;
                }
                iCount++;
                Console.WriteLine(iCount);
            }
            //Console.WriteLine(index);
            return curr;
        }

        public void Exist(T data) // this method looks through the list for a specified item and returns it if found.
        {

            Nodes<T> curr = Head;
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
        { //Traverse from head            
            Nodes<T> curr = Head;
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
