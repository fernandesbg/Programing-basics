using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проблем04
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());

            var trited = 0;
            var unTrited = 0;
            var doctors = 7;

            for (int day = 1; day <= period; day++)
            {
                var patients = int.Parse(Console.ReadLine());

                if (day % 3 == 0 && unTrited > trited)
                {
                    doctors++;
                }

                if (patients <= doctors)
                {
                    trited += patients;
                }
                else
                {
                    trited += doctors;
                    unTrited = unTrited + patients - doctors;
                }
                
            }
            Console.WriteLine($"Treated patients: {trited}.");
            Console.WriteLine($"Untreated patients: {unTrited}.");
        }
    }
}
