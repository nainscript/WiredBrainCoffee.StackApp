using System;

namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack
    {
        private object[] items;
        private int _currentIndex = -1;
        public SimpleStack()
        {
            items = new object[10];
        }

        public int Count => _currentIndex + 1;

        public void Push(object item)
        {
            items[++_currentIndex] = item;
        }

        public object Pop()
        {
            return items[_currentIndex--];
        }
    }
}