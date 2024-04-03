using System;
using System.Collections.Generic;
namespace priorityqueue_impl
{
    public class PriorityQueue
    {
        private int[] heap;
        private int capacity;
        private int size;

        public PriorityQueue(int capacity)
        {
            this.capacity = capacity;
            heap = new int[capacity];
            size = 0;
        }

        public void Add(int item)
        {
            if (size == capacity)
            {
                Console.WriteLine("Priority Queue is full. Cannot add more elements.");
                return;
            }

            size++;
            int index = size - 1;
            heap[index] = item;

            // Restore heap property
            while (index != 0 && heap[Parent(index)] > heap[index])
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }
        }

        public int Remove()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Priority Queue is empty.");
            }

            if (size == 1)
            {
                size--;
                return heap[0];
            }

            int root = heap[0];
            heap[0] = heap[size - 1];
            size--;
            MinHeapify(0);
            return root;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < size; i++)
            {
                if (heap[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        private void MinHeapify(int index)
        {
            int left = Left(index);
            int right = Right(index);
            int smallest = index;

            if (left < size && heap[left] < heap[index])
            {
                smallest = left;
            }
            if (right < size && heap[right] < heap[smallest])
            {
                smallest = right;
            }
            if (smallest != index)
            {
                Swap(index, smallest);
                MinHeapify(smallest);
            }
        }

        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        private int Parent(int index)
        {
            return (index - 1) / 2;
        }

        private int Left(int index)
        {
            return 2 * index + 1;
        }

        private int Right(int index)
        {
            return 2 * index + 2;
        }

        public void PrintQueue()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(heap[i] + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue priorityQueue = new PriorityQueue(10);

            int choice;
            int item;

            while (true)
            {
                Console.WriteLine("Priority Queue Operations:");
                Console.WriteLine("1. Add element");
                Console.WriteLine("2. Remove element");
                Console.WriteLine("3. Check if element exists");
                Console.WriteLine("4. Print Priority Queue");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter element to add: ");
                        item = Convert.ToInt32(Console.ReadLine());
                        priorityQueue.Add(item);
                        break;
                    case 2:
                        try
                        {
                            int removedItem = priorityQueue.Remove();
                            Console.WriteLine("Removed element from priority queue: " + removedItem);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 3:
                        Console.Write("Enter element to search: ");
                        item = Convert.ToInt32(Console.ReadLine());
                        if (priorityQueue.Contains(item))
                        {
                            Console.WriteLine("Element " + item + " exists in priority queue.");
                        }
                        else
                        {
                            Console.WriteLine("Element " + item + " does not exist in priority queue.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Priority Queue:");
                        priorityQueue.PrintQueue();
                        break;
                    case 5:
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
