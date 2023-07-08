using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizationAlgorithms.FitnessFunction;
using OptimizationAlgorithms.Particles;
using OptimizationAlgorithms.PSOObjects.Particles;
using OptimizationAlgorithms.Swarms;
using OptimizationAlgorithms.Types;

namespace OptimizationAlgorithms
{
    class Program : IObserver
    {
        static void Main(string[] args)
        {
            int numParticles = 10;
            int numDimensions = 2;


            // Initialize the particles
            ParticleFactory particleFactory = new ParticleFactory();
            var particles = new List<IParticle>();
            for (int i = 0; i < numParticles; i++)
            {
                var position = new double[numDimensions];
                var particle =  particleFactory.CreateLatticleParticle(position);
                particles.Add(particle);
            }

            // Initialize the SwarmFactory
            SwarmFactory swarmFactory = new SwarmFactory();

            // Initialize the Swarm
            ISwarm swarm =  swarmFactory.CreateLatticeModelSwarm(particles,new double[10]);
            

            // Initialize the PSOAlgorithm
            IOptimizationAlgorithm<PSOAlgorithm> algorithm = new PSOAlgorithm();
            var instance =  algorithm.GetInstance();

            IFitnessFunction fitnessFunction = new SumofSquaredDeviations();
            instance.SetAlgorithmParams(fitnessFunction, swarm,0.5,2.0,2.0);
            // Run the algorithm
            instance.Run();
        }




        public void NotifyConvergence(double fitness)
        {
            Console.WriteLine($"PSO algorithm converged to fitness value {fitness}.");
        }

        public void NotifyNewGlobalBest(double fitness, double[] position)
        {
            Console.WriteLine($"New global best solution found with fitness value {fitness} and position vector [{string.Join(", ", position)}].");
        }

     

        public void UpdateResult(IParticle particle)
        {
            throw new NotImplementedException();
        }
    }
}
