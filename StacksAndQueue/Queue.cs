using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueue
{
    class Queue
    {
        public Node head; 
        public void Enqueue(int data)
        {

            Node node = new Node(data);  
            Node temp = head;

            if (head == null) 
            {
                head = node;
            }
            else
            {
                Node lastNode = GetLastNode(temp); 
                lastNode.next = node;
            }
            Console.WriteLine($"Element Added in Queue:- {node.data}");
        }

        public Node GetLastNode(Node temp)
        {
            if (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void Display()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {

                while (temp != null)  
                {
                    Console.WriteLine($"Queue Element is:- {temp.data}"); 
                    temp = temp.next;
                }
            }
        }
        public int Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            Console.WriteLine($"{head.data } is a Top of the Queue "); 

            return head.data;
        }
    }
}

