using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSPSolver.TSP
{
    public class TSPSpec
    {
        public TSPSpec(string name, IReadOnlyList<int> optimalTour, IReadOnlyList<Location> cities)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name must not be null or whitespace", nameof(name));
            }

            Name = name;
            OptimalTour = optimalTour ?? throw new ArgumentException(nameof(optimalTour));
            Cities = cities ?? throw new ArgumentException(nameof(cities));
        }

        public string Name { get; set; }

        public IReadOnlyList<int> OptimalTour { get; set; }

        public IReadOnlyList<Location> Cities { get; set; }
    }

    public class Location
    {
        public Location(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
