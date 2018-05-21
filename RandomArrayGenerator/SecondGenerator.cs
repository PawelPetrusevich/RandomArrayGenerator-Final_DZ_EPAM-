using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArrayGenerator
{
    public class SecondGenerator
    {
        private const double SUM = 1;

        /// <summary>
        /// Array generator algoritm
        /// </summary>
        /// <param name="n">array length</param>
        /// <returns>double random array</returns>
        public double[] GenerateArray(int n)
        {
            if (n <= 1)
            {
                throw new ArgumentException(nameof(n));
            }

            double[] array = new double[n];
            List<double> tempArray = new List<double>();
            var minNumber = 0;

            while (tempArray.Sum() < 1)
            {
                var maxNumber = (SUM - tempArray.Sum()) / n;
                var tempNumber = new Random().NextDouble(minNumber, maxNumber);

                if (!double.IsInfinity(tempNumber))
                {
                    tempArray.Add(tempNumber);
                }

                if (Math.Abs(SUM - tempArray.Sum()) < 0.000000001)
                {
                    array = tempArray.ToArray(n);
                    return array;
                }
            }

            return array;
        }
    }
}
