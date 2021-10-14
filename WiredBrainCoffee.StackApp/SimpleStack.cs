using System;

namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack
    {
        private double[] items;
        private int _currentIndex = -1;
        public SimpleStack()
        {
            items = new double[10];
        }

        public int Count => _currentIndex + 1;

        public void Push(double item)
        {
            items[++_currentIndex] = item;
        }

        public double Pop()
        {
            return items[_currentIndex--];
        }
    }
}