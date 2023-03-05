using OptimizationAlgorithms.Particles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.FitnessFunction
{
    class SumofSquaredDeviations : IFitnessFunction
    {    
        double IFitnessFunction.Evaluate(IParticle particle)
        {
            double fitness = 0;

            particle.SetFitness(fitness);
            return fitness;
        }
    }
}
