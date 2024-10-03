using DevNotes.Library;

namespace DevNotes.Tests
{
    public class ClassBaseTests
    {
        [Fact]
        public void DogSays_ShouldOutputCorrectMessage()
        {
            // Arrange
            var dog = new Dog("Buddy", "Woof");
            var expectedOutput = "The animal says: Woof\r\n";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            dog.DogSays();

            // Assert
            var output = stringWriter.ToString();
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void DogName_ShouldOutputCorrectName()
        {
            // Arrange
            var dog = new Dog("Buddy", "Woof");
            var expectedOutput = "Buddy\r\n";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            dog.DogName();

            // Assert
            var output = stringWriter.ToString();
            Assert.Equal(expectedOutput, output);
        }
    }
}
