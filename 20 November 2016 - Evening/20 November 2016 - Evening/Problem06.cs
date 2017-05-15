using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_November_2016___Evening
{
    class Problem06
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());

            var couter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    if (couter < max)
                    {
                        Console.Write($"<{i}-{j}>");
                    }
                    else
                    {
                        break;
                    }
                   
                    couter++;
                }
                if (couter >= max)
                {
                    break;
                }
            }
        }
    }
}
