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
                Console.WriteLine("Enter the Choice\n1)Add Node\n2)Reverse Node\n3)Append\n4)Inser\n5)Delete");
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
                    case 3:
                        linkedList.Append(56);
                        linkedList.Append(30);
                        linkedList.Append(70);
                        linkedList.Display();
                        break;
                    case 4:
                        linkedList.AddNode(56);
                        linkedList.AddNode(70);
                        linkedList.Display();
                        linkedList.Insert(2, 30);
                        linkedList.Display();
                        break;
                    case 5:
                        linkedList.AddNode(56);
                        linkedList.AddNode(30);
                        linkedList.AddNode(70);
                        linkedList.Display();
                        linkedList.Delete(56);
                        linkedList.Display();
                        break;
                }
            }
        }
    }
}

