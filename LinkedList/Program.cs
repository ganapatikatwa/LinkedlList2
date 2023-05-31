using System;
namespace LinkedList
{
    public class Program
    {
        public static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the Choice\n1)Add Node");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Linkedlist linkedList = new Linkedlist();
                        linkedList.AddNode(56);
                        linkedList.AddNode(30);
                        linkedList.AddNode(70);
                        linkedList.Display();
                        break;
                }
            }
        }
    }
}

