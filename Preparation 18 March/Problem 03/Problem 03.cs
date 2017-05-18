using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var budgget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budgget <= 100)
            {
                Console.WriteLine("Economy class");
                if (season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {budgget*0.35:f2}");
                }
                else
                {
                    Console.WriteLine($"Jeep - {budgget * 0.65:f2}");
                }
            }
            else if (budgget <= 500)
            {
                Console.WriteLine("Compact class");
                if (season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {budgget * 0.45:f2}");
                }
                else
                {
                    Console.WriteLine($"Jeep - {budgget * 0.80:f2}");
                }
            }
            else
            {
                Console.WriteLine("Luxury class");
                Console.WriteLine($"Jeep - {budgget * 0.90:f2}");
            }
        }
    }
}
