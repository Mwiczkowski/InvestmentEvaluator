using System;

namespace InvestmentEvaluator
{
    //Application that uses P/BV and P/E ratio to evaluate an investment in the stock market
    //Conditions that are taken into consideration are:(P/BV and P/E ratios, Impact of news about the company, Change in Earnings from Q to Q, Trend direction)
    //Where conditions must be at least: (P/BV<1 and P/E<8) + (Only positive news about the company) + (Earnings from Q to Q ++) + (Rising Trend) to succesfully identify a good investment.
    //If those conditions are not met, the investment is defined as risky.


    class Program
    {
        static void Main(string[] args)
        {
            string condition1 = "-P/BV and P/E ratios";
            string condition2 = "-Impact of news about the company";
            string condition3 = "-Change in Earnings from Q to Q";
            string condition4 = "-Trend direction";
            string companyname;
            decimal pbvratio;
            decimal peratio;
            decimal currentprice;


            Console.WriteLine("InvestmentEvaluator\t Version 0.0.1\t Author: Miłosz Wiczkowski\t");
            Console.WriteLine("InvestmentEvaluator uses P/BV and P/E ratio to evaluate the attractiveness of company shares in the stock market.\n");
            Console.WriteLine($"Evaluation will be done by taking the following conditions:\n {condition1}\n {condition2}\n {condition3}\n {condition4}\n");
            Console.WriteLine("Please, introduce the name of a company you wish to evaluate:");
            companyname = Console.ReadLine();
            Console.WriteLine($"Introduce the current P/BV ratio for {companyname}:");
            pbvratio = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Introduce the current P/E ratio for {companyname}:");
            peratio = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Introduce the current stock share price for {companyname}:");
            currentprice = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Did {companyname} make more profit comparing the last quarter with the 3 previous ones? Type 'yes' or 'no':");
            string earningsquestion = Console.ReadLine();
            Console.WriteLine($"Is the trend rising on price graph of {companyname}? Type 'yes' or 'no':");
            string trend = Console.ReadLine();


            if (pbvratio > 1 && peratio > 8 && trend == "no" && earningsquestion == "no")
                Console.WriteLine("Those shares are too risky to invest.");
            else if (pbvratio < 1 && peratio < 8 && trend == "yes" && earningsquestion == "yes")
                Console.WriteLine("Those shares seem to be a great opportunity to invest.");
            else if (pbvratio == 1 && peratio == 8)
                Console.WriteLine("The current price of the share is of it's real value and there is no occasion.");
            
        }
    }
}
