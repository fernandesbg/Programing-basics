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
            var width = 4 * n + 1;
            var high = 2 * n + 5;

            Console.WriteLine(new string('.', width/2 -1) + '/' + '|' + '\\' + new string('.', width / 2 - 1));
            Console.WriteLine(new string('.', width / 2 - 1) + '\\' + '|' + '/' + new string('.', width / 2 - 1));

            for (int row = 0; row < 2*n; row++)
            {
                Console.WriteLine(new string('.', width/2 -1 -row)+ '*' + new string('-', row) + '*' + new string('-', row)+ '*' +new string('.', width / 2 - 1 - row));
            }

            Console.WriteLine(new string('*', width));

            for (int i = 0; i < width/2; i++)
            {
                Console.Write('*');
                Console.Write('.');
            }
            Console.WriteLine('*');

            Console.WriteLine(new string('*', width));

        }
    }
}
