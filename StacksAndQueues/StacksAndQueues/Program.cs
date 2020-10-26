using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stacks stack = new Stacks();
            //stack.push(70);
            //stack.push(30);
            //stack.push(56);
            //stack.Display();
            //stack.Peek();
            //stack.Pop();
            //stack.IsEmpty();
            //stack.Display();
            Queues queue = new Queues();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
        }
    }
}
