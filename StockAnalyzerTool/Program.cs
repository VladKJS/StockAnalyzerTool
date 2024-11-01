using StockAnalyzerTool;

int n =4; // n-th highest price

int[] stockPrices = [15,11,9,4,7,11,9];

Console.WriteLine("Price Changes: " + stockPrices.Length);


int profit = ProfitAnalyzer.MaxProfit(stockPrices);
Console.WriteLine("Financial result from stock trading: " + profit);

int kthHighest = StockPriceProfitAnalyzer.FindKthHighest(stockPrices, n);
Console.WriteLine($"The {n}th highest stock price is: {kthHighest}");

Console.ReadLine();