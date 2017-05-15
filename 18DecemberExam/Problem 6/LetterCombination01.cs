using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSimbol = char.Parse(Console.ReadLine());
            char lastSimbol = Convert.ToChar(Console.ReadLine());
            char skipSimbol = Convert.ToChar(Console.ReadLine());

            int count = 0;

            for (char simbol1 = firstSimbol; simbol1 <= lastSimbol; simbol1++)
            {
                if (simbol1 != skipSimbol)
                {
                    for (char simbol2 = firstSimbol; simbol2 <= lastSimbol; simbol2++)
                    {
                        if (simbol2 != skipSimbol)
                        {
                            for (char simbol3 = firstSimbol; simbol3 <= lastSimbol; simbol3++)
                            {
                                if (simbol3 != skipSimbol)
                                {
                                    count++;
                                    string curentOutput = simbol1.ToString() + simbol2.ToString() + simbol3.ToString();
                                    Console.Write($"{curentOutput} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
