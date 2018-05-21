using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArrayGenerator
{
    public class FirstGenerator
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
            double minValue = 0;
            int i = 0;

            while (i < n - 1)
            {
                var maxValue = SUM - array.Sum();
                var tempNumber = new Random().NextDouble(minValue, maxValue);

                if (!double.IsInfinity(tempNumber))
                {
                    array[i] = tempNumber;
                    i++;
                }
            }

            array[n - 1] = SUM - array.Sum();

            return array;
        }
    }
}
