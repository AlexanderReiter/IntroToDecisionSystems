namespace TSPSolver.TSP
{
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
