using GitAdfInfo.Services;

namespace GitAdfInfoTest
{
    public class NumberServiceTests
    {
        private readonly NumberService _numberService;

        public NumberServiceTests()
        {
            _numberService = new NumberService();
        }

        [Fact]
        public void CalculateNumbers_ValidInput_ReturnsCorrectResults()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Act
            var result = _numberService.CalculateNumbers(numbers);

            // Assert
            Assert.Equal(15, result.Sum);
            Assert.Equal(1, result.Smallest);
            Assert.Equal(5, result.Largest);
            Assert.Equal(5, result.Count);
        }

        [Fact]
        public void CalculateNumbers_EmptyArray_ThrowsArgumentException()
        {
            // Arrange
            int[] numbers = { };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _numberService.CalculateNumbers(numbers));
        }

        [Fact]
        public void OrderNumbers_ValidInput_ReturnsOrderedArray()
        {
            // Arrange
            int[] numbers = { 5, 3, 1, 4, 2 };

            // Act
            var result = _numberService.OrderNumbers(numbers);

            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [Fact]
        public void OrderNumbers_NullArray_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => _numberService.OrderNumbers(null));
        }
    }

}