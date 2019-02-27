using System;
using Xunit;
using get_edges;
using graph.Classes;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that valid single-leg itinerary returns correctly
        /// </summary>
        [Fact]
        public void TestItineraryOne()
        {
            string[] cities = new string[] { "Pandora", "Narnia", "Metroville", "Arendelle", "Monstropolis", "Naboo" };
            Graph connections = Program.BuildGraph(cities);
            string[] itinerary = new string[] { "Metroville", "Pandora" };
            Tuple<bool, int> ticket = new Tuple<bool, int>(true, 82);
            Assert.Equal(ticket, Program.GetEdge(connections, itinerary));
        }

        /// <summary>
        /// verifies that vali multi-leg itinerary returns correctly
        /// </summary>
        [Fact]
        public void TestItineraryTwo()
        {
            string[] cities = new string[] { "Pandora", "Narnia", "Metroville", "Arendelle", "Monstropolis", "Naboo" };
            Graph connections = Program.BuildGraph(cities);
            string[] itinerary = new string[] { "Arendelle", "Monstropolis", "Naboo" };
            Tuple<bool, int> ticket = new Tuple<bool, int>(true, 115);
            Assert.Equal(ticket, Program.GetEdge(connections, itinerary));
        }

        /// <summary>
        /// verifies that invalid single-leg itinerary returns correctly
        /// </summary>
        [Fact]
        public void TestItineraryThree()
        {
            string[] cities = new string[] { "Pandora", "Narnia", "Metroville", "Arendelle", "Monstropolis", "Naboo" };
            Graph connections = Program.BuildGraph(cities);
            string[] itinerary = new string[] { "Naboo", "Pandora" };
            Tuple<bool, int> ticket = new Tuple<bool, int>(false, 0); Assert.Equal(ticket, Program.GetEdge(connections, itinerary));
        }

        /// <summary>
        /// verifies that invalid multi-leg itinerary returns correctly
        /// </summary>
        [Fact]
        public void TestItineraryFour()
        {
            string[] cities = new string[] { "Pandora", "Narnia", "Metroville", "Arendelle", "Monstropolis", "Naboo" };
            Graph connections = Program.BuildGraph(cities);
            string[] itinerary = new string[] { "Narnia", "Arendelle", "Naboo" };
            Tuple<bool, int> ticket = new Tuple<bool, int>(false, 0);
            Assert.Equal(ticket, Program.GetEdge(connections, itinerary));
        }
    }
}
