using OptimizationAlgorithms.Particles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms
{
    public enum eFitnessFunction
    {
        SSD
    }
    public interface IFitnessFunction
    {
        double Evaluate(double[] x, double[] y);

    }
}
