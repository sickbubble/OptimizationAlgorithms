using OptimizationAlgorithms.PSOObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.Particles
{
    public class BaseParticle : IProduct, IParticle
    {
        public BaseParticle()
        {

        }




        #region IParticle Implementation
        public double[] PersonalBestPostion { get => _PersonalBestPosition; set => _PersonalBestPosition = value; }
        public double Fitness { get => _Fitness; set => _Fitness = value; }
        public double[] Velocity { get => _Velocity; set => _Velocity = value; }
        public double[] Position { get => _Position; set => _Position = value; }
        public int Dimension { get => _Dimension; private set => _Dimension = value; }
        public double PersonalBestFitness { get => _PersonalBestFitness; set => _PersonalBestFitness = value; }

        private double[] _PersonalBestPosition;
        private double _Fitness;
        private double _PersonalBestFitness;
        private double[] _Velocity;
        private double[] _Position;
        private int _Dimension;

        public void SetFitness(double fitness)
        {
            _Fitness = fitness;
            //if (_Fitness < _PersonalBest)
            //{
            //    _PersonalBest = fitness;
            //}

        }
        private static double[] GenerateRandomVector(int length, double minValue, double maxValue)
        {
            Random random = new Random();
            double[] vector = new double[length];
            for (int i = 0; i < length; i++)
            {
                vector[i] = random.NextDouble() * (maxValue - minValue) + minValue;
            }
            return vector;
        }
   





        public void UpdateVelocity(double inertiWeight, double cognitiveLearningFactor, double socialLearningFactor, double[] gbest)
        {
                var r1 = GenerateRandomVector(this.Dimension,0,1);
                var r2 = GenerateRandomVector(this.Dimension,0,1);
            for (int j = 0; j < this.Dimension; j++)
            {
                this.Velocity[j] = inertiWeight * this.Velocity[j] +
            cognitiveLearningFactor * r1[j] * (_PersonalBestPosition[j] - this.Position[j]) +
            socialLearningFactor * r2[j] * (gbest[j] - this.Position[j]);
            }

        }

        public void UpdatePosition() 
        {
            for (int i = 0; i < this.Dimension; i++)
            {
                this._Position[i] = this._Velocity[i];

            }
        }

        public void SetDimension(int dimension)
        {
            _Dimension = dimension;
        }

     

        public void CheckPersonalBest(double fitness)
        {
            if (this.Fitness > fitness)
            {
                this.PersonalBestFitness = fitness;
                this.PersonalBestPostion = this.Position;

                }
        }

        #endregion


    }
}
