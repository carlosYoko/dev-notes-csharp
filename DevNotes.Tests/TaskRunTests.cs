using DevNotes.Library;

namespace DevNotes.Tests
{
    public class TaskRunTests
    {
        [Fact]
        public void Calculate_Returns_24()
        {
            // Arrange
            var taskRun = new TaskRun();

            // Act
            var result = taskRun.Calculate();

            // Assert
            Assert.Equal(24, result);
        }

        [Fact]
        public async Task CalculateTask_Returns_42_After_5_Seconds()
        {
            // Arrange
            var taskRun = new TaskRun();

            // Act
            var task = taskRun.CalculateTask();

            // Assert
            Assert.True(await Task.WhenAny(task, Task.Delay(6000)) == task, "CalculateTask did not complete in expected time.");
            Assert.Equal(42, await task);
        }
    }
}
