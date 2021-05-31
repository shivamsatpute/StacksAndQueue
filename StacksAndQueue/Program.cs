using System;

namespace StacksAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack");
            Stack stack = new Stack(); 
            stack.Push(56); 
            stack.Push(30);  
            stack.Push(70);
            stack.Display();
            stack.Peek(); 
            stack.Pop(); 
            stack.isEmpty(); 

            Console.ReadLine();
        }
    }
}
 