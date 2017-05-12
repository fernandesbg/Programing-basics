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
            var width = 2 * n;
            var hight = n;

            Console.WriteLine("/{0}\\{1}/{0}\\", 
                new string('^', n/2), 
                new string('_', width - 4 - 2*(n/2)));

            for (int row = 1; row <= hight -2; row++)
            {
                if (row == hight-2)
                {
                    Console.WriteLine("|{0} {1} {0}|",
                new string(' ', n / 2),
                new string('_', width - 4 - 2 * (n / 2)));
                }
                else
                {
                    Console.WriteLine("|{0}|",
                new string(' ', width - 2));
                }
                
            }

            Console.WriteLine("\\{0}/{1}\\{0}/",
                new string('_', n / 2),
                new string(' ', width - 4 - 2 * (n / 2)));

        }
    }
}
