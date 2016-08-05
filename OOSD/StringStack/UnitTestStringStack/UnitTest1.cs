using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringStack;

namespace UnitTestStringStack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmpty_NewStack_ReturnsTrue()
        {
            Stack newStack = new Stack();            

            //assert IsEmpty will return true
            Assert.IsTrue(newStack.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_PoppedStack_ReturnsTrue()
        {
            Stack newStack = new Stack();
            newStack.Push("node 1");
            newStack.Pop();

            Assert.IsTrue(newStack.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_PoppedStackAndRepopulated_ReturnsFalse()
        {
            Stack newStack = new Stack();
            newStack.Push("node 1");
            newStack.Pop();
            newStack.Push("node 1");

            Assert.IsFalse(newStack.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Peek_EmptyStack_Exception()
        {

            Stack newStack = new Stack();

            newStack.Peek();
            
        }

        [TestMethod]
        public void Peek_AddSeveralItems_ReturnLastAddedItem()
        {
            Stack newStack = new Stack();

            newStack.Push("node 1");
            newStack.Push("node 2");
            newStack.Push("node 3");

            String expected = "node 3";
            String actual = newStack.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_Push4ItemsThenCount_Return4()
        {
            Stack newStack = new Stack();

            newStack.Push("node 1");
            newStack.Push("node 2");
            newStack.Push("node 3");
            newStack.Push("node 4");

            int expected = 4;
            int actual = newStack.Count();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void IsEmpty_StackWithItems_ReturnFalse()
        {
            Stack newStack = new Stack();

            newStack.Push("node 1");
            newStack.Push("node 2");
            newStack.Push("node 3");
            newStack.Push("node 4");

            Assert.IsFalse(newStack.IsEmpty());
        }

        [TestMethod]
        public void Count_PopAllItemsThenCount_Return0()
        {
            Stack newStack = new Stack();

            newStack.Push("node 1");
            newStack.Push("node 2");
            newStack.Push("node 3");
            newStack.Push("node 4");

            newStack.Pop();
            newStack.Pop();
            newStack.Pop();
            newStack.Pop();

            int expected = 0;
            int actual = newStack.Count();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Push_PushToEmptyStack_FirstItemAdded()
        {
            Stack newStack = new Stack();

            newStack.Push("node 1");

            String expected = "node 1";
            String actual = newStack.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Push_PushToPopulatedStack_NewItemAdded()
        {
            Stack newStack = new Stack();

            newStack.Push("node 1");

            String expected = "node 1";
            String actual = newStack.Peek();

            Assert.AreEqual(expected, actual);

            newStack.Push("node 2");

            String expected2 = "node 2";
            String actual2 = newStack.Peek();

            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void Pop_StackWithItems_ItemReturned()
        {
            Stack newStack = new Stack();

            newStack.Push("node 1");
            newStack.Push("node 2");

            String expected = "node 2";
            String actual = newStack.Pop();

            Assert.AreEqual(expected, actual);
        }        

        [TestMethod]
        public void Pop_StackWithItems_ItemRemoved()
        {
            Stack newStack = new Stack();

            newStack.Push("node 1");
            newStack.Push("node 2");

            String expected = "node 2";
            String actual = newStack.Pop();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_NewlyCreatedStack_Return0()
        {
            Stack newStack = new Stack();

            int expected = 0;
            int actual = newStack.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_PeekDoesNotChangeCount_CountReturns2()
        {
            Stack newStack = new Stack();           

            newStack.Push("node 1");
            newStack.Push("node 2");

            newStack.Count();
            newStack.Peek();
            newStack.Count();

            int expected = 2;
            int actual = newStack.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Pop_EmptyStack_Exception()
        {
            Stack newStack = new Stack();

            newStack.Pop();
        }
        
    }
}
