using Xunit;

namespace StockAnalyzerTool;

public class ProfitAnalyzerTests
{
    [Fact]
    public void MaxProfit_ValidPrices_ReturnsCorrectMaxProfit()
    {
        // Arrange
        int[] prices = { 7, 1, 5, 3, 6, 4 };

        // Act
        int result = ProfitAnalyzer.MaxProfit(prices);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void MaxProfit_DescendingPrices_ReturnsZero()
    {
        // Arrange
        int[] prices = { 7, 6, 4, 3, 1 };

        // Act
        int result = ProfitAnalyzer.MaxProfit(prices);

        // Assert
        Assert.Equal(-2, result);
    }

    [Fact]
    public void MaxProfit_SinglePrice_ReturnsZero()
    {
        // Arrange
        int[] prices = { 5 };

        // Act
        int result = ProfitAnalyzer.MaxProfit(prices);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void MaxProfit_TwoPricesIncreasing_ReturnsDifference()
    {
        // Arrange
        int[] prices = { 3, 8 };

        // Act
        int result = ProfitAnalyzer.MaxProfit(prices);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void MaxProfit_TwoPricesDecreasing_ReturnsLoss()
    {
        // Arrange
        int[] prices = { 8, 3 };

        // Act
        int result = ProfitAnalyzer.MaxProfit(prices);

        // Assert
        Assert.Equal(-5, result);
    }

    [Fact]
    public void MaxProfit_EmptyPrices_ReturnsZero()
    {
        // Arrange
        int[] prices = Array.Empty<int>();

        // Act
        int result = ProfitAnalyzer.MaxProfit(prices);

        // Assert
        Assert.Equal(0, result);
    }
}

