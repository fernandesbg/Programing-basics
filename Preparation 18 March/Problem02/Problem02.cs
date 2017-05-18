using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Problem02
    {
        static void Main(string[] args)
        {
            var neseseryHours = int.Parse(Console.ReadLine());
            var numberOfWorkers = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());

            var workingHours = numberOfWorkers * workingDays * 8;

            if (neseseryHours <= workingHours)
            {
                Console.WriteLine($"{workingHours - neseseryHours} hours left");
            }
            else
            {
                Console.WriteLine($"{neseseryHours- workingHours} overtime");
                Console.WriteLine($"Penalties: {(neseseryHours - workingHours)*workingDays}");
            }
        }
    }
}
