using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MARCH_2016
{
    class PROBLEM06
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (int q = 1; q <= n; q++)
            {
                for (int w = 1; w <= n; w++)
                {
                    for (char e = 'a'; e < 'a'+l; e++)
                    {
                        for (char r = 'a' ; r < 'a'+l; r++)
                        {
                            for (int t = 1; t <= n; t++)
                            {
                                if (t > q && t > w)
                                {
                                    Console.Write($"{q}{w}{e}{r}{t} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
