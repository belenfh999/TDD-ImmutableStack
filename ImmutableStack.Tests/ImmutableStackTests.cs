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

    }
}
