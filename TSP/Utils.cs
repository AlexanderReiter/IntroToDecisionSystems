using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSPSolver.TSP
{
    public static class Utils
    {
        public static double CityDistance(Location city1, Location city2)
        {
            return Math.Sqrt(Math.Pow(city2.X - city1.X, 2) + Math.Pow(city2.Y - city1.Y, 2));
        }

        public static double GetDistance(IReadOnlyList<int> solution, IReadOnlyList<Location> cities)
        {
            return solution
                .Concat(solution.Take(1))
                .Select(index => cities[index - 1])
                .Pairwise(CityDistance)
                .Sum();

            //double distance = 0;


            //for(int i = 0; i < solution.Count - 1; i++)
            //{
            //    distance += CityDistance(cities[solution[i] - 1], cities[solution[i + 1] - 1]);
            //}

            //distance += CityDistance(cities[solution[solution.Count - 1] - 1], cities[solution[0] - 1]);

            //return distance;
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<double> Pairwise(this IEnumerable<Location> source, Func<Location, Location, double> fn)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (fn is null)
            {
                throw new ArgumentNullException(nameof(fn));
            }

            return source.Zip(source.Skip(1), fn);
        }
    }
}
