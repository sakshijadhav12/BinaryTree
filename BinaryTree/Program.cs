using System;
using System.Collections.Generic;
namespace HashTableAndTree
{
    internal class BinaryTree
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Binary Tree Program...");
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(11);
            bst.Insert(3);
            bst.Insert(16);
            bst.Insert(65);
            bst.Insert(63);
            bst.Insert(67);
            Console.WriteLine("Inorder Traversal:");
            bst.InorderTraversal();

            Console.WriteLine("Total number of nodes: " + bst.Size());

            int searchValue = 63;
            if (bst.Search(searchValue))
            {
                Console.WriteLine(searchValue + " is found in the binary tree.");
            }
            else
            {
                Console.WriteLine(searchValue + " is not found in the binary tree.");
            }
        }
    }

    public class BinarySearchTree
    {
        private Node root;
        private int count;
        public void Insert(int value)
        {
            root = InsertNode(root, value);
        }
        private Node InsertNode(Node currentNode, int value)
        {
            if (currentNode == null)
            {
                count++;
                return new Node(value);
            }
            if (value < currentNode.Value)
            {
                currentNode.Left = InsertNode(currentNode.Left, value);
            }
            else if (value > currentNode.Value)
            {
                currentNode.Right = InsertNode(currentNode.Right, value);
            }
            return currentNode;
        }
        public void InorderTraversal()
        {
            InorderTraversal(root);
        }
        private void InorderTraversal(Node currentNode)
        {
            if (currentNode == null)
            {
                return;
            }
            InorderTraversal(currentNode.Left);
            Console.WriteLine(currentNode.Value);
            InorderTraversal(currentNode.Right);
        }
        public int Size()
        {
            return count;
        }

        public bool Search(int value)
        {
            return SearchNode(root, value);
        }

        private bool SearchNode(Node currentNode, int value)
        {
            if (currentNode == null)
            {
                return false;
            }

            if (value == currentNode.Value)
            {
                return true;
            }
            else if (value < currentNode.Value)
            {
                return SearchNode(currentNode.Left, value);
            }
            else
            {
                return SearchNode(currentNode.Right, value);
            }
        }

        private class Node
        {
            public int Value { get; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }
    }
}
