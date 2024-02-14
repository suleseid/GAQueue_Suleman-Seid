using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAQueue_Suleman_Seid
{
    public class Program
    {
        static void Main(string[] args)
        {

            MyStack stack = new MyStack();

            // Pushing elements onto the stack
            stack.Push(10);
            stack.Push(15);
            stack.Push(20);
            stack.Push(30);
            // Peeking at the top element
            Console.WriteLine("Top element: " + stack.Peek());

            // Popping elements from the stack
            Console.WriteLine("Popped element: " + stack.Pop());
            Console.WriteLine("Popped element: " + stack.Pop());
            Console.WriteLine("Popped element: " + stack.Pop());

            // Checking if the stack is empty
            Console.WriteLine("Is stack empty? " + stack.Empty());

            // Searching for an element in the stack
            Console.WriteLine("Index of 20 in stack: " + stack.Search(20));
            Console.WriteLine("Index of 40 in stack: " + stack.Search(40));

        }
    }
}
