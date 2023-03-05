using OptimizationAlgorithms.Particles;
using OptimizationAlgorithms.PSOObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.Swarms
{
    public class BaseSwarm : ISwarm, IProduct
    {
        public BaseSwarm()
        {

        }
        

        #region ISwarm Implementations
        public List<IParticle> Particles { get => _Particles; set => _Particles = value; }
        private List<IParticle> _Particles;
        private double _GlobalBestFitness;
        private double[] _GlobalBestPosition;



        public double GlobalBestFitness { get => _GlobalBestFitness; set => _GlobalBestFitness = value; }
        public double[] GlobalBestPosition { get => _GlobalBestPosition; set => _GlobalBestPosition = value; }



        public void SetGlobalBestFitness(double globalBest)
        {
            _GlobalBestFitness = globalBest;
        }
        public void SetGlobalBestPosition(double[] globalBest)
        {
            _GlobalBestPosition = globalBest;
        }

        public void SetGlobalBest(double globalBest)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
