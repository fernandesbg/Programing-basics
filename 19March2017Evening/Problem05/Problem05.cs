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

            var width = 3 * n + 1;
            var hight = 4 * n + 4;

            Console.WriteLine('+' + new string('~', n-2) + '+' + new string('.',width- n));

            for (int row = 0; row < 2 * n + 1; row++)
            {
                Console.WriteLine('|' + new string('.', row) + '\\' + new string('~', n - 2)+ '\\' + new string('.', width - n - 1 - row));
            }

            for (int row = 0; row < 2 * n + 1; row++)
            {
                Console.WriteLine(new string('.', row) + '\\' + new string('.', 2 * n - row) + '|' + new string('~', n - 2) + '|');
            }

            Console.WriteLine(new string('.',width- n) + '+' + new string('~', n - 2) + '+');
        }
    }
}
