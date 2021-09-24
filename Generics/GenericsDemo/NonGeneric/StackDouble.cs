namespace GenericsDemo
{
    public class StackDouble
    {
        private readonly double[] _items;
        private int _currentIndex = -1;
        public StackDouble() => _items = new double[10]; // Expression body format

        public int Count => _currentIndex + 1;

        public void Push(double item) => _items[++_currentIndex] = item;

        public double Pop() => _items[_currentIndex--];
    }
}