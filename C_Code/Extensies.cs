using System;
using System.Collections.Generic;
using System.Text;

namespace C_Code
{
    public static class Extensies
    {
        /*public static string MatrixToString<T>(this T[,] matrix, string delimiter = "\t")*/
        public static string ArrToString( Array matrix, string delimiter = "\t")
        {
            var s = new StringBuilder();
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);
            int[,] spoofArray = (int[,])matrix;
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
    }
}
