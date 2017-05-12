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
            var hoursExam = int.Parse(Console.ReadLine());
            var minutesExam = int.Parse(Console.ReadLine());
            var hoursArival = int.Parse(Console.ReadLine());
            var minutesArival = int.Parse(Console.ReadLine());

            var minutesExamDay = hoursExam * 60 + minutesExam;
            var minutesArivalDay = hoursArival * 60 + minutesArival;

            var hourDifrence = Math.Abs(hoursExam - hoursArival);
            var minutesDifrence = Math.Abs(minutesExam - minutesArival);

            if (minutesExamDay >= minutesArivalDay)
            {
                if (minutesExamDay == minutesArivalDay)
                {
                    Console.WriteLine("On time");
                }
                else if (minutesExamDay - minutesArivalDay <=30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutesExamDay - minutesArivalDay} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    if (minutesExamDay - minutesArivalDay > 60)
                    {
                        Console.WriteLine($"{hourDifrence}:{minutesDifrence} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{minutesExamDay-minutesArivalDay} minutes before the start");
                    }
                }
            }
            else
            {
                Console.WriteLine("Late");
                if (minutesArivalDay-minutesExamDay >= 60)
                {
                    Console.WriteLine($"{hourDifrence}:{minutesDifrence} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{minutesDifrence} minutes after the start");
                }
                
            }
        }
    }
}
