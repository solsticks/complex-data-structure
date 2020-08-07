using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexDataStructurees
{
	
	using System;
    using System.Runtime.ExceptionServices;

    public class Queue <T>
	{
		private static int front;
		private static int last; 
		private static int size;
		private static T[] queue;

		public Queue(int s)
		{
			front = last;
			size = s;
			queue = new T[size];
		}

		// function to insert an element 
		// at the rear of the queue 
		public void qEnqueue(T data)
		{
			// checks if the queue is full or not 
			if (size.Equals(last))
			{
				Console.WriteLine("Queue is full");
				return;
			}

			// insert element at the rear 
			else
			{
                queue[last] = data;
				last++;
			}
			return;
		}

		// function to delete an element 
		// from the front of the queue 
		public void qDequeue()
		{
			// if queue is empty 
			if (front == last)
			{
				Console.WriteLine("Queue is empty");
				return;
			}

			/*shift all the elements from index 2 till rear 
			 to the right by one */
			else
			{
				for (int i = 0; i < last - 1; i++)
				{
					queue[i] = queue[i + 1];
				}

				// store 0 at rear indicating there's no element 
				if (last < size)
					queue[last] = default;

				// decrement rear 
				last--;
			}
			return;
		}

		// print queue elements 
		public void qDisplay()
		{
			int i;
			if (front == last)
			{
				Console.WriteLine("Queue is Empty");
				return;
			}

			// traverse front to rear and print elements 
			for (i = front; i < last; i++)
			{
				Console.Write(" {0} <-- ", queue[i]);
			}
			return;
		}

		// print front of queue 
		public void queueFront()
		{
			if (front == last)
			{
				Console.WriteLine("Queue is Empty");
				return;
			}
			Console.WriteLine("Front Element is: {0}", queue[front]);
			return;
		}
		public int Size() // returns the size of the queue
        {
			return size;
        }
		public bool isEmpty()// Dtermins if the queue is empty or not
        {
			if (front == last)
			{
				return true;
			}
			else
				return false;
        }
	}

	

}

