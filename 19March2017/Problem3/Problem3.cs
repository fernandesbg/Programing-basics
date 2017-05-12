using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Problem3
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            Math.Round(budget, 0.00);
            if (budget > 3000)

            {
                if (season == "Summer")
                {
                    Console.WriteLine("Alaska - Hotel - {0:f2}", budget * 0.900);
                }
                else if (season == "Winter")
                {
                    Console.WriteLine("Morocco - Hotel - {0:f2}", budget * 0.900);
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine("Alaska - Hut - {0:f2}", budget * 0.800);
                }
                else if (season == "Winter")
                {
                    Console.WriteLine("Morocco - Hut - {0:f2}", budget * 0.600);
                }
            }
            else if (budget <= 1000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine("Alaska - Camp - {0:f2}", budget * 0.65);
                }
                else if (season == "Winter")
                {
                    Console.WriteLine("Morocco - Camp - {0:f2}", budget * 0.45);
                }
            }
        }
    }
}
