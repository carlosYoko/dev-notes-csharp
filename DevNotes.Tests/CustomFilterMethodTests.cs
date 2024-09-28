using DevNotes.Library;

namespace DevNotes.Tests
{
    public class CustomFilterMethodTests
    {
        [Fact]
        public void CustomFilterMethod_InputRandomNumbers_Returns_EvenList()
        {
            // Act
            var myCustomFilter = new CustomFilterMethod();

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> expected = new List<int>() { 2, 4, 6 };

            // Arrange
            var result = myCustomFilter.MyCustomFilter(list, (n) => n % 2 == 0);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
