using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_JULY_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());

            for (int numbers = m; numbers >= n; numbers--)
            {
                if (numbers % 2 == 0 && numbers % 3 == 0 && numbers == s)
                {
                    break;
                }
                else if (numbers % 2 == 0 && numbers % 3 == 0 )
                {
                    Console.Write($"{numbers} ");
                }
                

            }
        }
    }
}
