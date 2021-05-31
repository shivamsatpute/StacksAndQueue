using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueue
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }
    class Stack
    {
        public Node top;
        public Stack() 

        {
            this.top = null;
        }

        public void Push(int data) 
        {
            Node node = new Node(data); 

            if (this.top == null) 
            {
                node.next = null;                              
            }
            else
            {
                node.next = top;
            }

            this.top = node;  
            Console.WriteLine($"Element Inserted In Stack:- {data}");

        }

        public void Peek()
        {
            if (this.top == null) 
            {
                Console.WriteLine("Stack is Empty");  
                return;

            }
            Console.WriteLine($"{this.top.data } is a Top of the Stack "); 

        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Empty Stack"); 
            }
            Console.WriteLine($"Removing the top {this.top.data } (LIFO) Element from the stack"); 

            this.top = this.top.next;  
            Display(); 
        }

        public void isEmpty()
        {
            while (top != null)
            {
                Peek(); 
                Pop(); 
            }
            Display();
        }
        public void Display()
        {
            Node temp = this.top;
            if (temp == null) 
            {
                Console.WriteLine("Stack is Empty");  
                return;

            }
            while (temp != null) 
            {
                Console.WriteLine($"Stack Elements is:- { temp.data}");
                temp = temp.next;
            }
        }
    }
}
