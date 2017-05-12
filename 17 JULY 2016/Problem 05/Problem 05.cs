using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;
            var hight = 3 * n + 2;
            
            Console.WriteLine(new string('.', n) + new string('*', width - 2 * n) + new string('.', n));

            for (int row = 1; row <= n - 1; row++)
            {
                Console.WriteLine(new string('.', n - row) + '*' + new string('.', width - 2 * (n - row) - 2) + '*' + new string('.', n - row));
            }

            Console.WriteLine(new string('*', width));

            for (int row = 1; row <= 2 * n + 1; row++)
            {

                if (row != 2 * n + 1)
                {
                    Console.WriteLine(new string('.', row) + '*' + new string('.', width - 2 * (row + 1)) + '*' + new string('.', row));
                }

                else
                {
                    Console.WriteLine(new string('.', row) + '*' + new string('*', width - 2 * (row + 1)) + '*' + new string('.', row));
                }

            }
        }
    }
}
