using OptimizationAlgorithms.Particles;
using OptimizationAlgorithms.PSOObjects;
using OptimizationAlgorithms.PSOObjects.Swarms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.Swarms
{
    public interface IFactory 
    {
        IProduct Create();
    }

   public class SwarmFactory : IFactory
    {
        public IProduct Create()
        {
            return new BaseSwarm();
        }

        public LatticeModelSwarm CreateLatticeModelSwarm(List<IParticle> particles,double[] targetDispProfile) 
        {
            LatticeModelSwarm latticeSwarm = new LatticeModelSwarm(particles, targetDispProfile);

            return latticeSwarm;
        }

    }
}
