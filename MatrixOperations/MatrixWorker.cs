using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    public class MatrixWorker 
    {
        private readonly int[,] _firstMatrix = new int[,] { { 1, 2, 3 }, { 4, 6, 73 }, { 10, 25, 43 }, { 61, 72, 13 }, { 41, 15, 345 } };
        private readonly int[,] _secondMatrix = new int[,] { { 1, 2, 3 , 4, 5 }, { 45, 25, 13, 74, 45 }, { 18, 92, 13, 34, 45 } };

        public int[,] Process() {
           return SubtractionMean(SortMatrices(MultiplyMatrices(_firstMatrix, _secondMatrix)));
        }

        private int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            var result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < secondMatrix.GetLength(0); k++)
                    {
                        result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }
            return result;
        }

        private int[,] SortMatrices(int[,] matrix)
        {
            var arr = matrix.Cast<int>().OrderBy(a => a).ToArray();
            int counter = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[j, k] = arr[counter];
                    counter++;
                }
            }
            return matrix;
        }

        private int[,] SubtractionMean(int[,] matrix)
        {
            var summ = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    summ += matrix[j, k];
                }
            }
            summ /= matrix.GetLength(0) * matrix.GetLength(0);
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    matrix[j, k] -= summ;
                }
            }
            return matrix;
        }
    }
}
