using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            var heretage = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());

            var money = heretage;
            var yearsOld = 18.00;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= (12000 + yearsOld * 50);
                }

                yearsOld++;

            }

            if (money > 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
            }
            

        }
    }
}
