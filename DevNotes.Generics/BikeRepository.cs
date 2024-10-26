namespace DevNotes.Generics
{
    public class BikeRepository : IRepository<string>
    {
        private string[] _bikes;
        private int _index;
        private const int QUANTITY = 10;

        public BikeRepository()
        {
            _bikes = new string[QUANTITY];
            _index = 0;
        }

        public void Add(string bike)
        {
            if (_index < QUANTITY)
            {
                _bikes[_index++] = bike;
            }
        }

        public IEnumerable<string> GetAll()
        {
            return _bikes;
        }
    }
}
