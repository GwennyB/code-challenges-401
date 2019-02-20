using System;
using tree.Classes;
using Hashtable.Classes;
using System.Collections.Generic;
using linked_list.Classes;
using StacksAndQueues.Classes;

namespace tree_intersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree treeA = BuildBinTree(new int[] { 1,2,3,4,5,6,7 });
            BinaryTree treeB = BuildBinTree(new int[] { 1,-2,3,-4,5,-6,7 });
            List<Object> listA = TreeIntersection(treeA,treeB);
            Console.WriteLine("test 1: ");
            foreach (var item in listA)
            {
                Console.Write($"  {item}  ");
            }

            BinaryTree treeC = BuildBinTree(new int[] { 1, 1, 1, 1, 1, 1, 1 });
            BinaryTree treeD = BuildBinTree(new int[] { 2, 2, 2, 2, 2, 2, 2 });
            List<Object> listC = TreeIntersection(treeC, treeD);
            Console.WriteLine("\ntest 2: ");
            foreach (var item in listC)
            {
                Console.Write($"  {item}  ");
            }

            BinaryTree treeE = BuildBinTree(new int[] { 1, 1, 1, 1, 1, 1, 1 });
            BinaryTree treeF = new BinaryTree();
            List<Object> listE = TreeIntersection(treeE, treeF);
            Console.WriteLine("\ntest 3: ");
            foreach (var item in listE)
            {
                Console.Write($"  {item}  ");
            }

            Console.ReadLine();
        }

        public static List<Object> TreeIntersection(BinaryTree treeA, BinaryTree treeB)
        {
            // build structures
            List<object> list = new List<object>();
            Queue queue = new Queue();
            Hashmap map = new Hashmap(1024);
            Object temp = null;

            // traverse treeA
            queue.Enqueue(treeA.Root);
            while(queue.Front != null)
            {
                if(queue.Front.Left != null)
                {
                    queue.Enqueue(queue.Front.Left);
                }
                if (queue.Front.Right != null)
                {
                    queue.Enqueue(queue.Front.Right);
                }
                temp = queue.Front.Value.ToString();
                if (!map.Contains(temp, temp))
                {
                    map.Add(temp, temp);
                }
                queue.Dequeue();
            }

            // traverse treeB
            queue.Enqueue(treeB.Root);
            while (queue.Front != null)
            {
                if (queue.Front.Left != null)
                {
                    queue.Enqueue(queue.Front.Left);
                }
                if (queue.Front.Right != null)
                {
                    queue.Enqueue(queue.Front.Right);
                }
                temp = queue.Front.Value.ToString();
                if (map.Contains(temp, temp))
                {
                    //map.Remove(temp, temp);
                    list.Add(temp);
                }
                queue.Dequeue();
            }
            return list;
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
                tree.Root = new Node(values[0]);
                tree.Root.Left = new Node(values[1]);
                tree.Root.Right = new Node(values[2]);
                tree.Root.Left.Left = new Node(values[3]);
                tree.Root.Left.Right = new Node(values[4]);
                tree.Root.Right.Left = new Node(values[5]);
                tree.Root.Right.Right = new Node(values[6]);
            }
            return tree;
        }

    }
}
