using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var begining = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var combinationExist = false;

            var counter = 0;
            var sum = 0;
            
            for (int i = begining; i <= end; i++)
            {
                for (int b = begining; b <= end; b++)
                {
                    counter++;
                    sum = i + b;
                    if (sum == magicNumber)
                    {
                        combinationExist = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {b} = {sum})");
                        break;
                    }
                }
                if (sum == magicNumber)
                {
                    break;
                }
            }
            if (combinationExist == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
