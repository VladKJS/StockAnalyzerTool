namespace StockAnalyzerTool;

public sealed class ProfitAnalyzer
{
    public static int MaxProfit(int[] prices)
    {
        if (prices == null || prices.Length < 2)
        {
            return 0;
        }

        int minPrice = prices[0];
        int maxProfit = 0;
        int loss = 0;
                
        for (int i = 1; i < prices.Length; i++)
        {
            loss = prices[i] - minPrice;

            if (loss > maxProfit)
            {
                maxProfit = loss;
            }

            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
        }

        return maxProfit > 0 ? maxProfit : loss;
    }

}