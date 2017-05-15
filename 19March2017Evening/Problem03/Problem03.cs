using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Problem03
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            var kilmetersPerMonth = double.Parse(Console.ReadLine());

            var priceKM = 1.00;

            if (kilmetersPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    priceKM *= 0.75;
                }
                else if (season == "Summer")
                {
                    priceKM *= 0.90;
                }
                else if (season == "Winter")
                {
                    priceKM *= 1.05;
                }
            }
            else if (kilmetersPerMonth > 5000 && kilmetersPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    priceKM *= 0.95;
                }
                else if (season == "Summer")
                {
                    priceKM *= 1.10;
                }
                else if (season == "Winter")
                {
                    priceKM *= 1.25;
                }
            }
            else
            {
                priceKM *= 1.45;
            }
            Console.WriteLine($"{kilmetersPerMonth*4*0.9*priceKM:f2}");
        }
    }
}
