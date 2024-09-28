namespace DevNotes.Library
{
    public class CustomFilterMethod
    {
        public List<T> MyCustomFilter<T>(List<T> array, Func<T, bool> predicate)
        {
            List<T> list = new List<T>();
            foreach (T item in array)
            {
                if (predicate(item)) list.Add(item);
            }

            return list;
        }
    }
}
