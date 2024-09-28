using DevNotes.Library;
using Moq;

namespace DevNotes.Tests
{
    public class RandomGeneratorTests
    {
        [Fact]
        public void RandomGenerator_MockClass_Input1_5_Returns_2()
        {
            // Act
            var expected = 2;
            var randomGeneratorMock = new Mock<IRandomGenerator>();
            randomGeneratorMock.Setup(x => x.RandomNumber(It.IsAny<int>(), It.IsAny<int>())).Returns(expected);

            // Arrange
            var result = randomGeneratorMock.Object.RandomNumber(1, 5);

            // Assert
            Assert.Equal(result, expected);
        }

        [Fact]
        public void RandomGenerator_FakeClass_Input1_5_Returns_3()
        {
            // Act
            var expected = 3;
            var randomGeneratorFake = new RandomGeneratorFake(expected);

            // Arrange
            var result = randomGeneratorFake.Number;

            // Assert
            Assert.Equal(result, expected);
        }
    }

    public class RandomGeneratorFake : IRandomGenerator
    {
        public int Number { get; set; }

        public RandomGeneratorFake(int fakeResult)
        {
            Number = fakeResult;
        }

        public int RandomNumber(int min, int max)
        {
            return Number;
        }
    }
}
