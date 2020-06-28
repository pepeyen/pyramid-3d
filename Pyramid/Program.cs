using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int pyramidSize;
            do
            {
                Console.Write("Please insert the desired size: ");
                pyramidSize = Convert.ToInt32(Console.ReadLine()); //User input that determines the pyramid size |Have to be a even number, otherwise Pyramid doesn't look so good :p|

                if (pyramidSize % 2 != 0)
                {

                    Console.WriteLine("\n|Oops, looks like you tried to insert " + pyramidSize + ", please insert a even number and try again|");

                }
                Console.Write("\n");
            } while (pyramidSize % 2 != 0);

            PrintPyramid(pyramidSize);

            Console.Write("\n\nPress any key to end the App");
            Console.ReadKey();
        }
        //Function which show the Pyramid
        static void PrintPyramid(int pyramidSize)
        {
            Separators(pyramidSize);

            Console.Write("\n");

            InsertPyramid(pyramidSize);

            Console.Write("\n");

            Separators(pyramidSize);
        }
        //Function which insert the Pyramid values into a array
        static void InsertPyramid(int pyramidSize)
        {
            int[,] pyramidArray = new int[pyramidSize + 1, pyramidSize + 1]; //Array which holes the Pyramid values
            int Z;
            //Filling the pyramid array
            for (int X = 1; X <= pyramidSize; X++)
            {
                for (int Y = 1; Y <= pyramidSize; Y++)
                {
                    if (X == Y)
                    {
                        Z = X;
                        pyramidArray[X, Y] = Z;
                    }
                    else
                    {
                        if (X > Y)
                        {
                            Z = Y;
                            pyramidArray[X, Y] = Z;
                        }
                        else
                        {
                            if (X < Y)
                            {
                                Z = X;
                                pyramidArray[X, Y] = Z;
                            }
                        }
                    }
                }
            }
            //Function calls that print the Pyramid
            PyramidTopQuadrant(pyramidArray, pyramidSize);
            PyramidBottomQuadrant(pyramidArray, pyramidSize);
        }
        //Function which print the top quadrant of the Pyramid
        static void PyramidTopQuadrant(int[,] pyramidArray, int pyramidSize)
        {
            for (int X = 1; X <= (pyramidSize / 2); X++)
            {
                //1º Quadrant
                for (int Y = 1; Y <= (pyramidSize / 2); Y++)
                {
                    if (pyramidArray[X, Y] >= 10) //Trying to solve double digits spacing problem
                    {
                        Console.Write(" {0}", pyramidArray[X, Y]);
                    }
                    else Console.Write(" {0} ", pyramidArray[X, Y]);
                }
                //2º Quadrant
                for (int Y = (pyramidSize / 2); Y >= 1; Y--)
                {
                    if (pyramidArray[X, Y] >= 10) //Trying to solve double digits spacing problem
                    {
                        Console.Write("{0} ", pyramidArray[X, Y]);
                    }
                    else Console.Write(" {0} ", pyramidArray[X, Y]);
                }
                Console.Write("\n");
            }
        }
        //Function which print the bottom quadrant of the Pyramid
        static void PyramidBottomQuadrant(int[,] pyramidArray, int pyramidSize)
        {
            for (int X = (pyramidSize / 2); X >= 1; X--)
            {
                //3º Quadrant
                for (int Y = 1; Y <= (pyramidSize / 2); Y++)
                {
                    if (pyramidArray[X, Y] >= 10) //Trying to solve double digits spacing problem
                    {
                        Console.Write(" {0}", pyramidArray[X, Y]);
                    }
                    else Console.Write(" {0} ", pyramidArray[X, Y]);
                }
                //4º Quadrant
                for (int Y = (pyramidSize / 2); Y >= 1; Y--)
                {
                    if (pyramidArray[X, Y] >= 10) //Trying to solve double digits spacing problem
                    {
                        Console.Write("{0} ", pyramidArray[X, Y]);
                    }
                    else Console.Write(" {0} ", pyramidArray[X, Y]);
                }
                Console.Write("\n");
            }
        }
        //Function which print separators using the Pyramid Size into account
        static void Separators(int pyramidSize)
        {
            for (int i = 1; i <= (pyramidSize / 2); i++)
            {
                Console.Write("======");
            }
        }
    }
}