// --------------------------------------------------------------------------------------------------------------------
// <copyright company="RandomArrayGenerator" file=" Extensions.cs">
//  Creator name: 
//  Solution: RandomArrayGenerator
//  Project: RandomArrayGenerator    
// </copyright>
// <summary>
//  Filename: Extensions.cs
//  Created day: 21.05.2018    20:17
//  </summary> 
//  --------------------------------------------------------------------------------------------------------------------

namespace RandomArrayGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        /// <summary>
        /// extension methods for double random number
        /// </summary>
        /// <param name="random">this random</param>
        /// <param name="minNumber">min value</param>
        /// <param name="maxNumber">max value</param>
        /// <returns>random double number in range</returns>
        public static double NextDouble(this Random random, double minNumber, double maxNumber)
        {
            return random.NextDouble() * (maxNumber - minNumber) + minNumber;
        }

        /// <summary>
        /// extension methods for convert double list to array
        /// </summary>
        /// <param name="list">this list</param>
        /// <param name="n">array length</param>
        /// <returns>double array</returns>
        public static double[] ToArray(this List<double> list, int n)
        {
            double[] array = new double[n];

            for (int i = 0; i < n - 1; i++)
            {
                array[i] = list[i];
            }

            for (int i = n - 1; i < list.Count; i++)
            {
                array[n - 1] = array[n - 1] + list[i];
            }

            return array;
        }
    }
}