using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSPSolver.TSP
{
    public abstract class Solver
    {
        public abstract IReadOnlyList<int> Solve(IReadOnlyList<Location> cities);
    }

    public class BruteForce : Solver
    {
        public override IReadOnlyList<int> Solve(IReadOnlyList<Location> cities)
        {
            throw new NotImplementedException();
        }
    }
}
