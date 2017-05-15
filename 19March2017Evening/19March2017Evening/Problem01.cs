using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19March2017Evening
{
    class Problem01
    {
        static void Main(string[] args)
        {
            var areaLoze = double.Parse(Console.ReadLine());
            var kgGropesPerMeter = double.Parse(Console.ReadLine());
            var brak = double.Parse(Console.ReadLine());

            var tottalGrapes = areaLoze * kgGropesPerMeter;
            var tottal = tottalGrapes - brak;

            var grapesForRakia = tottal * 0.45;
            var grapesForSlales = tottal * 0.55;

            var rakia = grapesForRakia / 7.5;
            var rakiaMoney = rakia * 9.8;

            var grapesMoney = grapesForSlales * 1.5;

            Console.WriteLine($"{rakiaMoney:f2}");
            Console.WriteLine($"{grapesMoney:f2}");
        }
    }
}
