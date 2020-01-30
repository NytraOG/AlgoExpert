using System.Collections.Generic;

namespace Riversizes
{
    public class RiverFinder
    {
        public List<int> RiverSizes(int[,] matrix)
        {
            var riverSizes        = new List<int>();
            var zelleAbgeklappert = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                        continue;

                    zelleAbgeklappert[i, j] = true;
                    var counter = 1;

                    counter += RecursiveNeighborCheck(counter, zelleAbgeklappert, matrix,i, j);

                    riverSizes.Add(counter);
                }
            }

            return riverSizes;
        }

        private int RecursiveNeighborCheck(int counter, bool[,] zelleAbgeklappert, int[,] matrix, int i, int j)
        {
            var localCounter = counter;

            if (matrix.GetUpperBound(1) > i + 1 && !zelleAbgeklappert[i + 1, j] && matrix[i + 1, j] != 0 )
            {
                zelleAbgeklappert[i + 1, j] = true;
                localCounter += RecursiveNeighborCheck(counter, zelleAbgeklappert, matrix, i + 1, j);
            }
            //if(matrix.GetUpperBound(1) > i + 1)
            //    zelleAbgeklappert[i + 1, j] = true;

            if (matrix.GetUpperBound(0) > j + 1 && !zelleAbgeklappert[i, j + 1] && matrix[i, j + 1] != 0 )
            {
                zelleAbgeklappert[i, j + 1] = true;
                localCounter += RecursiveNeighborCheck(counter, zelleAbgeklappert, matrix, i, j +1);
            }
            //if(matrix.GetUpperBound(0) > j + 1)
            //    zelleAbgeklappert[i, j + 1] = true;

            if (matrix.GetLowerBound(1) <= i - 1 && !zelleAbgeklappert[i - 1, j] && matrix[i - 1, j] != 0 )
            {
                zelleAbgeklappert[i - 1, j] = true;
                localCounter += RecursiveNeighborCheck(counter, zelleAbgeklappert, matrix, i - 1, j);
            }
            //if(matrix.GetLowerBound(1) <= i - 1)
            //    zelleAbgeklappert[i - 1, j] = true;

            if (matrix.GetLowerBound(0) <= j - 1 && !zelleAbgeklappert[i, j - 1] &&  matrix[i, j - 1] != 0)
            {
                zelleAbgeklappert[i, j - 1]= true;
                localCounter += RecursiveNeighborCheck(counter, zelleAbgeklappert, matrix, i, j -1);
            }
            //if(matrix.GetLowerBound(0) <= j - 1)
            //    zelleAbgeklappert[i, j - 1] = true;

            return localCounter;
        }
    }
}