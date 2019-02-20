using System;
using StacksAndQueues.Classes;
using linked_list.Classes;
using tree.Classes;
using Hashtable.Classes;
using System.Collections.Generic;

namespace tree_intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree treeA = BuildBinTree(new int[] { 1,2,3,4,5,6,7 });
            BinaryTree treeB = BuildBinTree(new int[] { 1,-2,3,-4,5,-6,7 });
            List<object> list = TreeIntersection(treeA,treeB);
        }

        public static List<Object> TreeIntersection(BinaryTree treeA, BinaryTree treeB)
        {
            // build structures
            List<object> list = new List<object>();
            Queue queue = new Queue();
            Hashmap map = new Hashmap(1024);

            // traverse treeA
            queue.Enqueue(treeA.Root);
            while(queue.Front != null)
            {

            }

            // traverse treeB
            queue.Enqueue(treeB.Root);
            while (queue.Front != null)
            {

            }
        }




        /// <summary>
        /// CONSOLE TEST TOOL: populates BinaryTree for testing
        /// </summary>
        /// <param name="values"> values to assign to tree </param>
        /// <returns> populated tree </returns>
        public static BinaryTree BuildBinTree(int[] values)
        {
            BinaryTree tree = new BinaryTree();
            if (values.Length > 0)
            {
                tree.Root = new tree.Classes.Node(values[0]);
                tree.Root.Left = new tree.Classes.Node(values[1]);
                tree.Root.Right = new tree.Classes.Node(values[2]);
                tree.Root.Left.Left = new tree.Classes.Node(values[3]);
                tree.Root.Left.Right = new tree.Classes.Node(values[4]);
                tree.Root.Right.Left = new tree.Classes.Node(values[5]);
                tree.Root.Right.Right = new tree.Classes.Node(values[6]);
            }
            return tree;
        }

    }
}
