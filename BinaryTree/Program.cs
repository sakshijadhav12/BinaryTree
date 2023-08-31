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

            Console.WriteLine("Inorder Traversal:");
            bst.InorderTraversal();
        }
    }

    public class BinarySearchTree
    {
        private Node root;

        public void Insert(int value)
        {
            root = InsertNode(root, value);
        }

        private Node InsertNode(Node currentNode, int value)
        {
            if (currentNode == null)
            {
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