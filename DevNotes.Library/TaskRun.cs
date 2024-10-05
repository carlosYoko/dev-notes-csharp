namespace DevNotes.Library
{
    public class TaskRun
    {
        public async Task<int> CalculateTask()
        {
            return await Task.Run(() => this.CalculateAsync());
        }

        public int Calculate()
        {
            return 24;
        }

        private int CalculateAsync()
        {
            Thread.Sleep(5000);
            return 42;
        }

    }
}
