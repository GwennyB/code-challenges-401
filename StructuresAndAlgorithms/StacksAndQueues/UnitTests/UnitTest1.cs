using System;
using Xunit;
using StacksAndQueues.Classes;

namespace UnitTests
{
    public class UnitTest1
    {
        /// <summary>
        /// verifies that Node constructor can produce Node with specified int value, and that the value is retrievable
        /// </summary>
        [Fact]
        public void Node_MakesNodeFromInt()
        {
            Node<int> node = new Node<int>(5);
            Assert.Equal(5, node.Value);
        }

        /// <summary>
        /// verifies that Node constructor can produce Node with specified string value, and that the value is retrievable
        /// </summary>
        [Fact]
        public void Node_MakesNodeFromString()
        {
            Node<string> node = new Node<string>("widget");
            Assert.Equal("widget", node.Value);
        }

        /// <summary>
        /// verifies that Node constructor produces node with null Next reference
        /// </summary>
        [Fact]
        public void Node_MakesNodeWithNullNext()
        {
            Node<string> node = new Node<string>("widget");
            Assert.Null(node.Next);
        }


        /// <summary>
        /// verifies that Queue constructor can produce Queue with Front = null
        /// </summary>
        [Fact]
        public void Queue_MakesQueueWithNullFront()
        {
            Queue<int> queue = new Queue<int>();
            Assert.Null(queue.Front);
        }

        /// <summary>
        /// verifies that Queue constructor can produce Queue with Rear = null
        /// </summary>
        [Fact]
        public void Queue_MakesQueueWithNullRear()
        {
            Queue<int> queue = new Queue<int>();
            Assert.Null(queue.Rear);
        }

        /// <summary>
        /// verifies that Queue constructor can produce Queue with Front that can be redirected
        /// </summary>
        [Fact]
        public void Queue_MakesQueueWithSettableFront()
        {
            Queue<int> queue = new Queue<int>();
            Node<int> node = new Node<int>(5);
            queue.Front = node;
            Assert.Equal(5,queue.Front.Value);
        }

        /// <summary>
        /// verifies that Enqueue produces a new node of specified value
        /// </summary>
        [Fact]
        public void Enqueue_MakesNewNodeWithSpecifiedValue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            Assert.Equal(5,queue.Rear.Value);
        }

        /// <summary>
        /// verifies that Enqueue redirects Rear to the new node
        /// </summary>
        [Fact]
        public void Enqueue_RedirectsRear()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(0);
            Assert.Equal(0, queue.Rear.Value);
        }

        /// <summary>
        /// verifies that Enqueue redirects Rear to the new node
        /// </summary>
        [Fact]
        public void Enqueue_DirectsNewNodeToRear()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(0);
            Assert.Null(queue.Rear.Next);
        }

        /// <summary>
        /// verifies that Dequeue returns value of extracted node
        /// </summary>
        [Fact]
        public void Dequeue_ReturnsValueOfExtractedNode()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Enqueue(1);
            Assert.Equal(5, queue.Dequeue());
        }

        /// <summary>
        /// verifies that Dequeue redirects Front to next node in line
        /// </summary>
        [Fact]
        public void Dequeue_FrontRedirectsToNextInLine()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Dequeue();
            Assert.Equal(3, queue.Front.Value);
        }

        /// <summary>
        /// verifies that Dequeue disconnects extracted node from queue
        /// </summary>
        [Fact]
        public void Dequeue_MaintainsNextInLine()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Dequeue();
            Assert.Equal(1,queue.Front.Next.Value);
        }

        /// <summary>
        /// verifies that Peek returns Front even when null
        /// </summary>
        [Fact]
        public void Peek_ReturnsNull()
        {
            Queue<int> queue = new Queue<int>();
            Assert.Null(queue.Peek());
        }

        /// <summary>
        /// verifies that Peek returns Front when not null
        /// </summary>
        [Fact]
        public void Peek_ReturnsFront()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            Assert.Equal(5, queue.Peek().Value);
        }

        /// <summary>
        /// Verifies that Peek returns Front when queue has been manipulated by queueing and dequeueing nodes
        /// </summary>
        [Fact]
        public void Peek_ReturnsFrontAfterQueueChanges()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Dequeue();
            queue.Dequeue();
            Assert.Equal(1, queue.Peek().Value);
        }

        /// <summary>
        /// verifies that Stack constructor builds an empty stack of type Int
        /// </summary>
        [Fact]
        public void Stack_BuildsEmptyStackTypeInt()
        {
            Stack<int> stack = new Stack<int>();
            Assert.Null(stack.Peek());
        }

        /// <summary>
        /// verifies that Stack constructor builds an empty stack of type String
        /// </summary>
        [Fact]
        public void Stack_BuildsEmptyStackTypeString()
        {
            Stack<string> stack = new Stack<string>();
            Assert.Null(stack.Peek());
        }

        /// <summary>
        /// verifies that Stack constructor builds a Stack with Top settable to newly added node
        /// </summary>
        [Fact]
        public void Stack_BuildsStackWithSettableTop()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("test");
            Assert.Equal("test",stack.Peek().Value);
        }

        /// <summary>
        /// verifies that Push correctly adds a new node to Top of stack
        /// </summary>
        [Fact]
        public void Push_AddsSpecifiedNewNodeToTopOfStack()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("test");
            stack.Push("testTwo");
            Assert.Equal("testTwo", stack.Top.Value);
        }

        /// <summary>
        /// verifies that Pop returns the correct node
        /// </summary>
        [Fact]
        public void Pop_ReturnsTopNode()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("test");
            stack.Push("testTwo");
            Assert.Equal("testTwo", stack.Pop());
        }

        /// <summary>
        /// verifies that Pop correctly sets the next node in line to Top
        /// </summary>
        [Fact]
        public void Pop_SetsNextNodeAsTop()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("test");
            stack.Push("testTwo");
            stack.Pop();
            Assert.Equal("test", stack.Top.Value);
        }

        /// <summary>
        /// verifies that Peek returns Top when null
        /// </summary>
        [Fact]
        public void StackPeek_ReturnsNull()
        {
            Stack<int> stack = new Stack<int>();
            Assert.Null(stack.Peek());
        }

        /// <summary>
        /// verifies that Peek returns Top when not null
        /// </summary>
        [Fact]
        public void StackPeek_ReturnsTop()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            Assert.Equal(5, stack.Peek().Value);
        }

        /// <summary>
        /// Verifies that Peek returns Top when stack has been manipulated by pushing and popping nodes
        /// </summary>
        [Fact]
        public void StackPeek_ReturnsTopAfterStackChanges()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(3);
            stack.Push(1);
            stack.Pop();
            stack.Pop();
            Assert.Equal(5, stack.Peek().Value);
        }




    }
}
