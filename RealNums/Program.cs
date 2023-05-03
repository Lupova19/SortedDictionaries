using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi chisla: ");
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int> sortedNums = new SortedDictionary<double, int>();

            foreach (var item in nums)
            {
                if (sortedNums.ContainsKey(item))
                {
                    sortedNums[item]++;
                }
                else
                {
                    sortedNums[item] = 1;
                }
            }
            foreach (var item in sortedNums.Keys) 
            {
                Console.WriteLine($"{item} -> {sortedNums[item]}");
            }
        }
    }
}
