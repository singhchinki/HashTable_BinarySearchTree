using BinarySearchTree;
using System;

namespace DataStructureUsingBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Display();
        }
    }
}