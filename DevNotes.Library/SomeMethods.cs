namespace DevNotes.Library
{
    public class SomeMethods
    {
        public double AddSeveralParams(params double[] n)
        {
            double result = 0;

            foreach (var i in n)
            {
                result += i;
            }

            return result;
        }
    }
}
