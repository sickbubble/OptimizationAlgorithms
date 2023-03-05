using OptimizationAlgorithms.Particles;
using OptimizationAlgorithms.PSOObjects.Particles;
using OptimizationAlgorithms.PSOObjects.Swarms;
using OptimizationAlgorithms.Swarms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.Types
{
    public sealed class PSOAlgorithm : OptimizationAlgorithmBase<PSOAlgorithm>
    {
        public PSOAlgorithm()
        {

        }



        public PSOAlgorithm(ISwarm swarm)
        {
            _Swarm = swarm;
        }

        #region Private Fields
        private IFitnessFunction _FitnessFunction;
        private ISwarm _Swarm;
        private double _InertiaWeight;
        private double _CognitiveLearningFactor;
        private double _SocialLearnigFactor;


        #endregion


        #region Observer Implementation
        private List<IObserver> _Observers;
        public void RegisterObserver(IObserver observer)
        {
            this._Observers.Add(observer);
        }

        private void NotifyConvergence(double fitness)
        {
            foreach (IObserver observer in _Observers)
            {
                observer.NotifyConvergence(fitness);
            }
        }

        private void NotifyNewGlobalBest(double fitness, double[] position)
        {
            foreach (IObserver observer in _Observers)
            {
                observer.NotifyNewGlobalBest(fitness, position);
            }
        }

        #endregion


        #region Public Properties


        public IFitnessFunction FitnessFunction { get => _FitnessFunction; set => _FitnessFunction = value; }
        public ISwarm Swarm { get => _Swarm; set => _Swarm = value; }
        public double GlobalBest
        {
            get { return _GlobalBest; }
            set
            {
                _GlobalBest = value;
            }
        }

        public double InertiaWeight { get => _InertiaWeight; set => _InertiaWeight = value; }
        public double CognitiveLearningFactor { get => _CognitiveLearningFactor; set => _CognitiveLearningFactor = value; }
        public double SocialLearnigFactor { get => _SocialLearnigFactor; set => _SocialLearnigFactor = value; }

        #endregion



        #region Singleton Implementation
        protected override PSOAlgorithm CreateInstance()
        {
            return new PSOAlgorithm();
        }
        #endregion



        #region Optimization Implementation

        private double _GlobalBest;

        void CheckGlobalBest(IParticle particle)
        {
            if (particle.Fitness < _Swarm.GlobalBestFitness)
            {
                _Swarm.SetGlobalBestPosition(particle.PersonalBestPostion);
                _Swarm.GlobalBestFitness = particle.Fitness;
                NotifyNewGlobalBest(particle.Fitness, particle.Position);
            }
        }
        double EvaluateFitness(IParticle particle)
        {
            var fitness = _FitnessFunction.Evaluate((particle as LatticeParticle).DisplacementProfile, (_Swarm as LatticeModelSwarm).TargetDisplacementProfile);
            particle.SetFitness(fitness);
            return fitness;
        }

        public override void Run()
        {
            bool runAlgorithm = true;
            foreach (var particle in _Swarm.Particles)
            {
                _FitnessFunction.Evaluate((particle as LatticeParticle).DisplacementProfile, (_Swarm as LatticeModelSwarm).TargetDisplacementProfile);

            }
            while (runAlgorithm)
            {
                foreach (var particle in _Swarm.Particles)
                {
                    UpddateParticle(particle);
                    particle.CheckPersonalBest(EvaluateFitness(particle));
                    CheckGlobalBest(particle);
                }
            }
        }
        #endregion





        #region Inıtialize

        public void SetAlgorithmParams(IFitnessFunction fitnessFunction,
            ISwarm swarm,
            double inertiaWeight,
            double cognitiveLearningFactor,
            double socialLearningFactor)
        {
            _FitnessFunction = fitnessFunction;
            _Swarm = swarm;
            _InertiaWeight = inertiaWeight;
            _CognitiveLearningFactor = cognitiveLearningFactor;
            _SocialLearnigFactor = socialLearningFactor;
        }

        #endregion


        #region PSO Specific Methods



        private void UpddateParticle(IParticle particle)
        {
            UpdateParticleVelocity(particle);
            UpdateParticlePosition(particle);
        }

        private void UpdateParticleVelocity(IParticle particle)
        {
            particle.UpdateVelocity(_InertiaWeight, _CognitiveLearningFactor, _SocialLearnigFactor, _Swarm.GlobalBestPosition);

        }

        private void UpdateParticlePosition(IParticle particle)
        {
            particle.UpdatePosition();

        }

        #endregion


    }

}
