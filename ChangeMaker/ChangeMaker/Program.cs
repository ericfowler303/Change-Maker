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
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);
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
            int quarterCounter = 0;
            int dimeCounter = 0;
            int nickelCounter = 0;
            int pennyCounter = 0;

            // Check to make sure the amount is valid
            if(amount > 0)
            {
                // Round the amount to two digits
                double roundedAmount = Math.Round(amount, 2);

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
                while (roundedAmount >= 0.01)
                {
                    roundedAmount -= 0.01;
                    pennyCounter++;
                }

            }

            // Print out the results of the analysis
            Console.WriteLine("Amount: $" + Math.Round(amount, 2));
            Console.WriteLine("Quarters: " + quarterCounter);
            Console.WriteLine("Dimes: " + dimeCounter);
            Console.WriteLine("Nickels: " + nickelCounter);
            Console.WriteLine("Pennies: " + pennyCounter + "\n"); // Insert newline to seperate results
        }
    }
}
