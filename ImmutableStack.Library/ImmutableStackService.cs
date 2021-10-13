using System;
using System.Collections.Generic;

namespace ImmutableStack.Library
{
    public class ImmutableStack<T>
    {
        private int elementsCount;

        public ImmutableStack()
        {
            elementsCount = 0;
        }
        public ImmutableStack(int count)
        {
            elementsCount = count;
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
            return new ImmutableStack<T>(1);
        }
    }
}
