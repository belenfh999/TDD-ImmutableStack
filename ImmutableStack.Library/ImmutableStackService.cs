using System;
using System.Collections.Generic;

namespace ImmutableStack.Library
{
    public class ImmutableStack<T>
    {
        private List<T> _elements;

        public ImmutableStack()
        {
            _elements = new List<T>();
        }
        public ImmutableStack(List<T> stack)
        {
            _elements = stack;
        }
        public ImmutableStack<T> Push(T element)
        {
            var new_elements = new List<T>(_elements);
            new_elements.Add(element);
            return new ImmutableStack<T>(new_elements);
        }
        public int Count
        {
            get
            {
                return _elements.Count;
            }
        }
        public T Peek()
        {
            return _elements[_elements.Count - 1];
        }
        public ImmutableStack<T> Pop()
        {
            int lastElemIndex = _elements.Count - 1;
            T elem = _elements[lastElemIndex];
            var new_elements = new List<T>(_elements);
            new_elements.RemoveAt(lastElemIndex);
            return new ImmutableStack<T>(new_elements);

        }
    }
}
