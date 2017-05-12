using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проблем_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupsRequerd = double.Parse(Console.ReadLine());
            var numberOfWorkers = double.Parse(Console.ReadLine());
            var workingDays = double.Parse(Console.ReadLine());

            var workingHours = numberOfWorkers * workingDays * 8.00;

            var cupsMade = Math.Floor(workingHours / 5.00);


            if (cupsMade < cupsRequerd )
            {
                var losses =(cupsRequerd - cupsMade) * 4.20;
                Console.Write("Losses: {0:f2}", losses);
            }
            else
            {
                var extra =4.20 * ( cupsMade - cupsRequerd);
                Console.Write("{0:f2} extra money", extra);
            }
        }
    }
}
