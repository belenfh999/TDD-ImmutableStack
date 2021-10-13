using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ImmutableStack.Library;

namespace ImmutableStack.Tests
{
    [TestClass]
    public class ImmutableStacksTests
    {
        [TestMethod]
        public void canPush1Item()
        {
            var previousStack = new ImmutableStack<string>();
            var modifiedStack = previousStack.Push("foo");
            Assert.AreEqual(0, previousStack.Count);
            Assert.AreEqual(1, modifiedStack.Count);
        }
        [TestMethod]
        public void CanPeekItem()
        {
            var previousStack = new ImmutableStack<string>();
            var modifiedStack = previousStack.Push("foo");
            Assert.AreEqual("foo", modifiedStack.Peek());
            Assert.AreEqual("foo", modifiedStack.Peek());

        }

        [TestMethod]
        public void PopOffItem()
        {
            var previousStack = new ImmutableStack<string>();
            var modifiedStack = previousStack.Push("foo")
                                             .Push("bar");
            var modifiedStack2 = modifiedStack.Pop();
            var emptyStack = modifiedStack2.Pop();
            Assert.AreEqual(2, modifiedStack.Count);
            Assert.AreEqual(1, modifiedStack2.Count);
            Assert.AreEqual(0, emptyStack.Count);
        }

        [TestMethod]
        public void PopOffAndPeekItem()
        {
            var previousStack = new ImmutableStack<string>();
            var modifiedStack = previousStack.Push("foo")
                                             .Push("bar");
            var modifiedStack2 = modifiedStack.Pop();
            var emptyStack = modifiedStack2.Pop();
            Assert.AreEqual(2, modifiedStack.Count);
            Assert.AreEqual(1, modifiedStack2.Count);
            Assert.AreEqual(0, emptyStack.Count);

            Assert.AreEqual("foo", modifiedStack2.Peek());
            Assert.AreEqual(default(string), emptyStack.Peek());

        }

        [TestMethod]
        public void PopOffEmptylist()
        {
            var emptyStack = new ImmutableStack<string>();
            Assert.AreEqual(default(string), emptyStack.Pop());
        }
    }
}
