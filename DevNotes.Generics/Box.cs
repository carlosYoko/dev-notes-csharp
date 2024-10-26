namespace DevNotes.Generics
{
    public class Box<T>
    {
        private readonly T _value;

        public Box(T value)
        {
            _value = value;
        }

        public string GetContent()
        {
            return _value.ToString();
        }
    }
}
