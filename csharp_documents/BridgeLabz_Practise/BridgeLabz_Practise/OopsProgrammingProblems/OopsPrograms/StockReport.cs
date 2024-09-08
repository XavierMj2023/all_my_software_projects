using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopsProgrammingProblems.OopsPrograms
{
    public class Stock
    {
        public string StockNames { get; set; }
        public int NumberOfShares { get; set; }
        public double SharePrice { get; set; }

        public double CalculateStockValue()
        {
            return NumberOfShares * SharePrice;
        }
    }
    public class StockPortfolio
    {
        private List<Stock> stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
        }

        public double CalculateTotalPortfolioValue()
        {
            double totalValue = 0;
            foreach (Stock stock in stocks)
            {
                totalValue += stock.CalculateStockValue();
            }
            return totalValue;
        }
        public void PrintStockReport()
        {
            Console.WriteLine("Stock Report:");
            Console.WriteLine("-----------------------------------------------------");
            foreach (Stock stock in stocks)
            {
                double stockValue = stock.CalculateStockValue();
                Console.WriteLine($"Stock: {stock.StockNames}, Number of Shares: {stock.NumberOfShares}, Share Price: ${stock.SharePrice}, Stock Value: ${stockValue:F2}");
            }
            double totalPortfolioValue = CalculateTotalPortfolioValue();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Total Portfolio Value: ${totalPortfolioValue:F2}");
        }
        public void PrintStockInTabularFormat()
        {
            Console.WriteLine("Stock Report:");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0, -20} {1, -15} {2, -15} {3, -15}", "Stock Name", "No of Shares", "Share Price", "Stock Value");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            foreach (Stock stock in stocks)
            {
                Console.WriteLine("{0, -20} {1, -15} {2, -15:C2} {3, -15:C2}", stock.StockNames, stock.NumberOfShares, stock.SharePrice, stock.CalculateStockValue());
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            double totalPortfolioValue = CalculateTotalPortfolioValue();
            Console.WriteLine("Total Portfolio Value: {0, -20:C2}", totalPortfolioValue);
        }
    }
    public class StockRead
    {
        public void ReadStocks()
        {
            StockPortfolio portfolio = new StockPortfolio();

            Console.Write("Enter the name of the input file: ");
            string inputFileName = Console.ReadLine();

            if (File.Exists(inputFileName))
            {
                string[] lines = File.ReadAllLines(inputFileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string name = parts[0].Trim();
                        int numberOfShares = int.Parse(parts[1].Trim());
                        double sharePrice = double.Parse(parts[2].Trim());

                        Stock stock = new Stock
                        {
                            StockNames = name,
                            NumberOfShares = numberOfShares,
                            SharePrice = sharePrice
                        };

                        portfolio.AddStock(stock);
                    }
                }

                // portfolio.PrintStockReport();
                portfolio.PrintStockInTabularFormat();
            }
            else
            {
                Console.WriteLine("The input file does not exist.");
            }
        }
    }
    public class StockReport
    {
        public static void GetStocks()
        {
            StockRead sr = new StockRead();
            sr.ReadStocks();
        }
        public static void GetStocksInTableFormat()
        {
            StockRead sr = new StockRead();
            sr.ReadStocks();
        }
    }
}
