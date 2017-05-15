using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 2 * n + 3;

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine(new string('*', row) + '\\' + new string('-', width -2*row-2) + '/' + new string('*', row));
            }

            for (int row = 0; row < n/3; row++)
            {
                Console.WriteLine('|' + new string('*', n / 2 + row) + '\\' + new string('*', n - 2 * row) + '/' + new string('*', n / 2 + row) + '|');
            }

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine(new string('-', row) + '\\' + new string('*',width- row*2 -2) + '/' + new string('-', row));
            }

        }
    }
}
