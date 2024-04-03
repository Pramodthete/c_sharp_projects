using System;

namespace doubly_linkedlist_impl
{
    using System;

    public class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }

    public class DoublyLinkedList
    {
        public Node head;

        // Constructor
        public DoublyLinkedList()
        {
            head = null;
        }

        // Function to insert a new node at the end of the list
        public void InsertEnd(int new_data)
        {
            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new_node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
                new_node.prev = temp;
            }
        }

        // Function to insert a new node at the beginning of the list
        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            if (head != null)
            {
                head.prev = new_node;
            }
            head = new_node;
        }

        // Function to insert a new node at a specified index
        public void InsertAtIndex(int index, int new_data)
        {
            Node new_node = new Node(new_data);
            if (index < 0)
            {
                Console.WriteLine("Invalid index.");
                return;
            }
            if (index == 0)
            {
                new_node.next = head;
                if (head != null)
                {
                    head.prev = new_node;
                }
                head = new_node;
                return;
            }
            Node current = head;
            int count = 0;
            while (current != null && count < index)
            {
                current = current.next;
                count++;
            }
            if (current == null)
            {
                Console.WriteLine("Index out of range.");
                return;
            }
            Node prevNode = current.prev;
            prevNode.next = new_node;
            new_node.prev = prevNode;
            new_node.next = current;
            current.prev = new_node;
        }

        // Function to delete a node at a specified index
        public void DeleteAtIndex(int index)
        {
            if (head == null || index < 0)
            {
                Console.WriteLine("Invalid operation.");
                return;
            }
            Node current = head;
            int count = 0;
            while (current != null && count < index)
            {
                current = current.next;
                count++;
            }
            if (current == null)
            {
                Console.WriteLine("Index out of range.");
                return;
            }
            Node prevNode = current.prev;
            Node nextNode = current.next;
            if (prevNode != null)
            {
                prevNode.next = nextNode;
            }
            else
            {
                head = nextNode;
            }
            if (nextNode != null)
            {
                nextNode.prev = prevNode;
            }
        }

        // Function to update the value of a node at a specified index
        public void UpdateAtIndex(int index, int new_data)
        {
            Node current = head;
            int count = 0;
            while (current != null && count < index)
            {
                current = current.next;
                count++;
            }
            if (current == null)
            {
                Console.WriteLine("Index out of range.");
                return;
            }
            current.data = new_data;
        }

        // Function to reverse the doubly linked list
        public void Reverse()
        {
            Node temp = null;
            Node current = head;
            while (current != null)
            {
                temp = current.prev;
                current.prev = current.next;
                current.next = temp;
                current = current.prev;
            }
            if (temp != null)
            {
                head = temp.prev;
            }
        }

        // Function to print nodes in a given doubly linked list
        public void PrintList()
        {
            Node temp = head;
            Console.WriteLine("Doubly Linked List: ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();

            int choice;
            int data;
            int index;

            while (true)
            {
                Console.WriteLine("1. Insert at End");
                Console.WriteLine("2. Insert at Beginning");
                Console.WriteLine("3. Insert at Index");
                Console.WriteLine("4. Delete at Index");
                Console.WriteLine("5. Update at Index");
                Console.WriteLine("6. Reverse List");
                Console.WriteLine("7. Print List");
                Console.WriteLine("8. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter data to insert at end: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertEnd(data);
                        break;
                    case 2:
                        Console.Write("Enter data to insert at beginning: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertFront(data);
                        break;
                    case 3:
                        Console.Write("Enter index: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter data to insert at index: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtIndex(index, data);
                        break;
                    case 4:
                        Console.Write("Enter index to delete: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        list.DeleteAtIndex(index);
                        break;
                    case 5:
                        Console.Write("Enter index to update: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new data: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.UpdateAtIndex(index, data);
                        break;
                    case 6:
                        list.Reverse();
                        break;
                    case 7:
                        list.PrintList();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

}
