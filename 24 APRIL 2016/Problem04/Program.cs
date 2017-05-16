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
            var lilisAge = int.Parse(Console.ReadLine());
            var washPrise = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var numberOfToys = 0;
            var moneyPerYear = 0;
            var couterEven = 0;

            for (int year = 1; year <= lilisAge; year++)
            {
                if (year % 2 == 0)
                {
                    moneyPerYear = moneyPerYear + year *10 / 2;
                    couterEven++;
                }
                else
                {
                    numberOfToys++;
                }
                
            };
            var MoneySaved = moneyPerYear - couterEven + numberOfToys * toyPrice;


            if (MoneySaved >= washPrise)
            {
                Console.WriteLine($"Yes! {MoneySaved - washPrise:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washPrise - MoneySaved:f2}");
            }



        }
    }
}
