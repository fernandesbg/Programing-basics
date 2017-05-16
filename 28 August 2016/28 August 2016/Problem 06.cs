using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_August_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var numberCopy = number;
            var digit3 = numberCopy % 10;
            numberCopy /= 10;
            var digit2 = numberCopy % 10;
            numberCopy /= 10;
            var digit1 = numberCopy % 10;

            var rows = digit1 + digit2;
            var cols = digit1 + digit3;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <cols; j++)
                {
                    if (number % 5 == 0)
                    {
                        number -= digit1;
                        Console.Write($"{number} ");
                    }
                    else if (number % 3 == 0)
                    {
                        number -= digit2;
                        Console.Write($"{number} ");
                    }
                    else
                    {
                        number += digit3;
                        Console.Write($"{number} ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
