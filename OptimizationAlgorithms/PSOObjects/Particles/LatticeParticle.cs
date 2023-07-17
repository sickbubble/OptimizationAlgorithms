using OptimizationAlgorithms.Particles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.PSOObjects.Particles
{
    public class LatticeParticle : BaseParticle
    {
        public LatticeParticle(double [] position)
        {
            SetDimension(position.Length);
            this.Position = new double[position.Length] ;
            for (int i = 0; i < position.Length; i++)
            {
                this.Position[i] = position[i];
            }

            this.Velocity = new double[Dimension];
        }


        private double[] _DisplacementProfile;

        public double[] DisplacementProfile { get => _DisplacementProfile; set => _DisplacementProfile = value; }
    }
}
