using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19March2017
{
    class Problem1
    {
        static void Main(string[] args)
        {
            var houseHight = double.Parse(Console.ReadLine());
            var houseWith = double.Parse(Console.ReadLine());
            var housetopHight = double.Parse(Console.ReadLine());

            var sideWallSArea = (houseHight * houseWith - 2.25)*2;
            var frontBackDoorWalls = 2*(houseHight * houseHight) - 2.4;
            var greenPaintRequerd = (sideWallSArea + frontBackDoorWalls) / 3.4;

            var areaOfTop = (houseHight * houseWith) * 2 + 2 * houseHight * housetopHight / 2;
            var redPaintRequerd = areaOfTop / 4.3;

            Console.WriteLine("{0:f2}", greenPaintRequerd);
            Console.WriteLine("{0:f2}", redPaintRequerd);
        }
    }
}
