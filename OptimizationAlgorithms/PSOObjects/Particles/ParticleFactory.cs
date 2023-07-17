using OptimizationAlgorithms.Particles;
using OptimizationAlgorithms.Swarms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.PSOObjects.Particles
{
    public class ParticleFactory : IFactory
    {
        public ParticleFactory()
        {

        }

        public IProduct Create()
        {
            return new BaseParticle();
        }

        public LatticeParticle CreateLatticleParticle(double[] position) 
        {
            LatticeParticle latticeParticle = new LatticeParticle(position);

            return latticeParticle;
        }



    }
}
