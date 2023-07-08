using OptimizationAlgorithms.Particles;
using OptimizationAlgorithms.PSOObjects.Particles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.FitnessFunction
{
    public class SumofSquaredDeviations : IFitnessFunction
    {    
        public SumofSquaredDeviations()
        {

        }
        double IFitnessFunction.Evaluate(double[] x, double[] y)
        {
            if (x.Length != y.Length)
            {
                throw new ArgumentException("Input arrays must have the same length.");
            }

            double sum = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += Math.Pow((x[i] - y[i]), 2);
            }

            return sum;


            
        }
    }
}
