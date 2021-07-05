using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace C_Code
{
    /// <summary>
    /// Extra functionality that I really wanted to use so I made them.
    /// </summary>
    public static class Extensies
    {
        /// <summary>
        /// Takes in an array, and turns it into printable text line by line.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static string ArrToString(float[,] matrix, string delimiter = "\t")
        {
            var s = new StringBuilder();
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);
            float[,] spoofArray = (float[,])matrix;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    s.Append(spoofArray[i, j]).Append(delimiter);
                }
                s.AppendLine();
            }
            return s.ToString();
        }

        /// <summary>
        /// This asks windows (or your local OSS) for a seed list based on a seed.
        /// </summary>
        /// <param name="Seed"></param>
        /// <returns></returns>
        public static Random FixedSeedRandom(int Seed)
        {
            return new Random(Seed);
        }
    }
}
