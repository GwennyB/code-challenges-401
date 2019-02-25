using System;
using System.Collections.Generic;
using System.Text;
using linked_list.Classes;

namespace graph.Classes
{
    class Graph
    {
        public LinkedList Vertices { get; set; }

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
                for (int i = 0; i < Vertices.Current.Neighbors.Count; i++)
                {
                    list.Add(Vertices.Current.Neighbors[i].Item1);
                }
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

    }
}
