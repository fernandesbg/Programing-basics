using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Problem04
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());
            
            var elecTottal = 0.00;
            var water = 20.00* months;
            var internet = 15.00 * months;
            var otherBills = 0.00;

            for (int Bills = 1; Bills <= months; Bills++)
            {
                var elecBill = double.Parse(Console.ReadLine());
                elecTottal += elecBill;

            }
            var others = (elecTottal + water + internet) * 1.2;
            var average = (elecTottal + water + internet + others)/months;

            Console.WriteLine($"Electricity: {elecTottal:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
