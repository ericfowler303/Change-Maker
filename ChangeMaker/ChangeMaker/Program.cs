using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test inputs from homework
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);
            // Test much larger inputs and rounding
            ChangeMaker(348.382);
            ChangeMaker(123.456);
            // keep the console open
            Console.ReadKey();
        }
        /// <summary>
        /// Take a dollar amount and display the currency it would take to represent that amount
        /// </summary>
        /// <param name="amount">dollar value amount to be processed</param>
        static void ChangeMaker(double amount)
        {
            // Declare and initalize the counters to be used later
            int hundredDollarCounter = 0;
            int fiftyDollarCounter = 0;
            int twentyDollarCounter = 0;
            int tenDollarCounter = 0;
            int fiveDollarCounter = 0;
            int oneDollarCounter = 0;
            int quarterCounter = 0;
            int dimeCounter = 0;
            int nickelCounter = 0;
            int pennyCounter = 0;

            // Check to make sure the amount is valid
            if(amount > 0)
            {
                // Round the amount to two digits
                double roundedAmount = Math.Round(amount, 2);

                // Check to see how many hundred dollar bills are in the given amount
                while (roundedAmount >= 100.00)
                {
                    roundedAmount -= 100.00;
                    hundredDollarCounter++;
                }
                // Check to see how many fifty dollar bills are in the given amount
                while (roundedAmount >= 50.00)
                {
                    roundedAmount -= 50.00;
                    fiftyDollarCounter++;
                }
                // Check to see how many twenty dollar bills are in the given amount
                while (roundedAmount >= 20.00)
                {
                    roundedAmount -= 20.00;
                    twentyDollarCounter++;
                }
                // Check to see how many ten dollar bills are in the given amount
                while (roundedAmount >= 10.00)
                {
                    roundedAmount -= 10.00;
                    tenDollarCounter++;
                }
                // Check to see how many five dollar bills are in the given amount
                while (roundedAmount >= 5.00)
                {
                    roundedAmount -= 5.00;
                    fiveDollarCounter++;
                }
                // Check to see how many one dollar bills are in the given amount
                while (roundedAmount >= 1.00)
                {
                    roundedAmount -= 1.00;
                    oneDollarCounter++;
                }
                // Check to see how many quarters are in the given amount
                while (roundedAmount >= 0.25)
                {
                    roundedAmount-= 0.25;
                    quarterCounter++;
                }

                // Check to see how many dimes are in the given amount
                while (roundedAmount >= 0.10)
                {
                    roundedAmount -= 0.10;
                    dimeCounter++;
                }

                // Check to see how many nickels are in the given amount
                while (roundedAmount >= 0.05)
                {
                    roundedAmount -= 0.05;
                    nickelCounter++;
                }
                // Check to see how many nickels are in the given amount
                while (roundedAmount >= 0.0)
                {
                    roundedAmount -= 0.01;
                    pennyCounter++;
                }

            }

            // Print out the results of the analysis
            Console.WriteLine("Amount: $" + Math.Round(amount, 2));
            Console.WriteLine("Hundred Dollar Bills: " + hundredDollarCounter);
            Console.WriteLine("Fifty Dollar Bills: " + fiftyDollarCounter);
            Console.WriteLine("Twenty Dollar Bills: " + twentyDollarCounter);
            Console.WriteLine("Ten Dollar Bills:" + tenDollarCounter);
            Console.WriteLine("Five Dollar Bills: " + fiveDollarCounter);
            Console.WriteLine("One Dollar Bills: " + oneDollarCounter);
            Console.WriteLine("Quarters: " + quarterCounter);
            Console.WriteLine("Dimes: " + dimeCounter);
            Console.WriteLine("Nickels: " + nickelCounter);
            Console.WriteLine("Pennies: " + pennyCounter + "\n"); // Insert newline to seperate results
        }
    }
}
