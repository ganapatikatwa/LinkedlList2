using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Linkedlist
    {
        Node head;
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp= head;
                while(temp.Next!= null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} Inserted into LinkedList",node.Data);
        }
        public void AddReverse(int data)
        {
            Node newnode = new Node(data);
            if(head==null)
            {
                head = newnode;
            }
            else
            {
                Node temp= head;
                head= newnode;
                head.Next = temp;
            }
            Console.WriteLine("{0} Inseted inti LinkedList", newnode.Data);
        }

        public void Display()
        {
            if(head==null)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Linked List is Empty");
                Console.ResetColor();
            }
            else
            {
                Node temp= head;
                while(temp!=null)
                {
                    Console.Write(" | "+temp.Data+" | ");
                    temp=temp.Next;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Linked List is  Not Empty");
                Console.ResetColor();
            }
            
        }
    }
}
