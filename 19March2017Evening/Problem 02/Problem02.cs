using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02
{
    class Problem02
    {
        static void Main(string[] args)
        {
            var budget = Double.Parse(Console.ReadLine());
            var areaOfHouse = Double.Parse(Console.ReadLine());
            var numberOfWindows = int.Parse(Console.ReadLine());
            var stirofoamMeters = Double.Parse(Console.ReadLine());
            var stirofoamPrice = Double.Parse(Console.ReadLine());

            var area = (areaOfHouse - numberOfWindows * 2.4)*1.1;
            var pakets = Math.Ceiling(area / stirofoamMeters);
            var priceMaterial = pakets * stirofoamPrice;

            if (budget >= priceMaterial)
            {
                Console.WriteLine($"Spent: {priceMaterial:f2}");
                Console.WriteLine($"Left: {budget - priceMaterial:f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {priceMaterial-budget:f2}");
            }

        }
    }
}
