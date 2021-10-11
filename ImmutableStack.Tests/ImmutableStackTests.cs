using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ImmutableStack.Library;

namespace ImmutableStack.Tests
{
    [TestClass]
    public class ImmutableStacksTests
    {
        [TestMethod]
        public void canPopOff1Item()
        {
            var previousStack = new ImmutableStack<string>();
            var modifiedStack = previousStack.Push("foo");
            Assert.AreEqual(0, previousStack.Count);
            Assert.AreEqual(1, modifiedStack.Count);

            Assert.AreEqual("foo", modifiedStack.Peek());
            Assert.AreEqual("foo", modifiedStack.Peek());

            var emptyStack = modifiedStack.Pop();
            Assert.AreEqual(0, previousStack.Count);
            Assert.AreEqual(0, emptyStack.Count);
            Assert.AreEqual(1, modifiedStack.Count);
        }

        [TestMethod]
        public void canPopOff2Items()
        {
            var previousStack = new ImmutableStack<string>();
            var modifiedStack = previousStack.Push("foo");
            var modifiedStack2 = modifiedStack.Push("bar");
            Assert.AreEqual(0, previousStack.Count);
            Assert.AreEqual(1, modifiedStack.Count);
            Assert.AreEqual(2, modifiedStack2.Count);

            Assert.AreEqual("foo", modifiedStack.Peek());
            Assert.AreEqual("foo", modifiedStack.Peek());
            Assert.AreEqual("bar", modifiedStack2.Peek());
            Assert.AreEqual("bar", modifiedStack2.Peek());

            var emptyStack = modifiedStack.Pop();
            Assert.AreEqual(0, previousStack.Count);
            Assert.AreEqual(0, emptyStack.Count);
            Assert.AreEqual(1, modifiedStack.Count);

            var stack1Item = modifiedStack2.Pop();
            Assert.AreEqual(0, previousStack.Count);
            Assert.AreEqual(1, modifiedStack.Count);
            Assert.AreEqual(2, modifiedStack2.Count);
            Assert.AreEqual(1, stack1Item.Count);
        }
        
    }
}
