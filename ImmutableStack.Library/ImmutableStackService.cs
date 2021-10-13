using System;
using System.Collections.Generic;

namespace ImmutableStack.Library
{
    public class ImmutableStack<T>
    {
        private int elementsCount;
        private T element;
        private ImmutableStack<T> previousStack;
        public ImmutableStack()
        {
            elementsCount = 0;
            element = default(T);
            previousStack = null;
        }
        public ImmutableStack(int count, T element, ImmutableStack<T> previousStack)
        {
            elementsCount = count;
            this.element = element;
            this.previousStack = previousStack;
        }

        public int Count
        {
            get
            {
                return elementsCount;
            }
        }
        public ImmutableStack<T> Push(T element)
        {
            return new ImmutableStack<T>(elementsCount + 1, element, this);
        }

        public T Peek()
        {
            return element;
        }

        public ImmutableStack<T> Pop()
        {
            return previousStack;
        }
    }
}
