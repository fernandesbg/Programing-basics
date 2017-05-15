using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Problem4
    {
        static void Main(string[] args)
        {
            var numberOfStudents = int.Parse(Console.ReadLine());

            var topStudents = 0.00;
            var between4_5 = 0.00;
            var between3_4 = 0.00;
            var fail = 0.00;
            var grades = 0.00;

            for (int i = 0; i < numberOfStudents; i++)
            {
                var grade = double.Parse(Console.ReadLine());
                if (grade >= 5)
                {
                    topStudents++;
                }
                else if (grade >= 4 && grade < 5)
                {
                    between4_5++;
                }
                else if (grade >= 3 && grade < 4)
                {
                    between3_4++;
                }
                else if (grade <3)
                {
                    fail++;
                }
                grades += grade;
            }
            Console.WriteLine($"Top students: {topStudents/numberOfStudents*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4_5 / numberOfStudents * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3_4 / numberOfStudents * 100:f2}%");
            Console.WriteLine($"Fail: {fail / numberOfStudents * 100:f2}%");
            Console.WriteLine($"Average: {grades / numberOfStudents:f2}");
        }
    }
}
