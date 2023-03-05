using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms.Types
{

    public interface IOptimizationAlgorithm<T> where T : class
    {
        T GetInstance();
    }


    public abstract class OptimizationAlgorithmBase<T> : IOptimizationAlgorithm<T> where T : class
    {

        #region Singleton Implementation

        private static T instance;

        public T GetInstance()
        {
            if (instance == null)
            {
                instance = CreateInstance();
            }

            return instance;
        }

        protected abstract T CreateInstance();
        #endregion

        #region Optimization Base

        public abstract void Run();
        
        #endregion
    }
}
