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
    }
}
