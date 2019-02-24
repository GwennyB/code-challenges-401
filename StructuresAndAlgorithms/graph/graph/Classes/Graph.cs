using System;
using System.Collections.Generic;
using System.Text;
using linked_list.Classes;

namespace graph.Classes
{
    class Graph
    {
        public LinkedList Vertices { get; set; }

        //AddNode()
        //Adds a new node to the graph
        //Takes in the value of that node
        //Returns the added node
        public Node AddNode(Object value)
        {

        }



        //AddEdge()
        //Adds a new edge between two nodes in the graph
        //Include the ability to have a “weight”
        //Takes in the two nodes to be connected by the edge
        //Both nodes should already be in the Graph
        public void AddEdge(Node parent, Node child, int? weight)
        {

        }



        //GetNodes()
        //Returns all of the nodes in the graph as a collection(set, list, or similar)
        public List<Node> GetNodes()
        {

        }



        //GetNeighbors()
        //Returns a collection of nodes connected to the given node
        //Takes in a given node
        //Include the weight of the connection in the returned collection
        public LinkedList GetNeighbors(Node node)
        {

        }



        //Size()
        //Returns the total number of nodes in the graph
        public int Size()
        {

        }

    }
}
