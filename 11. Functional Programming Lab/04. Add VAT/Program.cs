using System;
using System.Linq;
namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = Console.ReadLine().Split(", ").Select(decimal.Parse).Select(x => x * 1.2m).ToArray();

            foreach (var item in prices)
            {
                Console.WriteLine($"{item:f2}");
            }
        }


    }
}
