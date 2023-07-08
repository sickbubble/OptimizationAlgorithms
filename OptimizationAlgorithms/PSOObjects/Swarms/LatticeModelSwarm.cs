using OptimizationAlgorithms.Particles;
using OptimizationAlgorithms.PSOObjects.Particles;
using OptimizationAlgorithms.Swarms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.PSOObjects.Swarms
{
    public class LatticeModelSwarm : BaseSwarm
    {
        public LatticeModelSwarm(List<IParticle> latticeParticles,double [] targetDispProfile)
        {
            this.Particles = latticeParticles;
            this.BestResult = targetDispProfile;
            this.GlobalBestPosition = new double[latticeParticles.FirstOrDefault().Position.Length];
            this.GlobalBestFitness = 100;
            
        }

  
    }
}
