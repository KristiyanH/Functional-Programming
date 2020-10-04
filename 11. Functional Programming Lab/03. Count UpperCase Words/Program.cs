using System;
using System.Linq;

namespace _03._Count_UpperCase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isUpperDelegate = x => x[0] == x.ToUpper()[0];

            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(isUpperDelegate).ToArray();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.WriteLine(input[i]);
            //}

            // same as :

            Console.WriteLine(String.Join("\n", input));
        }
    }
}
