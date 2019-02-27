using System;
using System.Collections.Generic;
using System.Text;
using linked_list.Classes;
using StacksAndQueues.Classes;

namespace graph.Classes
{
    public class Graph
    {
        public LinkedList Vertices { get; set; }

        public Graph()
        {
            Vertices = new LinkedList();
        }

        /// <summary>
        ///Adds a new node to the graph
        ///Takes in the value of that node
        ///Returns the added node
        /// </summary>
        /// <param name="value"> value of node to add </param>
        /// <returns> the node just added </returns>
        public Node AddNode(int value)
        {
            Vertices.Append(value);
            return Vertices.Find(value);
        }


        /// <summary>
        ///Adds a new edge between two nodes in the graph
        ///Includes the ability to have a “weight”
        ///Takes in the two nodes to be connected by the edge
        ///Both nodes should already be in the Graph
        /// </summary>
        /// <param name="parent"> parent node </param>
        /// <param name="child"> child node </param>
        /// <param name="weight"> weight of edge between parent and child </param>
        public void AddEdge(Node parent, Node child, int? weight)
        {
            Tuple<Node, int> neighbor = new Tuple<Node, int>(child,weight ?? 1);
            parent.Neighbors.Add(neighbor);
        }

        /// <summary>
        ///Returns all of the nodes in the graph as a collection(set, list, or similar)
        /// </summary>
        /// <returns> list of all nodes in the graph </returns>
        public List<Node> GetNodes()
        {
            List<Node> list = new List<Node>();
            Vertices.Current = Vertices.Head;
            while (Vertices.Current != null)
            {
                if(Vertices.Current.Visited == false)
                {
                    list.Add(Vertices.Current);
                    Vertices.Current.Visited = true;
                }
                for (int i = 0; i < Vertices.Current.Neighbors.Count; i++)
                {
                    if(Vertices.Current.Neighbors[i].Item1.Visited == false)
                    {
                        list.Add(Vertices.Current.Neighbors[i].Item1);
                        Vertices.Current.Neighbors[i].Item1.Visited = true;
                    }
                }
                Vertices.Current = Vertices.Current.Next;
            }
            return list;
        }

        /// <summary>
        ///Returns a collection of nodes connected to the given node
        ///Takes in a given node
        ///Includes the weight of the connection in the returned collection
        /// </summary>
        /// <param name="node"> node whose neighbors to return </param>
        /// <returns> list of node's neighbors </returns>
        public List<Tuple<Node,int>> GetNeighbors(Node node)
        {
            return node.Neighbors;
        }

        /// <summary>
        /// Returns the total number of nodes in the graph
        /// </summary>
        /// <returns> total count of nodes </returns>
        public int Size()
        {
            return GetNodes().Count;
        }

        /// <summary>
        /// traverses a graph breadth-first (ie - all children of a node, then all children of children, etc), adds each to a list, and returns the list
        /// </summary>
        /// <param name="node"> root of graph to traverse </param>
        /// <returns> list of all nodes in the graph </returns>
        public LinkedList BreadthFirst(Node node)
        {
            Queue helper = new Queue();
            LinkedList list = new LinkedList();
            helper.Enqueue(node);
            while (helper.Front != null)
            {
                foreach (Tuple<Node,int> neighbor in node.Neighbors)
                {
                    if(neighbor.Item1.Visited == false)
                    {
                        helper.Enqueue(neighbor.Item1);
                    }
                }
                helper.Front.Visited = true;
                list.Append(helper.Front);
                helper.Dequeue();
            }
            return list;
        }
    }
}
