using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18DecemberExam
{
    class Problem1
    {
        static void Main(string[] args)
        {
            var initialSpeed = int.Parse(Console.ReadLine());
            var t1 = double.Parse(Console.ReadLine()) / 60;
            var t2 = double.Parse(Console.ReadLine()) / 60;
            var t3 = double.Parse(Console.ReadLine()) / 60;

            var dist1 = t1 * initialSpeed;
            var dist2 = t2 * initialSpeed * 1.1;
            var dist3 = t3 * (initialSpeed * 1.1) * 0.95;
            var totalDistance = dist1 + dist2 + dist3;

            Console.WriteLine("{0:f2}", totalDistance);
        }
    }
}
