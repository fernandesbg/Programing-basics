using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_MARCH_2016
{
    class Problem06
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int q = 0; q <= 9; q++)
            {
                for (int w = 0; w <= 9; w++)
                {
                    for (int e = 0; e <= 9; e++)
                    {
                        for (int r = 0; r <= 9; r++)
                        {
                            for (int t = 0; t <= 9; t++)
                            {
                                for (int y = 0; y <= 9; y++)
                                {
                                    if (n == q*w*e*r*t*y)
                                    {
                                        Console.Write($"{q}{w}{e}{r}{t}{y} ");
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
