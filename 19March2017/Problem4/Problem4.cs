using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLekcii = int.Parse(Console.ReadLine());
            double totalSum = double.Parse(Console.ReadLine());
            double sumOneLekcia = totalSum / numberLekcii;

            int numJelev = 0;
            int numRoYaL = 0;
            int numRoli = 0;
            int numTrofon = 0;
            int numSino = 0;
            int numOthers = 0;

            for (int i = 1; i <= numberLekcii; i++)
            {
                string lektor = Console.ReadLine();
                if (lektor == "Jelev") numJelev++;
                else if (lektor == "RoYaL") numRoYaL++;
                else if (lektor == "Roli") numRoli++;
                else if (lektor == "Trofon") numTrofon++;
                else if (lektor == "Sino") numSino++;
                else numOthers++;
            }
            Console.WriteLine("Jelev salary: {0:f2} lv", numJelev * sumOneLekcia);
            Console.WriteLine("RoYaL salary: {0:f2} lv", numRoYaL * sumOneLekcia);
            Console.WriteLine("Roli salary: {0:f2} lv", numRoli * sumOneLekcia);
            Console.WriteLine("Trofon salary: {0:f2} lv", numTrofon * sumOneLekcia);
            Console.WriteLine("Sino salary: {0:f2} lv", numSino * sumOneLekcia);
            Console.WriteLine("Others salary: {0:f2} lv", numOthers * sumOneLekcia);

        }
    }
}