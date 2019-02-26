using System;
using Xunit;
using graph.Classes;
using linked_list.Classes;
using System.Collections.Generic;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Node can be successfully added to the graph
        /// </summary>
        [Fact]
        public void CanAddNode()
        {
            Graph graph = new Graph();
            graph.AddNode(10);
            Assert.True(graph.Vertices.Includes(10));
        }

        /// <summary>
        /// An edge can be successfully added to the graph
        /// </summary>
        [Fact]
        public void CanAddEdge()
        {
            Graph graph = new Graph();
            graph.AddNode(10);
            graph.AddNode(5);
            Node parent = graph.Vertices.Find(10);
            Node child = graph.Vertices.Find(5);
            graph.AddEdge(parent, child, 3);
            Assert.Equal(3,graph.Vertices.Head.Neighbors[0].Item2);
        }

        /// <summary>
        /// A collection of all nodes can be properly retrieved from the graph
        /// </summary>
        [Fact]
        public void CanReturnListOfAllNodes()
        {
            Graph graph = new Graph();
            graph.AddNode(10);
            graph.AddNode(5);
            graph.AddNode(2);

            Node one = graph.Vertices.Find(10);
            Node two = graph.Vertices.Find(5);
            Node three = graph.Vertices.Find(2);

            List<Node> list = new List<Node>();

            list.Add(one);
            list.Add(two);
            list.Add(three);

            Assert.Equal(list, graph.GetNodes());
        }

        /// <summary>
        /// All appropriate neighbors can be retrieved from the graph
        /// </summary>
        [Fact]
        public void CanReturnListOfNeighbors()
        {
            Graph graph = new Graph();
            graph.AddNode(10);
            graph.AddNode(5);
            graph.AddNode(2);

            Node one = graph.Vertices.Find(10);
            Node two = graph.Vertices.Find(5);
            Node three = graph.Vertices.Find(2);

            graph.AddEdge(one, two, 1);
            graph.AddEdge(one, three, 1);

            Tuple<Node, int> tTwo = new Tuple<Node, int>(graph.Vertices.Find(5), 1);
            Tuple<Node, int> tThree = new Tuple<Node, int>(graph.Vertices.Find(2), 1);

            List<Tuple<Node, int>> list = new List<Tuple<Node, int>>();
            list.Add(tTwo);
            list.Add(tThree);

            Assert.Equal(list, graph.GetNeighbors(one));
        }

        /// <summary>
        /// Neighbors are returned with the weight between nodes included
        /// </summary>
        [Fact]
        public void CanReturnNeighborsWithWeights()
        {
            Graph graph = new Graph();
            graph.AddNode(10);
            graph.AddNode(5);
            graph.AddNode(2);

            Node one = graph.Vertices.Find(10);
            Node two = graph.Vertices.Find(5);
            Node three = graph.Vertices.Find(2);

            graph.AddEdge(one, two, 20);
            graph.AddEdge(one, three, 30);

            Tuple<Node, int> tTwo = new Tuple<Node, int>(graph.Vertices.Find(5), 20);
            Tuple<Node, int> tThree = new Tuple<Node, int>(graph.Vertices.Find(2), 30);

            List<Tuple<Node, int>> list = new List<Tuple<Node, int>>();
            list.Add(tTwo);
            list.Add(tThree);

            Assert.Equal(list, graph.GetNeighbors(one));
        }

        /// <summary>
        /// The proper size is returned, representing the number of nodes in the graph
        /// </summary>
        [Fact]
        public void CanReturnSize()
        {
            Graph graph = new Graph();
            graph.AddNode(10);
            graph.AddNode(5);
            graph.AddNode(2);
            Assert.Equal(3, graph.Size());
        }

        /// <summary>
        /// A graph with only one node and edge can be properly returned
        /// </summary>
        [Fact]
        public void CanReturnSingleNodeAndEdge()
        {
            Graph graph = new Graph();
            graph.AddNode(10);

            Node one = graph.Vertices.Find(10);

            graph.AddEdge(one, one, 10);

            Tuple<Node, int> tOne = new Tuple<Node, int>(graph.Vertices.Find(10), 10);

            List<Tuple<Node, int>> list = new List<Tuple<Node, int>>();
            list.Add(tOne);

            Assert.Equal(list, graph.GetNeighbors(one));
            }

        /// <summary>
        /// An empty graph properly returns null
        /// </summary>
        [Fact]
        public void CanReturnNull()
        {
            Graph graph = new Graph();
            List<Node> list = new List<Node>();
            Assert.Equal(list, graph.GetNodes());
        }

    }
}
