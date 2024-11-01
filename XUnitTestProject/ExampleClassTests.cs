namespace XUnitTestProject;

public class ExampleClassTests
{
    [Fact]
    public void ExampleTest_True()
    {
        // Arrange
        bool valueTrue;

        // Act
        valueTrue = true;

        // Assert
        Assert.True(valueTrue);
    }
}