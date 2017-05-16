using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_APRIL_2016
{
    class Problem06
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int m = 1; m <= 9; m++)
                    {
                        for (int f = 1; f <= 9; f++)
                        {
                            if (n % i ==0 && n % j == 0 && n % m == 0 && n % f == 0)
                            {
                                Console.Write($"{i}{j}{m}{f} ");
                            }
                        }
                    }
                }
            }

        }
    }
}
