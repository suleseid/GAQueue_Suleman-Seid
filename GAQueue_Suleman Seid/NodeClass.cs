using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GAQueue_Suleman_Seid
{
    public class NodeClass
    {
        public int Data { get; set; }
        public NodeClass Next { get; set; }

        public NodeClass(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class MyStack
    {
        private NodeClass top;

        // Constructor
        public MyStack()
        {
            top = null;
        }

        // Method to check if the stack is empty
        public bool Empty()
        {
            return top == null;
        }

        // Method to push an element onto the stack
        public void Push(int data)
        {
            NodeClass newNode = new NodeClass(data);
            newNode.Next = top;
            top = newNode;
        }

        // Method to remove and return the top element from the stack
        public int Pop()
        {
            if (Empty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int data = top.Data;
            top = top.Next;
            return data;
        }

        // Method to return the top element of the stack without removing it
        public int Peek()
        {
            if (Empty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return top.Data;
        }

        // Method to search for an element in the stack and return its position (1-based index)
        public int Search(int data)
        {
            NodeClass current = top;
            int index = 1;

            while (current != null)
            {
                if (current.Data == data)
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1; // Element not found
        }
    }

}
