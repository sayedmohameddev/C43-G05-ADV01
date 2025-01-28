using System;

namespace C43_G05_ADV01
{
    #region Q-04
    class FixedSizeList<T>
    {
       
        private T[] _items;
        private int _currentIndex;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }

            _items = new T[capacity];
            _currentIndex = 0;
        }

        public void Add(T item)
        {
            if (_currentIndex >= _items.Length)
            {
                throw new InvalidOperationException("The list is full. Cannot add more items.");
            }

            _items[_currentIndex] = item;
            _currentIndex++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _currentIndex)
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }

            return _items[index];
        }

        public int Count
        {
            get { return _currentIndex; }
        }
        #endregion
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                #region Q-04
                FixedSizeList<int> list = new FixedSizeList<int>(3);

                list.Add(1);
                list.Add(2);
                list.Add(3);


                Console.WriteLine("Item at index 0: " + list.Get(0));
                Console.WriteLine("Item at index 1: " + list.Get(1));
                Console.WriteLine("Item at index 2: " + list.Get(2));


                Console.WriteLine("Current list size: " + list.Count);
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
