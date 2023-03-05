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
    class LatticeModelSwarm : BaseSwarm
    {
        public LatticeModelSwarm(List<IParticle> latticeParticles)
        {
            this.Particles = latticeParticles;

        }

        private double[] _TargetDisplacementProfile;

        public double[] TargetDisplacementProfile { get => _TargetDisplacementProfile; set => _TargetDisplacementProfile = value; }
    }
}
