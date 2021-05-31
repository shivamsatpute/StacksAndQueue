using System;

namespace StacksAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Stack");
            //Stack stack = new Stack(); 
            //stack.Push(56); 
            //stack.Push(30);  
            //stack.Push(70);
            //stack.Display();
            //stack.Peek(); 
            //stack.Pop(); 
            //stack.isEmpty();
            Console.WriteLine("Queue"); 
            Queue queue = new Queue();  
            queue.Enqueue(56); 
            queue.Enqueue(30); 
            queue.Enqueue(70);
            queue.Display(); 
            queue.Peek(); 

            Console.ReadLine();
        }
    }
}
 