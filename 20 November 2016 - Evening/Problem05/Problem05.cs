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
            var width = 3 * n;

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('.', width/2-1-row) + '/' + new string(' ', row* 2) + '\\' + new string('.', width / 2 - 1 - row));
            }

            Console.WriteLine(new string('.', n/2) + new string('*', width -n) + new string('.', n / 2));

            for (int row = 0; row < n*2; row++)
            {
                Console.WriteLine(new string('.', n/2) + '|' + new string('\\', width - n -2) + '|' + new string('.', n / 2));
            }
            
            for (int row = 0; row < n/2; row++)
            {
                Console.WriteLine(new string('.', n/2- row) + '/' + new string('*', width -n -2+ 2*row) + '\\' + new string('.', n/2- row));
            }
        }
    }
}
