using System;

namespace WiredBrainCoffee.StackApp
{
    public class SimpleStackDouble
    {
        private double[] items;
        private int _currentIndex = -1;
        public SimpleStackDouble()
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

    public class SimpleStackString
    {
        private string[] items;
        private int _currentIndex = -1;
        public SimpleStackString()
        {
            items = new string[10];
        }

        public int Count => _currentIndex + 1;

        public void Push(string item)
        {
            items[++_currentIndex] = item;
        }

        public string Pop()
        {
            return items[_currentIndex--];
        }
    }
}