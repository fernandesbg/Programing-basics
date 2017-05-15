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
            var boughtHrizantemi = int.Parse(Console.ReadLine());
            var boughtRozi = int.Parse(Console.ReadLine());
            var boughtLaleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            var hrizantemiPrice = 0.00;
            var roziPrice = 0.00;
            var laletaPrice = 0.00;
            var costOfFlowers = 0.00;

            if (season == "Spring" || season == "Ssummer")
            {
                hrizantemiPrice += 2.00;
                roziPrice += 4.10;
                laletaPrice += 2.50;
                costOfFlowers = hrizantemiPrice * boughtHrizantemi + laletaPrice * boughtLaleta + roziPrice * boughtRozi;
                if (holiday == "Y")
                {
                    costOfFlowers = costOfFlowers * 1.15;
                }
                if (boughtLaleta > 7)
                {
                    costOfFlowers = costOfFlowers * 0.95;
                }
            }
            else if (season == "Winter" || season == "Autumn")
            {
                hrizantemiPrice += 3.75;
                roziPrice += 4.50;
                laletaPrice += 4.15;
                costOfFlowers = hrizantemiPrice * boughtHrizantemi + laletaPrice * boughtLaleta + roziPrice * boughtRozi;
                if (holiday == "Y")
                {
                    costOfFlowers = costOfFlowers * 1.15;
                }
                if (boughtRozi >= 10)
                {
                    costOfFlowers = costOfFlowers * 0.90;
                }
            }
            if (boughtHrizantemi+boughtLaleta+boughtRozi > 20)
            {
                costOfFlowers = costOfFlowers * 0.80;
            }
            Console.WriteLine("{0:f2}", costOfFlowers + 2);
        }
    }
}
