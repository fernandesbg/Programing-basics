using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleem_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var hight = 4 * n - 2;
            var widht = 12 * n - 5;

            for (int row = 1; row <= 2*n; row++)
            {
                var numberOfhashes = row * 6 -5;
                var numberOfDots = (widht - numberOfhashes)/2;
                Console.Write(new string('.', numberOfDots));
                Console.Write(new string('#', numberOfhashes));
                Console.WriteLine(new string('.', numberOfDots));
            }
            for (int row = 1; row <= n - 2; row++)
            {
                var numberOfDots = row * 3;
                var numberOfHashes = (widht - numberOfDots*2);
                Console.Write('|');
                Console.Write(new string('.', numberOfDots-1));
                Console.Write(new string('#', numberOfHashes));
                Console.WriteLine(new string('.', numberOfDots));
            }
            for (int row = 1; row <= n - 1; row++)
            {
                var numberOfDots = 3*(n -1);
                var numberOfHashes = (widht - numberOfDots * 2);
                Console.Write('|');
                Console.Write(new string('.', numberOfDots - 1));
                Console.Write(new string('#', numberOfHashes));
                Console.WriteLine(new string('.', numberOfDots));
            }
            for (int i = 0; i < 1; i++)
            {
                var numberOfDots = 3 * (n - 1);
                var numberOfHashes = (widht - numberOfDots * 2);
                Console.Write('@');
                Console.Write(new string('.', numberOfDots - 1));
                Console.Write(new string('#', numberOfHashes));
                Console.WriteLine(new string('.', numberOfDots));
            }

        }
    }
}
