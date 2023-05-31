using System;
namespace LinkedList
{
    public class Program
    {
        public static void Main(String[] args)
        {
            while (true)
            {
                Linkedlist linkedList = new Linkedlist();
                Console.WriteLine("Enter the Choice\n1)Add Node\n2)Reverse Node");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        
                        linkedList.AddNode(56);
                        linkedList.AddNode(30);
                        linkedList.AddNode(70);
                        linkedList.Display();
                        break;
                    case 2:
                        linkedList.AddReverse(56);
                        linkedList.AddReverse(30);
                        linkedList.AddReverse(70);
                        linkedList.Display();
                        break;
                }
            }
        }
    }
}

