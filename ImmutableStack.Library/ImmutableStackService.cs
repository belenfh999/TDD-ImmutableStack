using System;
using System.Collections.Generic;

namespace ImmutableStack.Library
{
    public class ImmutableStack<T>
    {
        private int elementsCount;
        private T element;
        public ImmutableStack()
        {
            elementsCount = 0;
            element = default(T);
        }
        public ImmutableStack(int count, T element)
        {
            elementsCount = count;
            this.element = element;
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
            return new ImmutableStack<T>(elementsCount + 1, element);
        }

        public T Peek()
        {
            return element;
        }
    }
}
