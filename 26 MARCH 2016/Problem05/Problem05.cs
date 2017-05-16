using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Problem05
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 2 * -1;
            var hight = 2 * (n - 2) + 1;

            for (int row = 1; row <= n-2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                }
            }

            Console.WriteLine("{0}@{0}", new string(' ', n - 1));

            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                }
            }
        }
    }
}
