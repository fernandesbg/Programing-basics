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
            var n = int.Parse(Console.ReadLine());

            var p1 = 0.00;
            var p2 = 0.00;
            var p3 = 0.00;
            var p4 = 0.00;
            var p5 = 0.00;

            for (int numbers = 0; numbers < n; numbers++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number <400)
                {
                    p2++;
                }
                else if (number >= 400 && number < 600)
                {
                    p3++;
                }
                else if (number >= 400 && number < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }

                
            }
            Console.WriteLine($"{p1 / n * 100:f2}%");
            Console.WriteLine($"{p2 / n * 100:f2}%");
            Console.WriteLine($"{p3 / n * 100:f2}%");
            Console.WriteLine($"{p4 / n * 100:f2}%");
            Console.WriteLine($"{p5 / n * 100:f2}%");
        }
    }
}
