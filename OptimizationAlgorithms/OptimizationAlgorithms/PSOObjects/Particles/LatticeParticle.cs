using OptimizationAlgorithms.Particles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.PSOObjects.Particles
{
    class LatticeParticle : BaseParticle
    {
        public LatticeParticle(double [] position)
        {
            this.Position = position;
            SetDimension(position.Length);
            this.Velocity = new double[Dimension];
        }


        private double[] _DisplacementProfile;

        public double[] DisplacementProfile { get => _DisplacementProfile; set => _DisplacementProfile = value; }
    }
}
