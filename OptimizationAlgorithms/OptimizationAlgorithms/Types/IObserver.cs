using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.Types
{
    public interface IObserver
    {
        void NotifyConvergence(double fitness);
        void NotifyNewGlobalBest(double fitness, double[] position);
    }
}
