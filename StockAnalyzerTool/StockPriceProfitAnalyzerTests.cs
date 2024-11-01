using Xunit;

namespace StockAnalyzerTool;

public class StockPriceProfitAnalyzerTests
{
    [Fact]
    public void FindKthHighest_ValidInput_ReturnsKthHighest()
    {
        // Arrange
        int[] prices = { 5, 3, 9, 1, 7, 4 };
        int k = 2;

        // Act
        int result = StockPriceProfitAnalyzer.FindKthHighest(prices, k);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void FindKthHighest_ValidInput_ReturnsLowestWhenKIsOne()
    {
        // Arrange
        int[] prices = { 2, 8, 3, 10 };
        int k = 1;

        // Act
        int result = StockPriceProfitAnalyzer.FindKthHighest(prices, k);

        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void FindKthHighest_InputWithDuplicates_ReturnsCorrectKthHighest()
    {
        // Arrange
        int[] prices = { 5, 3, 9, 5, 7, 4, 7 };
        int k = 3;

        // Act
        int result = StockPriceProfitAnalyzer.FindKthHighest(prices, k);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void FindKthHighest_SingleElement_ReturnsThatElementWhenKIsOne()
    {
        // Arrange
        int[] prices = { 12 };
        int k = 1;

        // Act
        int result = StockPriceProfitAnalyzer.FindKthHighest(prices, k);

        // Assert
        Assert.Equal(12, result);
    }

    [Fact]
    public void FindKthHighest_KIsGreaterThanArrayLength_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        int[] prices = { 3, 8, 4 };
        int k = 4;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => StockPriceProfitAnalyzer.FindKthHighest(prices, k));
    }

    [Fact]
    public void FindKthHighest_KIsZero_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        int[] prices = { 1, 5, 9 };
        int k = 0;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => StockPriceProfitAnalyzer.FindKthHighest(prices, k));
    }

    [Fact]
    public void FindKthHighest_NegativeK_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        int[] prices = { 1, 5, 9 };
        int k = -2;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => StockPriceProfitAnalyzer.FindKthHighest(prices, k));
    }
}

