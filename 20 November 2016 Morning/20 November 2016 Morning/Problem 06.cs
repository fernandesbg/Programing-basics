using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_November_2016_Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());

            var counter = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    counter++;
                    if (counter<=max)
                    {
                        Console.Write($"({i} <-> {j}) ");
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter >max)
                {
                    break;
                }
            }
        }
    }
}
