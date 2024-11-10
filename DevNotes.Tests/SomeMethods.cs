using DevNotes.Library;

namespace DevNotes.Tests
{
    public class SomeMethodsTests
    {
        [Fact]
        void AddSeveralParams_Input_Several_Nums_Returns_Add()
        {
            // Act
            SomeMethods someMethods = new SomeMethods();
            double[] twoParams = { 4, 4 };
            double[] sixParams = { 2, 2, 2, 1, 1, 1 };

            // Arrange
            var resultTwoParams = someMethods.AddSeveralParams(twoParams);
            var resultSixParams = someMethods.AddSeveralParams(sixParams);

            // Assert
            Assert.Equal(8, resultTwoParams);
            Assert.Equal(9, resultSixParams);
        }
    }
}
