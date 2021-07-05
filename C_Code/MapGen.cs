using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace C_Code
{
    /// <summary>
    /// The map generating magic occurs in this super class.
    /// </summary>
    public class MapGen
    {
        /// <summary>
        /// Creating and managing arrays, notice that it stores them too for easy calling.
        /// </summary>
        public class Arr
        {
            private float[,] Array;

            /// <summary>
            /// Creates an array of size X by Y and fils them with int numbers, this takes very slightly less
            /// space than just leaving them to figure out their contents on their own (they use doubles)
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            public Arr(int x, int y)
            {
                int k = 1;
                float[,] BuildArray = new float[x, y];
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        BuildArray[i, j] = k;
                        k += 1;
                    }
                }
                Array = BuildArray;
            }

            /// <summary>
            /// Functionality to get the X length out of the array.
            /// </summary>
            /// <returns></returns>
            public int getX()
            {
                return Array.GetLength(0);
            }

            /// <summary>
            /// Functionality to get the y length out of hte array.
            /// </summary>
            /// <returns></returns>
            public int getY()
            {
                return Array.GetLength(1);
            }

            /// <summary>
            /// Turns the array into a string to be printed or read.
            /// </summary>
            /// <returns></returns>
            public string getArrayString()
            {
                return Extensies.ArrToString(Array);
            }

            /// <summary>
            /// Grab the array.
            /// </summary>
            /// <returns></returns>
            public float[,] getArray()
            {
                return Array;
            }

            /// <summary>
            /// Update point x,y in the array with value value.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="value"></param>
            public void setPoint(int x, int y, float value)
            {
                Array[x, y] = value;
            }

            /// <summary>
            /// Overwrite the array in its entierity.
            /// </summary>
            /// <param name="matrix"></param>
            public void setArray(float[,] matrix)
            {
                Array = matrix;
            }

        }

        /// <summary>
        /// Perlin Noise creates and stores the arrays which make up PerlinNoise.
        /// </summary>
        public class PerlinNoise
        {
            private List<(float,float)> VectorMapA = new List<(float,float)> { (1f, 1f), (-1f, 1f), (1f, -1f), (-1f, -1f) }; //Not random array of vectors. I doubt this works.
            private float [,] VectorMapB;           //Randomly generated map of x,y vectors.
            private float [,] PerlinNoiseMap;       //Dependently randomly generated map of z values.
            private int NoiseDepth;                 // 1/Depth sized squares inside the big square. Perlin Noise really likes tiny(<0.2) distances over huge ones.
            //Create the PerlinNoise function.
            //Create a RandomVectorsMap which is +1 larger than it needs to be, this makes sure that we can handle any kind of map size.
            //Fills in the values in the ArrHandle Array with the new values, the greater the depth the more alike values will be to their neighbour.

            /// <summary>
            /// This is where the magic happens, generates Perlin-Noise for every point in the inputted array*depth
            /// it's a much larger array than the input array because perlin noise really likes gradients, for gradients
            /// small steps are necessery.
            /// </summary>
            /// <param name="Seed"></param> The seed integer.
            /// <param name="Depth"></param> 1/depth.
            /// <param name="ArrHandle"></param> 
            /// <param name="X"></param> Width of the array.
            /// <param name="Y"></param> Height of the array.
            public PerlinNoise(int Seed, int Depth, Arr ArrHandle, int X, int Y)//Sets PerlinNoiseMap, NoiseDepth.
            {
                /* int Seed: The predetermined seed, same seeds will always result in identical outcomes.
                 * int Depth: Determines how smooth the transition will be from one square too the next, the bigger the smoother.
                 * Arr ArrHandle: The array to create Noise for. Its values will be replaced with the new Noise Values.
                 */


                int Breedte = X * Depth;
                int Hoogte = Y * Depth;

                RandomVectorsMap(X +1, Y +1, Seed);
                NoiseDepth = Depth;
                float[,] NoiseMap = new float [Breedte,Hoogte];

                float xi = 0.0f;
                float yi = 0.0f;
                float growth = 1f / (Depth + 1);//This determines the amount of steps we simulate for each square.

                //Initial values
                int MyX = 0;
                int MyY = 0;

                float[] Vector1 = RadianToCoordinates(VectorMapB[MyX, MyY]);        //Top Left vector.
                float[] Vector2 = RadianToCoordinates(VectorMapB[MyX + 1, MyY]);    //Top Right vector.
                float[] Vector3 = RadianToCoordinates(VectorMapB[MyX, MyY + 1]);    //Bottom Left vector.
                float[] Vector4 = RadianToCoordinates(VectorMapB[MyX + 1, MyY + 1]);//Bottom Right vector.

                for (int x = 0; x < Breedte; x++)//Generating the NoiseMap
                {
                    xi += growth;
                    for (int y = 0; y < Hoogte; y++)
                    {
                        yi += growth;

                        float[] MyVector1 = new float[] {xi ,yi };              //Top left vector.
                        float[] MyVector2 = new float[] {xi - 1.0f, yi };       //Top right vector.
                        float[] MyVector3 = new float[] {xi , yi - 1.0f };      //Bottom Left vector.
                        float[] MyVector4 = new float[] {xi - 1.0f, yi - 1.0f }; //Bottom right vector.

                        float dot1 = dotProduct(Vector1, MyVector1); //Dot product top left corner.
                        float dot2 = dotProduct(Vector2, MyVector2); //Dot Product top right corner.
                        float dot3 = dotProduct(Vector3, MyVector3); //Dot product bottom left corner.
                        float dot4 = dotProduct(Vector4, MyVector4); //Dot Product bottom right corner.

                        float AB = dot1 + xi * (dot2 - dot1); //Interpolatie tussen punt1 en punt2
                        float CD = dot3 + xi * (dot4 - dot3); //Interpolatie tussen punt3 en punt4
                        float ABCD = AB + yi * (CD - AB);     //Interpolatue tussen punt AB en punt CD

                        ABCD = Fade((ABCD + 1) / 2); // Pushes value up into the positive 0-1 range;

                        NoiseMap[x, y] = ABCD;
                        if (yi >= Depth * growth)
                        {
                            yi = 0.0f;
                            MyY += 1;//Y value of top left point.
                            Vector1 = RadianToCoordinates(VectorMapB[MyX, MyY]);        //Top Left vector.
                            Vector2 = RadianToCoordinates(VectorMapB[MyX + 1, MyY]);    //Top Right vector.
                            Vector3 = RadianToCoordinates(VectorMapB[MyX, MyY + 1]);    //Bottom Left vector.
                            Vector4 = RadianToCoordinates(VectorMapB[MyX + 1, MyY + 1]);//Bottom Right vector.
                        }//Resets the yi value if it gets too big. And increments MyY. Updates Vector(1-4)
                    }
                    MyY = 0;
                    if(xi >= Depth * growth)
                    {
                        xi = 0.0f;
                        MyX += 1; //X value of top left point.
                        Vector1 = RadianToCoordinates(VectorMapB[MyX, MyY]);        //Top Left vector.
                        Vector2 = RadianToCoordinates(VectorMapB[MyX + 1, MyY]);    //Top Right vector.
                        Vector3 = RadianToCoordinates(VectorMapB[MyX, MyY + 1]);    //Bottom Left vector.
                        Vector4 = RadianToCoordinates(VectorMapB[MyX + 1, MyY + 1]);//Bottom Right vector.

                    }//Resets the xi value if it gets too big. And increments MyX.
                }
                PerlinNoiseMap = NoiseMap;
                /*ArrHandle.setArray(NoiseMap);*/
            }

            //Functions to make PerlinNoise work cleanly.
            /// <summary>
            /// Creates random vectors for an array of size Breedte * Hoogte using Seed to determine the seed.
            /// </summary>
            /// <param name="Breedte"></param>
            /// <param name="Hoogte"></param>
            /// <param name="Seed"></param>
            private void RandomVectorsMap(int Breedte, int Hoogte, int Seed)
            {//Currently called by PerlinNoise, could be called elsewhere too though.
                Random NoiseSeed = Extensies.FixedSeedRandom(Seed);
                float [,] resultaat = new float [Breedte + 1, Hoogte + 1];

                for(int x = 0; x < Breedte; x++)
                {
                    for(int y = 0; y < Hoogte; y++)
                    {
                        float a = (float)NoiseSeed.NextDouble() * 2 - 1;
                        float b = (float)NoiseSeed.NextDouble() * 2 - 1;
                        float radians = (float)Math.Atan2(a, b);
                        resultaat[x, y] = radians;
                    }
                }
                VectorMapB = resultaat;
            }//Generates a vectormap containing Radians for the vectors. 

            /// <summary>
            /// Returns vectorMapB
            /// </summary>
            /// <returns></returns>
            public float[ , ] GetRandomVectorsMap()
            {
                return VectorMapB;
            }

            /// <summary>
            /// Translates radians to Coordinates, returns float [v1,v2]
            /// </summary>
            /// <param name="Radian"></param>
            /// <returns></returns>
            public float[] RadianToCoordinates(float Radian)
            {//Transforms a radian input into its corresponding vector.
                return new float[] {(float)Math.Cos(Radian) , (float)Math.Sin(Radian)};
            }

            /// <summary>
            /// Calculates the dotproduct between two vectors a and b, returns float value.
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public float dotProduct( float[] a, float[] b)
            {//Calculates the dotProduct between the vectors a and b.
                float result = a[0] * b[0] + a[1] * b[1];
                return result;
            }


            /// <summary>
            /// Fade function smoothes value t inputted, the input must be between 0 and 1 to avoid esoteric results.
            /// </summary>
            /// <param name="t"></param>
            /// <returns></returns>
            static private float Fade(float t)//Used in PerlinNoise 
            {//Smoothes out the values with the power of math. s(t) = 6t^5 -15t^4 +10t^3 Input must be between 0 - 1.
                return (t * t * t * (t * (6 * t - 15) + 10));
            }

            //Grab information from PerlinNoise
            public float [,] getPerNoiseMap()
            {
                return PerlinNoiseMap;
            }//Grabby PerlinNoiseMap

            public float [,] getVectorMap()
            {
                return VectorMapB;
            }//Grabby vectormap.

            public int getNoiseDepth()
            {
                return NoiseDepth;
            }// Grabby NoiseDepth

            //Set information to PerlinNoise
            //Currently no functions to set anything in PerlinNoise.
        }

        /// <summary>
        /// Smoothemap functionality, takes perlin noise and makes it into a map.
        /// </summary>
        public class SmootheMap
        {
            private float [,] ValuesMap;
            
            /// <summary>
            /// Takes its inputs and then happily turns it into a map actually worth playing.
            /// </summary>
            /// <param name="PerlinMap"></param>
            /// <param name="SmootheRuns"></param>
            /// <param name="Strictness"></param>
            /// <param name="Strictness2"></param>
            /// <param name="Width"></param>
            /// <param name="Height"></param>
            /// <param name="Depth"></param>
            public SmootheMap(PerlinNoise PerlinMap, int SmootheRuns, float Strictness, float Strictness2,int Width, int Height, int Depth)
            {
                /* Smoothes the values on the map. Strictness determines at which neighbour value a square is replaced.
                 * Adds up all the valid neighbouring squares + itself, then checks it versus Strictness.
                 * Arr ArrName: The Array too be smoothed out.
                 * int SmootheRuns: How often too smoothe for.
                 * float Strictness: The cutoff point. Values smaller than it will become 0, values larger will become 1.
                 * int Width: The width of the new map we create.
                 * int Heihgt: The height of hte new map we create.
                 */

                float [,] PerlinArray = PerlinMap.getPerNoiseMap();
                int Breedte = PerlinArray.GetLength(0);
                int Hoogte = PerlinArray.GetLength(1);
                float value = 0.0f;
                /*int ChunkX;
                int ChunkY;*/
                float[,] resultMap = new float[Width,Height]; 
                float[,] Chunk = new float[Depth,Depth];

                for (int x = 0; x < Width; x ++)
                {
                    for (int y = 0; y < Height; y ++)
                    {
                        for (int ChunkX = 0; ChunkX < Depth; ChunkX ++)
                        {
                            for (int ChunkY = 0; ChunkY < Depth; ChunkY++)
                            {
                                Chunk[ChunkX, ChunkY] = PerlinArray[x * Depth + ChunkX, y * Depth + ChunkY];
                                ChunkY += 1;
                            }
                            ChunkX += 1;
                        }
                        value = GetSquareValue(Chunk);
                        if (value > Strictness)
                        {
                            resultMap[x, y] = 1.0f;
                        }
                        else
                        {
                            resultMap[x, y] = 0.0f;
                        }
                    }
                }

                for(int i = 0; i < SmootheRuns; i++)
                {
                    resultMap = Smoothe(resultMap, Strictness2);
                }
                ValuesMap = resultMap;
            }

            private float GetSquareValue(float [,] square)
            {
                int width = square.GetLength(0);
                int height = square.GetLength(1);
                float result = 0.0f;


                for(int y = 0; y < height; y++)
                {
                    for(int x = 0; x < width; x++)
                    {
                        result += square[x, y];
                    }
                }
                return result / (width * height);
            }

            private float [,] Smoothe(float [,] SmootheArray, float strictness)
            {
                int Hoogte = SmootheArray.GetLength(1);
                int Breedte = SmootheArray.GetLength(0);
                float[,] resultArray = new float[Breedte, Hoogte];
                for (int y = 0; y < Hoogte; y++)
                {
                    for (int x = 0; x < Breedte; x++)
                    {
                        int Neighbours = 1;
                        float Som = SmootheArray[x, y];
                        //Checks for every possible permuation.
                        if (x - 1 >= 0)
                        {
                            Neighbours += 1;
                            Som += SmootheArray[x - 1, y];
                            if (y - 1 > 0)
                            {
                                Neighbours += 1;
                                Som += SmootheArray[x - 1, y - 1];
                            }
                            if (y + 1 < Hoogte)
                            {
                                Neighbours += 1;
                                Som += SmootheArray[x - 1, y + 1];
                            }
                        }
                        if (x + 1 < Breedte)
                        {
                            Neighbours += 1;
                            Som += SmootheArray[x + 1, y];
                            if (y - 1 >= 0)
                            {
                                Neighbours += 1;
                                Som += SmootheArray[x + 1, y - 1];
                            }
                            if (y + 1 < Hoogte)
                            {
                                Neighbours += 1;
                                Som += SmootheArray[x + 1, y + 1];
                            }
                        }
                        if (y - 1 >= 0)
                        {
                            Neighbours += 1;
                            Som += SmootheArray[x, y - 1];
                        }
                        if (y + 1 < Hoogte)
                        {
                            Neighbours += 1;
                            Som += SmootheArray[x, y + 1];
                        }

                        float result = Som / Neighbours;
                        if (result > strictness)
                        {
                            resultArray[x, y] = 1.0f;
                        }
                        else
                        {
                            resultArray[x, y] = 0.0f;
                        }
                    }
                }
                return resultArray;
            }

            public float [,] GetValuesMap()
            {
                return ValuesMap;
            }
        }
    }//Functions related to Noise, the randomizer.
}
