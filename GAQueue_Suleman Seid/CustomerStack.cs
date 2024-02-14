using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAQueue_Suleman_Seid
{
    public class CustomerStack<T>
    {
        private LinkedList<T> stackData;

        public CustomerStack()
        {
            stackData = new LinkedList<T>();
        }

        public void Push(T item)
        {
            stackData.AddLast(item);
        }

        public T Pop()
        {
            if (stackData.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            var lastNode = stackData.Last;
            stackData.RemoveLast();
            return lastNode.Value;
        }

        public T Peek()
        {
            if (stackData.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            return stackData.Last.Value;
        }

        public bool Empty()
        {
            return stackData.Count == 0;
        }

        public int Search(T item)
        {
            int index = 0;
            foreach (var node in stackData)
            {
                if (EqualityComparer<T>.Default.Equals(node, item))
                    return index;
                index++;
            }
            return -1;
        }
    }

    public class CustomQueue<T>
    {
        private CustomerStack<T> stack1;
        private CustomerStack<T> stack2;

        public CustomQueue()
        {
            stack1 = new CustomerStack<T>();
            stack2 = new CustomerStack<T>();
        }

        public void Enqueue(T item)
        {
            stack1.Push(item);
        }

        public T Dequeue()
        {
            if (stack1.Empty() && stack2.Empty())
                throw new InvalidOperationException("Queue is empty.");

            if (stack2.Empty())
            {
                while (!stack1.Empty())
                    stack2.Push(stack1.Pop());
            }

            return stack2.Pop();
        }
    }

}

