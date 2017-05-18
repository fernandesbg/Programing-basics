using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfMoves = double.Parse(Console.ReadLine());
            var result = 0.0;
            var firstInterval = 0;
            var secondInterval = 0;
            var thirdInterval = 0;
            var forthInterval = 0;
            var firfthInterval = 0;
            var sixthInterval = 0;


            for (int i = 0; i < numberOfMoves; i++)
            {
                var curentNumber = int.Parse(Console.ReadLine());
                if (curentNumber >=0 && curentNumber <= 9)
                {
                    result += curentNumber * 0.2;
                    firstInterval++;
                }
                else if (curentNumber >= 10 && curentNumber <= 19)
                {
                    result += curentNumber * 0.3;
                    secondInterval++;
                }
                else if (curentNumber >= 20 && curentNumber <= 29)
                {
                    result += curentNumber * 0.4;
                    thirdInterval++;
                }
                else if (curentNumber >= 30 && curentNumber <= 39)
                {
                    result += 50;
                    forthInterval++;
                }
                else if (curentNumber >= 40 && curentNumber <= 50)
                {
                    result += 100;
                    firfthInterval++;
                }
                else
                {
                    result /= 2;
                    sixthInterval++;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {firstInterval / numberOfMoves * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {secondInterval/numberOfMoves * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {thirdInterval/numberOfMoves * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {forthInterval/numberOfMoves * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {firfthInterval/numberOfMoves * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {sixthInterval/numberOfMoves * 100:f2}%");
        }
    }
}
