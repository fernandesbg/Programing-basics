using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var control = int.Parse(Console.ReadLine());

            var sum = 0;
            var counter = 0;

            for (int a = 1; a <= n; a++)
            {
                for (int b = m; b >= 1; b--)
                {
                    
                    if (sum >=control)
                    {
                        break;
                    }
                    counter++;
                    sum += a * 2 + b * 3;
                }
                if (sum >= control)
                {
                    break;
                }
            }
            if (sum >= control)
            {
                Console.WriteLine($"{counter} moves");
                Console.WriteLine($"Score: {sum} >= {control}");
            }
            else
            {
                Console.WriteLine($"{counter} moves");
            }
        }
    }
}
