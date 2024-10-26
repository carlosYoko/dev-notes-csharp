namespace DevNotes.Generics
{
    public class Box<T>
    {
        private T _value;

        public Box(T value)
        {
            _value = value;
        }

        public string GetContent()
        {
            return _value.ToString();
        }

        public T Get()
        {
            return _value;
        }

        public void Set(T value)
        {
            _value = value;
        }
    }
}
