using System;
using System.Collections.Generic;
using System.Text;

namespace C_Code
{
    class UnitTests
    {
        private int Seed = 1294;
        private int WidthX = 256;
        private int HeightY = 256;
        private int CycleDepth = 8;

        private MapGen.Arr InitialArray;
        private MapGen.PerlinNoise PerlinNoise;

        private string UnitTestResults = "Test not run yet.";
        


        public UnitTests()
        {
            UnitTestResults = "Begin test report" + "\n";
            string RVMT = RandomVectorsMapTest();
            UnitTestResults += RVMT;
            /*PerlinNoise.FloatNoise(65,63,64);*/


            Console.WriteLine(UnitTestResults);
        }

        public string GetTestResults()
        {
            return UnitTestResults;
        }

        private string RandomVectorsMapTest()
        {
            string text = "========================================================== \n" +
                "Random Vectors Map Test. \n" +
                "Checking for a value that is larger than 1 or smaller than -1 \n";
            float[,] VectorMapB;
            float[] SineCosinePoint;
            float a;
            float b;
            int IssueCounter = 0;
            Boolean Check = true;
            InitialArray = new MapGen.Arr(WidthX, HeightY);
            PerlinNoise = new MapGen.PerlinNoise(Seed, CycleDepth, InitialArray, 5, 5);
            VectorMapB = PerlinNoise.GetRandomVectorsMap();
            for(int x = 0; x < VectorMapB.GetLength(0); x++)
            {
                for(int y = 0; y < VectorMapB.GetLength(1); y++)
                {
                    SineCosinePoint = PerlinNoise.RadianToCoordinates(VectorMapB[x,y]);
                    a = SineCosinePoint[0];
                    b = SineCosinePoint[1];
                    /*Console.WriteLine(a + ":" + b);*/
                    if(a > 1 | a < -1 | b > 1 | b < -1)
                    {
                        IssueCounter += 1;
                        Check = false;
                        text += "Issue found at point: " + x + ":" + y + " Value(s): " + a + ":" + b + "\n";
                    }
                }
            }

            if(Check)
            {
                text += "Random VectorsMapTest concluded with no anomaly found. \n" +
                    "\n";
            }
            else
            {
                text += "For a total of " + IssueCounter + " issues. \n";
            }
            return text;
        }

        /*private string DotProductTest()
        {
            Boolean Check = true;

            string text = "========================================================== \n" +
                "Dot Product Test. \n" +
                "Checking for a value that is larger than 1 or smaller than -1 \n";
            PerlinNoise.dotProduct();

            for (int x = 0; x < VectorMapB.GetLength(0); x++)
            {
                for (int y = 0; y < VectorMapB.GetLength(1); y++)
                {
                    SineCosinePoint = PerlinNoise.RadianToCoordinates(VectorMapB[x, y]);
                    a = SineCosinePoint[0];
                    b = SineCosinePoint[1];
                    *//*Console.WriteLine(a + ":" + b);*//*
                    if (a > 1 | a < -1 | b > 1 | b < -1)
                    {
                        IssueCounter += 1;
                        Check = false;
                        text += "Issue found at point: " + x + ":" + y + " Value(s): " + a + ":" + b + "\n";
                    }
                }
            }

            if (Check)
            {
                text += "Random VectorsMapTest concluded with no anomaly found. \n" +
                    "\n";
            }
            else
            {
                text += "For a total of " + IssueCounter + " issues. \n";
            }
            return text;

            return text;
        }*/
    }
}
