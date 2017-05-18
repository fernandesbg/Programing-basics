using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka18Mart
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideA = Double.Parse(Console.ReadLine());
            var sideB = Double.Parse(Console.ReadLine());

            var sidesOfHouse = sideA / 2 * sideA * 2;
            var backSide = sideA / 2 * sideA / 2 + (sideA / 2 * (sideB - sideA / 2) / 2);
            var frontSide = backSide - (sideA / 5 * sideA / 5);
            var areaOfRoof = (sideA * sideA/2)*2;
            
            var greenPaint = (sidesOfHouse + backSide+ frontSide) /3;
            Console.WriteLine($"{greenPaint:f2}");

            var redPaint = areaOfRoof / 5;
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
