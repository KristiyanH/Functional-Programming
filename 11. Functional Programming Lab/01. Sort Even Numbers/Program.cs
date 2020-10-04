using System;
using System.Linq;

namespace _11._Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Console.WriteLine(String.Join(", ", numbers.Where(x => x % 2 == 0).OrderBy(x => x)));
        }
    }
}
