namespace DevNotes.Library
{
    public class RandomGenerator : IRandomGenerator
    {
        public int Number { get; set; }
        Random Random = new Random();

        public RandomGenerator(int min, int max)
        {
            Number = RandomNumber(min, max);
        }

        public int RandomNumber(int min, int max)
        {
            return Random.Next(min, max);
        }
    }

    public interface IRandomGenerator
    {
        int RandomNumber(int min, int max);
    }
}
