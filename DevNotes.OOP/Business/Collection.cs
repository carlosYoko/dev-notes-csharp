namespace DevNotes.OOP.Business
{
    public class Collection<T>
    {
        private T[] _elements;
        private int _index;
        private int _limit;

        public Collection(int limit)
        {
            _index = 0;
            _limit = limit;
            _elements = new T[_limit];
        }

        public void Add(T item)
        {
            if (_index < _limit)
            {
                _elements[_index] = item;
                _index++;
            }
        }

        public T[] Get()
        {
            return _elements;
        }

    }

}
