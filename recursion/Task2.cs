using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    internal class Task2
    {
        private int[,] Matrix = {
            { 1, 1 },
            { 1, 0 }
        };

        private int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
        {
            var c11 = matrix1[0, 0] * matrix2[0, 0] + matrix1[0, 1] * matrix2[1, 0];
            var c12 = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
            var c21 = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 1] * matrix2[1, 0];
            var c22 = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1];

            return new[,]
            {
                { c11, c12 },
                { c21, c22 }
            };
        }

        private int[,] PowerMatrix(int p)
        {
            if (p == 1)
                return Matrix;

            var poweredMatrix = PowerMatrix(p / 2);
            var squaredMatrix = MultiplyMatrix(poweredMatrix, poweredMatrix);
            
            if (p % 2 == 0)
                return squaredMatrix;

            return MultiplyMatrix(squaredMatrix, Matrix);
        }

        public int RecursionSolution(int p)
        {
            var poweredMatrix = PowerMatrix(p);
            return poweredMatrix[0, 1];
        }

        public int IterableSolution(int p)
        {
            var result = new[,]
            {
                { 1, 0 },
                { 0, 1 }
            };

            for (;p > 0; p /= 2)
            {
                if (p % 2 != 0)
                    result = MultiplyMatrix(result, Matrix);
                Matrix = MultiplyMatrix(Matrix, Matrix);
            }

            return result[0, 1];
        }
    }
}
