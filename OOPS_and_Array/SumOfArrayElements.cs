using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct5_Assignment
{
    internal class SumOfArrayElements
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of Elements is: {sum}");
            Console.ReadLine();
        }
    }
}
