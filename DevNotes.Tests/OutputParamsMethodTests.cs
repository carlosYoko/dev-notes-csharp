using DevNotes.Library;

namespace DevNotes.Tests
{
    public class OutputParamsMethodTests
    {
        [Fact]
        void OutputParamsMethod_Input_Even_Num_Reutrns_True()
        {
            // Act
            OutputParamsMethod outputParamsMethod = new OutputParamsMethod();
            int numberForTest = 2;
            int originNumber;
            int squaredNumber;

            // Arrange
            bool result = outputParamsMethod.IsEven(numberForTest, out originNumber, out squaredNumber);

            // Assert
            Assert.True(result);
            Assert.Equal(2, originNumber);
            Assert.Equal(4, squaredNumber);
        }
    }
}
