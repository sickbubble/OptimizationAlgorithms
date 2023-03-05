using OptimizationAlgorithms.PSOObjects;
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

    class SwarmFactory : IFactory
    {
        public IProduct Create()
        {
            return new Swarm();
        }
    }
}
