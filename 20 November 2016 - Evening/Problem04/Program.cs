using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberLoads = int.Parse(Console.ReadLine());
            var tottalLoad = 0.00;
            var bussLoad = 0.00;
            var truckLoad = 0.00;
            var trainLoad = 0.00;

            for (int i = 0; i < numberLoads; i++)
            {
                var load = int.Parse(Console.ReadLine());
                tottalLoad += load;
                if (load <= 3)
                {
                    bussLoad += load;
                }
                else if (load <= 11 && load > 3)
                {
                    truckLoad += load;
                }
                else
                {
                    trainLoad += load;
                }
            }
            var averegePrice = (bussLoad * 200 + truckLoad * 175 + trainLoad * 120) / tottalLoad;
            Console.WriteLine($"{averegePrice:f2}");
            Console.WriteLine($"{(bussLoad/tottalLoad)*100:f2}%");
            Console.WriteLine($"{(truckLoad / tottalLoad) * 100:f2}%");
            Console.WriteLine($"{(trainLoad / tottalLoad) * 100:f2}%");
        }
    }
}
