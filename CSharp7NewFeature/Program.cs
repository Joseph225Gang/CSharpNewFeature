using System;
using System.Collections.Generic;
using static System.Console;

namespace CSharp7NewFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "5";
            if (int.TryParse(input, out int result))
                WriteLine(result);
            else
                WriteLine("Could not parse input");
            var alpheStart = (Alpha: "a", Beta: "b");
            WriteLine($"{alpheStart.Alpha}{alpheStart.Beta}");
            var p = new Point(3.14, 2.71);
            (double X, double Y) = p;
            WriteLine($"{X}{Y}");

            var (_, _, pop0, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);

            WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");
            WriteLine(pop0);

            List<int> listNum = new List<int>() { 1, 2, 3, -5 };
            WriteLine(SumPositiveNumbers(listNum));

            WriteLine(6.022_140_857_747_474e23);
            WriteLine(1.618_033_988_749_894_848_204_586_834_365_638_117_720_309_179M);
            Func<string, bool> whereClause = default;
            int count = 5;
            string label = "Colors used in the map";
            var pair = (count, label); // element names are "count" and "label"
            WriteLine(pair);
            WriteLine("Hello World!");
        }

        private static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
        {
            int population1 = 0, population2 = 0;
            double area = 0;

            if (name == "New York City")
            {
                area = 468.48;
                if (year1 == 1960)
                {
                    population1 = 7781984;
                }
                if (year2 == 2010)
                {
                    population2 = 8175133;
                }
                return (name, area, year1, population1, year2, population2);
            }

            return ("", 0, 0, 0, 0, 0);
        }

        public static int SumPositiveNumbers(IEnumerable<int> sequence)
        {
            int sum = 0;
            foreach (var i in sequence)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case int n when n > 0:
                        sum += n;
                        break;
                }
            }
            return sum;
        }

        public static ref int Find(int[,] matrix, Func<int, bool> predicate)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (predicate(matrix[i, j]))
                        return ref matrix[i, j];
            throw new InvalidOperationException("Not found");
        }
    }
}
