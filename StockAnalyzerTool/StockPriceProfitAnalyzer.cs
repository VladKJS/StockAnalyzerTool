namespace StockAnalyzerTool;

public sealed class StockPriceProfitAnalyzer
{
    public static int FindKthHighest(int[] prices, int n)
    {
        if (n <= 0 || n > prices.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(n), "n must be between 1 and the length of the prices array.");
        }

        HashSet<int> highestPrice = new();

        foreach (var price in prices)
        {
            highestPrice.Add(price);

            if (highestPrice.Count > n)
            {
                highestPrice.Remove(highestPrice.Min());
            }
        }

        return highestPrice.Min();
    }

    public static int FindKthHighestSecondApproach(int[] prices, int k)
    {
            var uniquePrices = prices.Distinct().ToArray();
            int n = uniquePrices.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;

                // Find the maximum element in the unsorted part
                for (int j = i + 1; j < n; j++)
                {
                    if (uniquePrices[j] > uniquePrices[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                // Swap the found maximum element with the first element
                int temp = uniquePrices[maxIndex];
                uniquePrices[maxIndex] = uniquePrices[i];
                uniquePrices[i] = temp;
            }
            return uniquePrices[k-1];
    }
    
}
