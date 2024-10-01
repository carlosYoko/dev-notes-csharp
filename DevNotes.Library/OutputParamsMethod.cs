namespace DevNotes.Library
{
    public class OutputParamsMethod : IIsEvenOrOdd
    {

        public bool IsEven(int num, out int originNumber, out int squaredNumber)
        {
            originNumber = num;
            squaredNumber = num * num;

            if (num % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }

    public interface IIsEvenOrOdd
    {
        bool IsEven(int num, out int originNumber, out int squaredNumber);
    }
}
