using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberrOfGroups = int.Parse(Console.ReadLine());
            var car = 0.00;
            var microbuss = 0.00;
            var smallBuss = 0.00;
            var bigBuss = 0.00;
            var train = 0.00;
            var tottalCount = 0.00;


            for (int i = 0; i < numberrOfGroups; i++)
            {

                var numberOfPeoble = int.Parse(Console.ReadLine());
                tottalCount += numberOfPeoble;

                if (numberOfPeoble <= 5)
                {
                    car += numberOfPeoble;
                }
                else if (numberOfPeoble >5 && numberOfPeoble <=12)
                {
                    microbuss += numberOfPeoble;
                }
                else if (numberOfPeoble > 12 && numberOfPeoble <= 25)
                {
                    smallBuss += numberOfPeoble;
                }
                else if (numberOfPeoble > 25 && numberOfPeoble <= 40)
                {
                    bigBuss += numberOfPeoble;
                }
                else
                {
                    train += numberOfPeoble;
                }
            }

            Console.WriteLine($"{(car/tottalCount)*100:f2}%");
            Console.WriteLine($"{(microbuss / tottalCount) * 100:f2}%");
            Console.WriteLine($"{(smallBuss / tottalCount) * 100:f2}%");
            Console.WriteLine($"{(bigBuss / tottalCount) * 100:f2}%");
            Console.WriteLine($"{(train / tottalCount) * 100:f2}%");


        }
    }
}
