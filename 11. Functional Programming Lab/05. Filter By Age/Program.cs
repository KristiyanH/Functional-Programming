using System;
using System.Linq;
namespace _05._Filter_By_Age
{

    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                people[i] = new Person() { Name = name, Age = age };

            }

            string condition = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> checker = AgeCheckDelegate(condition, ageFilter);
            Action<Person> printer = PrinterDelegate(format);

            foreach (var person in people)
            {
                if (checker(person))
                {
                    printer(person);
                }
            }
        }


        static Func<Person, bool> AgeCheckDelegate(string condition, int ageFilter)
        {
            switch (condition)
            {
                case "younger":
                    return p => p.Age < ageFilter;
                case "older":
                    return p => p.Age >= ageFilter;
                default:
                    return null;
            }

        }

        static Action<Person> PrinterDelegate(string format)
        {
            switch (format)
            {
                case "name":
                    return p =>
                    {
                        Console.WriteLine(p.Name);
                    };
                case "age":
                    return p =>
                    {
                        Console.WriteLine(p.Age);
                    };
                case "name age":
                    return p =>
                    {
                        Console.WriteLine($"{p.Name} - {p.Age}");
                    };
                default:
                    return null;
            }
        }
    }


    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
