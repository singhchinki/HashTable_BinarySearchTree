using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        public T NodeData
        {
            get;
            set;
        }
        public BinarySearchTree<T> leftTree { get; set; }
        public BinarySearchTree<T> rightTree { get; set; }
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }

        int leftCount = 0;
        int rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySearchTree<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySearchTree<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightTree.Display();
            }
        }
        public void getSize()
        {
            Console.WriteLine("Size of BST is = " + (1 + this.leftCount + this.rightCount));
        }
        public bool ifExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found element in BST = " + node.NodeData);
                return true;
            }
            else
                Console.WriteLine("Current element is  in BST = " + node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                ifExists(element, node.leftTree);
            if (element.CompareTo(node.NodeData) > 0)
                ifExists(element, node.rightTree);
            return result;
        }
    }
}
