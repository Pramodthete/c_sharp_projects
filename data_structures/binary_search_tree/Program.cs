using System;

namespace binary_search_tree_impl
{
    namespace BinarySearchTree
    {
        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int item)
            {
                data = item;
                left = right = null;
            }
        }

        public class BinarySearchTree
        {
            Node root;

            public BinarySearchTree()
            {
                root = null;
            }

            public void Insert(int key)
            {
                root = InsertRec(root, key);
            }

            Node InsertRec(Node root, int key)
            {
                if (root == null)
                {
                    root = new Node(key);
                    return root;
                }

                if (key < root.data)
                    root.left = InsertRec(root.left, key);
                else if (key > root.data)
                    root.right = InsertRec(root.right, key);

                return root;
            }

            public void Remove(int key)
            {
                root = RemoveRec(root, key);
            }

            Node RemoveRec(Node root, int key)
            {
                if (root == null)
                    return root;

                if (key < root.data)
                    root.left = RemoveRec(root.left, key);
                else if (key > root.data)
                    root.right = RemoveRec(root.right, key);
                else
                {
                    if (root.left == null)
                        return root.right;
                    else if (root.right == null)
                        return root.left;

                    root.data = MinValue(root.right);

                    root.right = RemoveRec(root.right, root.data);
                }

                return root;
            }

            int MinValue(Node root)
            {
                int minValue = root.data;
                while (root.left != null)
                {
                    minValue = root.left.data;
                    root = root.left;
                }
                return minValue;
            }

            public void Inorder()
            {
                InorderRec(root);
            }

            void InorderRec(Node root)
            {
                if (root != null)
                {
                    InorderRec(root.left);
                    Console.Write(root.data + " ");
                    InorderRec(root.right);
                }
            }

            public void Preorder()
            {
                PreorderRec(root);
            }

            void PreorderRec(Node root)
            {
                if (root != null)
                {
                    Console.Write(root.data + " ");
                    PreorderRec(root.left);
                    PreorderRec(root.right);
                }
            }

            public void Postorder()
            {
                PostorderRec(root);
            }

            void PostorderRec(Node root)
            {
                if (root != null)
                {
                    PostorderRec(root.left);
                    PostorderRec(root.right);
                    Console.Write(root.data + " ");
                }
            }

            public bool Search(int key)
            {
                return SearchRec(root, key);
            }

            bool SearchRec(Node root, int key)
            {
                if (root == null)
                    return false;

                if (root.data == key)
                    return true;

                if (root.data < key)
                    return SearchRec(root.right, key);

                return SearchRec(root.left, key);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                BinarySearchTree bst = new BinarySearchTree();
                int choice, data;

                while (true)
                {
                    Console.WriteLine("\nBinary Search Tree Operations:");
                    Console.WriteLine("1. Insert Element");
                    Console.WriteLine("2. Remove Element");
                    Console.WriteLine("3. Search Element");
                    Console.WriteLine("4. Print Tree (Inorder)");
                    Console.WriteLine("5. Print Tree (Preorder)");
                    Console.WriteLine("6. Print Tree (Postorder)");
                    Console.WriteLine("7. Exit");
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter element to insert: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            bst.Insert(data);
                            break;
                        case 2:
                            Console.Write("Enter element to remove: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            bst.Remove(data);
                            break;
                        case 3:
                            Console.Write("Enter element to search: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            if (bst.Search(data))
                                Console.WriteLine("Element " + data + " exists in the tree.");
                            else
                                Console.WriteLine("Element " + data + " does not exist in the tree.");
                            break;
                        case 4:
                            Console.WriteLine("Inorder Traversal:");
                            bst.Inorder();
                            break;
                        case 5:
                            Console.WriteLine("Preorder Traversal:");
                            bst.Preorder();
                            break;
                        case 6:
                            Console.WriteLine("Postorder Traversal:");
                            bst.Postorder();
                            break;
                        case 7:
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

}
