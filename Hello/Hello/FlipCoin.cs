using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloword3
{
    public class FlipCoin
    {
        public static void FindFlipCoinPercentage()
        {
            int tailCount = 0;
            int headCount = 0;
            Console.WriteLine("Please enter number to know how many times to flip the coin");
            int numbOfTimes = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for (int i = 1; i <= numbOfTimes; i++)
            {
                double randomValue = random.NextDouble();
                if (randomValue < 0.5)
                    tailCount++;
                else
                    headCount++;
            }
            Console.WriteLine("Number of tails is " + tailCount + " out of " + numbOfTimes);
            Console.WriteLine("Number of heads is " + headCount + " out of " + numbOfTimes);

            double tailPercentage = (double)(tailCount * 100) / numbOfTimes;
            Console.WriteLine("Tail Percentage:" + tailPercentage);
            double headPercentage = (double)(headCount * 100) / numbOfTimes;
            Console.WriteLine("Head Percentage:" + headPercentage);
        }

    }
}
