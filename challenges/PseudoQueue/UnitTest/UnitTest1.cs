using System;
using Xunit;
using PseudoQueue.Classes;


namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Node_ConstructsNodeWithCorrectValue()
        {
            Node<int> node = new Node<int>(5);
            Assert.Equal(5, node.Value);
        }
    }
}
