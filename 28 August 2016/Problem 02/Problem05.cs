using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02
{
    class Problem05
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;

            for (int rows = 0; rows < n; rows++)
            {
                Console.WriteLine(new string('-', 3*n) + '*' + new string('-', rows) + '*' + new string('-', 2*n - 2 - rows));
            }

            for (int rows = 0; rows < n/2; rows++)
            {
                Console.WriteLine(new string('*', 3*n+1) + new string('-',n-1) + '*' + new string('-',n-1));
            }

            for (int rows = 0; rows < n/2 ; rows++)
            {
                if (rows != n/2 -1)
                {
                    Console.WriteLine(new string('-', 3 * n - rows) + '*' + new string('-', n - 1 + rows * 2) + '*' + new string('-', n - 1 - rows));
                }
                else
                {
                    Console.WriteLine(new string('-', 3 * n - rows) + '*' + new string('*', n - 1 + rows * 2) + '*' + new string('-', n - 1 - rows));
                }

            }


        }
    }
}
