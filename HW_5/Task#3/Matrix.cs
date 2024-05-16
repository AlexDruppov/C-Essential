using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Matrix
    {
        private int[,] matrix;

        public Matrix(int rows, int cols)
        {
            matrix = new int[rows, cols];
        }

        public void Set(int row, int col, int value)
        {
            matrix[row, col] = value;
        }

        public void Method()
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

