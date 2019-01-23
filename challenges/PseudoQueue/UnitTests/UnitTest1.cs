using System;
using Xunit;
using PseudoQueue.Classes;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that Node constructs a new node with passed-in int value
        /// </summary>
        [Fact]
        public void Node_ConstructsNodeWithIntValue()
        {
            Node<int> node = new Node<int>(5);
            Assert.Equal(5, node.Value);
        }

        /// <summary>
        /// verifies that Node constructs a new node with passed-in int value
        /// </summary>
        [Fact]
        public void Node_ConstructsNodeWithStringValue()
        {
            Node<string> node = new Node<string>("five");
            Assert.Equal("five", node.Value);
        }

        /// <summary>
        /// verifies that Stack constructs a valid stack with Top = null
        /// </summary>
        [Fact]
        public void Stack_ConstructsEmptyStack()
        {
            Stack<int> stack = new Stack<int>();
            Assert.Null(stack.Top);
        }

        /// <summary>
        /// verifies that Push creates a new node with the correct value and places it as Top
        /// </summary>
        [Fact]
        public void Push_InsertsNodeWithCorrectValue()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            Assert.Equal(5, stack.Top.Value);
        }

        /// <summary>
        /// verifies that Pop returns the Top node
        /// </summary>
        [Fact]
        public void Pop_ReturnsCorrectValue()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            Assert.Equal(5, stack.Pop().Value);
        }

        /// <summary>
        /// verifies that Pop returns Null when the stack is empty
        /// </summary>
        [Fact]
        public void Pop_ReturnsNullWhenEmptyStack()
        {
            Stack<int> stack = new Stack<int>();
            Assert.Null(stack.Pop());
        }

        /// <summary>
        /// verifies that Pop properly reassigns Top to next node 
        /// </summary>
        [Fact]
        public void Pop_ReassignsTopToNextNode()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(3);
            stack.Pop();
            Assert.Equal(5, stack.Top.Value);
        }

        /// <summary>
        /// verifies that Peek returns node value
        /// </summary>
        [Fact]
        public void Peek_ReturnsCorrectValue()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            Assert.Equal(5, stack.Peek().Value);
        }

        /// <summary>
        /// verifies that Peek returns value of correct (Top) node
        /// </summary>
        [Fact]
        public void Peek_ReturnsTopValue()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(3);
            Assert.Equal(3, stack.Peek().Value);
        }

        /// <summary>
        /// verifies that Peek returns Null when empty stack
        /// </summary>
        [Fact]
        public void Peek_ReturnsNullWhenEmpty()
        {
            Stack<int> stack = new Stack<int>();
            Assert.Null(stack.Peek());
        }

        /// <summary>
        /// verifies that PseudoQ constructor builds pseudoqueue with null Front
        /// </summary>
        [Fact]
        public void PseudoQ_ConstructsNewPseudoqueueWithNullFront()
        {
            PseudoQ<int> qu = new PseudoQ<int>();
            Assert.Null(qu.Front);
        }

        /// <summary>
        /// verifies that PseudoQ constructor builds pseudoqueue with null Rear
        /// </summary>
        [Fact]
        public void PseudoQ_ConstructsNewPseudoqueueWithNullRear()
        {
            PseudoQ<int> qu = new PseudoQ<int>();
            Assert.Null(qu.Rear);
        }

        /// <summary>
        /// verifies that PseudoQ constructor instantiates Frontend stack
        /// </summary>
        [Fact]
        public void PseudoQ_BuildsFrontendStack()
        {
            PseudoQ<int> qu = new PseudoQ<int>();
            Assert.Null(qu.Frontend.Top);
        }

        /// <summary>
        /// verifies that PseudoQ constructor instantiates Frontend stack
        /// </summary>
        [Fact]
        public void PseudoQ_BuildsBackendStack()
        {
            PseudoQ<int> qu = new PseudoQ<int>();
            Assert.Null(qu.Backend.Top);
        }

        /// <summary>
        /// verifies that Offload empties the stack passed in as donor
        /// </summary>
        [Fact]
        public void Offload_EmptiesFromStack()
        {
            PseudoQ<int> qu = new PseudoQ<int>();
            qu.Enqueue(5);
            qu.Enqueue(3);
            qu.Enqueue(1);
            qu.Offload(qu.Frontend, qu.Backend);
            Assert.Null(qu.Frontend.Top);
        }

        /// <summary>
        /// verifies that Offload exposes the bottom of the stack passed in as donor
        /// </summary>
        [Fact]
        public void Offload_ExposesBottomOfFromStack()
        {
            PseudoQ<int> qu = new PseudoQ<int>();
            qu.Enqueue(5);
            qu.Enqueue(3);
            qu.Enqueue(1);
            qu.Offload(qu.Frontend, qu.Backend);
            Assert.Equal(5,qu.Backend.Top.Value);
        }

        /// <summary>
        /// verifies that Enqueue adds new node to top of loaded Frontend
        /// (bottom of loaded Frontend is effective 'Rear')
        /// </summary>
        [Fact]
        public void Enqueue_AddsNewRear()
        {
            PseudoQ<int> qu = new PseudoQ<int>();
            qu.Enqueue(5);
            qu.Enqueue(3);
            qu.Enqueue(1);
            Assert.Equal(1, qu.Frontend.Top.Value);
        }

        /// <summary>
        /// verifies that Enqueue adds new node to top of loaded Frontend
        /// (bottom of loaded Frontend is effective 'Rear')
        /// </summary>
        [Fact]
        public void Enqueue_PointsNewRearAtPriorRear()
        {
            PseudoQ<int> qu = new PseudoQ<int>();
            qu.Enqueue(5);
            qu.Enqueue(3);
            qu.Enqueue(1);
            Assert.Equal(3, qu.Frontend.Top.Next.Value);
        }

        /// <summary>
        /// verifies that Dequeue returns value of node at bottom of Frontend stack
        /// </summary>
        [Fact]
        public void Dequeue_ReturnsFrontNode()
        {
            PseudoQ<int> qu = new PseudoQ<int>();
            qu.Enqueue(5);
            qu.Enqueue(3);
            qu.Enqueue(1);
            Node<int> removed = qu.Dequeue();
            Assert.Equal(5, removed.Value);
        }

        /// <summary>
        /// verifies that Dequeue reassigns Top of Frontend stack to next in line
        /// </summary>
        [Fact]
        public void Dequeue_ReassignsFrontendTop()
        {
            PseudoQ<int> qu = new PseudoQ<int>();
            qu.Enqueue(5);
            qu.Enqueue(3);
            qu.Enqueue(1);
            qu.Dequeue();
            Assert.Equal(3, qu.Backend.Top.Value);
        }
    }
}
