namespace GenericsDemo
{
    public class SimpleStack<T> // Where T might be any like Type, TypePlaceholder, any name
    {
        private readonly T[] _items;
        private int _currentIndex = -1;
        public SimpleStack() => _items = new T[10]; // Expression body format

        public int Count => _currentIndex + 1;

        public void Push(T item) => _items[++_currentIndex] = item;

        public T Pop() => _items[_currentIndex--];
    }
}