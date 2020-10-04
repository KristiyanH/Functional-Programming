using System;
using System.Linq;
namespace _02._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(ParseNumber).ToArray();

            PrintResult(numbers, GetCount, GetSum);
            
        }

        static int ParseNumber(string num)
        {
            return int.Parse(num);
        }

        static void PrintResult(int[] numbers, Func<int[], int> count, Func<int[], int> sum)
        {
            Console.WriteLine(count(numbers));
            Console.WriteLine(sum(numbers));
        }

        static int GetCount(int[] numbers)
        {
            return numbers.Count();
        }

        static int GetSum(int[] numbers)
        {
            return numbers.Sum();
        }
        
        

    }
}
