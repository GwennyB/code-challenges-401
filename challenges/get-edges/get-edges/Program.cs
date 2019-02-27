using System;
using graph.Classes;
using linked_list.Classes;

namespace get_edges
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[] { "Pandora", "Narnia", "Metroville", "Arendelle", "Monstropolis", "Naboo" };
            Graph connections = BuildGraph(cities);
            string[] itinerary = new string[] { };
            Tuple<bool, int> ticket = GetEdge(connections, itinerary);
            Console.Write("Requested itinerary: ");
            foreach (var item in itinerary)
            {
                Console.Write($" {item} ->");
            }
            Console.Write($"Possible: {ticket.Item1}, Cost: ${ticket.Item2}");
            Console.ReadLine();
        }

        public static Tuple<bool,int> GetEdge(Graph connections, string[] cities)
        {
            int cost = 0;
            Node temp = null;
            Tuple<Node,int> tempNext = null;
            for (int i = 0; i < cities.Length-2; i++)
            {
                temp = connections.Vertices.Find(cities[i]);
                if (temp == null) return new Tuple<bool, int>(false,0);
                tempNext = temp.Neighbors.Find(c => (string)c.Item1.Value == cities[i + 1]);
                if (tempNext == null) return new Tuple<bool, int>(false, 0);
                cost += tempNext.Item2;
            }
            return new Tuple<bool, int>(true, cost);
        }

        public static Graph BuildGraph(string[] cities)
        {
            Graph connections = new Graph();
            foreach (var item in cities)
            {
                connections.AddNode(item);
            }
            Node pandora = connections.Vertices.Find(cities[0]);
            Node narnia = connections.Vertices.Find(cities[1]);
            Node metroville = connections.Vertices.Find(cities[2]);
            Node arendelle = connections.Vertices.Find(cities[3]);
            Node monstropolis = connections.Vertices.Find(cities[4]);
            Node naboo = connections.Vertices.Find(cities[5]);
            connections.AddEdge(pandora, arendelle, 150);
            connections.AddEdge(pandora, metroville, 82);
            connections.AddEdge(narnia, metroville, 37);
            connections.AddEdge(narnia,naboo,250);
            connections.AddEdge(metroville,pandora,82);
            connections.AddEdge(metroville,narnia,37);
            connections.AddEdge(metroville, naboo, 26);
            connections.AddEdge(metroville,monstropolis,105);
            connections.AddEdge(metroville,arendelle,99);
            connections.AddEdge(naboo, narnia,250);
            connections.AddEdge(naboo, metroville,26);
            connections.AddEdge(naboo, monstropolis, 73);
            connections.AddEdge(monstropolis, naboo, 73);
            connections.AddEdge(monstropolis, metroville, 105);
            connections.AddEdge(monstropolis, arendelle, 42);
            connections.AddEdge(arendelle, monstropolis, 42);
            connections.AddEdge(arendelle, metroville, 99);
            connections.AddEdge(arendelle, pandora, 150);

            return connections;
        }
    }
}
