using OptimizationAlgorithms.Particles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.Swarms
{
    public interface ISwarm 
    {
        List<IParticle> Particles { get; set; }

        void SetGlobalBest(double globalBest);
        void SetGlobalBestPosition(double[] globalBest);
        double [] GlobalBestPosition { get; set; }
        double [] BestResult { get; set; }
        double  GlobalBestFitness { get; set; }

    }
}
