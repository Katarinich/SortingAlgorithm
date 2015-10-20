using System;
using System.Collections.Generic;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main()
        {
            //лист пользовательских типов
            IEnumerable<Person> personList = new List<Person>
            {
                new Person { BirthYear = 1948, Name = "Cat Stevens" },
                new Person { BirthYear = 1955, Name = "Kevin Costner" },
                new Person { BirthYear = 1952, Name = "Vladimir Putin" },
                new Person { BirthYear = 1955, Name = "Bill Gates" },
                new Person { BirthYear = 1948, Name = "Kathy Bates" },
                new Person { BirthYear = 1956, Name = "David Copperfield" },
                new Person { BirthYear = 1948, Name = "Jean Reno" }
            };

            personList = new MergeSort().Sort(personList, (x, y) => x.BirthYear.CompareTo(y.BirthYear));

            //массив чисел
            IEnumerable<int> intArray = new[] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

            intArray = new ShellSort().Sort(intArray, Comparer<int>.Default);

            IEnumerable<KeyValuePair<string, int>> personDictionary = new Dictionary<string, int>
            {
                {"Cat Stevens", 1948},
                {"Kevin Costner", 1955},
                {"Vladimir Putin", 1952},
                {"Bill Gates", 1955},
                {"Kathy Bates", 1948},
                {"David Copperfield", 1954},
                {"Jean Reno", 1948}
            };
            personDictionary = new InsertSort().Sort(personDictionary, (x, y) => x.Value.CompareTo(y.Value));
        }
    }

    public sealed class Person
    {
        public int BirthYear { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{{ BirthYear = {BirthYear}, Name = {Name} }}";
        }
    }
}
