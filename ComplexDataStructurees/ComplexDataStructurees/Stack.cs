﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ComplexDataStructurees
{
    using System; 

namespace StackImplementation 
{ 
	public class Stack<T>
	{
		private static int Size;
		private static int top;
		private	T[] stack;

            public Stack(int s)
            {
				top = -1;
				Size = s;
				stack = new T[Size];
            }

		public bool IsEmpty() // this returns if the stack is empty or not
		{ 
			return (top < 0); 
		} 
		
		public bool Push(T data) // this method adds item to the bigining of the stack
		{ 
			if (top >= Size) 
			{ 
				Console.WriteLine("Stack Overflow"); 
				return false; 
			} 
			else
			{ 
				stack[++top] = data; 
				return true; 
			} 
		} 

		public int size() // this method returns the size of the stack
        {
				return Size;
        }

		public T Pop() // this method removes the last element added to the stack
		{ 
			if (top < 0) 
			{ 
				Console.WriteLine("Stack is empty"); 
				return default; 
			} 
			else
			{ 
				T value = stack[top--]; 
				return  value; 
			} 
		} 

		public void Peek() // this method returns the top of the stack
		{ 
			if (top < 0) 
			{ 
				Console.WriteLine("Stack is empty"); 
				return; 
			} 
			else
				Console.WriteLine("The topmost element of Stack is : {0}", stack[top]); 
		} 

		public void Print() // this method displays all the element in the stack
		{ 
			if (top < 0) 
			{ 
				Console.WriteLine("Stack Underflow"); 
				return; 
			} 
			else
			{ 
				Console.WriteLine("Items in the Stack are :"); 
				for (int i = top; i >= 0; i--) 
				{ 
					Console.WriteLine(stack[i]); 
				} 
			} 
		} 
	} 

	
} 

}

