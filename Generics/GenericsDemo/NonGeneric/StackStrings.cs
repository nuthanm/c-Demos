namespace GenericsDemo
{
    public class StackStrings
    {        
        private readonly string[] _items;
        private int _currentIndex = -1;
        public StackStrings() => _items = new string[10]; // Expression body format

        public int Count => _currentIndex + 1;

        public void Push(string item) => _items[++_currentIndex] = item;

        public string Pop() => _items[_currentIndex--];        
    }
}