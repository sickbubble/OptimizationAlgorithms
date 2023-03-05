using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.Particles
{
   
    public interface IParticle
    {
        double [] PersonalBestPostion { get; set; }

        double Fitness { get; set; }
        double PersonalBestFitness { get; set; }

        void SetFitness(double fitness);

        void UpdateVelocity(double inertiWeight, double cognitiveLearningFactor, double socialLearningFactor, double[] gbest);
        void UpdatePosition();

        double [] Velocity { get; set; }
        double [] Position { get; set; }

        int Dimension { get;  }
        void SetDimension(int dimension);

        void CheckPersonalBest(double fitness);



    }
}
