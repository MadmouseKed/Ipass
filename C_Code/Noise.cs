using System;
using System.Collections.Generic;
using System.Text;

namespace C_Code
{
    public class Noise
    {
        /*private Array NoiseArray;
        public Noise(int x, int y) //Lege array van grootte x by y. (2-dimensionaal array)
        {
            int[,] NoiseArray = new int[x, y];
        }*/
       
        public class ArrayObject
        {
            private Array NoiseArray;

            public ArrayObject(int x, int y)
            {
                int k = 1;
                int[,] BuildArray = new int[x, y];
                for(int i = 0; i < x; i++)
                {
                    for(int j = 0; j < y; j++)
                    {
                        BuildArray[i,j] = k;
                        k += 1;
                    }
                }
                NoiseArray = BuildArray;
            }

            public string GetArray()
            {
            return Extensies.ArrToString(NoiseArray);
            }
        }

        

        public void CaveGen()
        {

        }

        public void BuiltGen()
        {

        }
    }
}
