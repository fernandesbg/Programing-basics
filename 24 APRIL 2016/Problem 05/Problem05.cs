using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05
{
    class Problem05
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var hight = (number * 2) + 2;
            var width = (number * 2) + (2 * number - 1) - 4;

            Console.WriteLine("{0}{1}{0}", new string('.', number + 1), new string('_', 2 * number + 1));

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', number - i), new string('_', (2 * number - 1) + i + i));
            }

            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', width / 2));

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', i), new string('_', width + 4 - i - i));
            }


        }
    }
}
