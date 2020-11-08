using System;
using System.Numerics;

namespace hw5es
{
    public class MyMatrix
    {
        private Random _random = new Random();

        private int _height;
        private int _width;

        private int Height
        {
            get => _height;
            set
            {
                if (value < 1) throw new Exception();
                _height = value;
            }
        }

        private int Width
        {
            get => _width;
            set
            {
                if (value < 1) throw new Exception();
                _width = value;
            }
        }

        public int[,] Matrix;

        public MyMatrix(int width, int height)
        {
            Height = height;
            Width = width;
            BuildMatrix();
        }

        private void BuildMatrix()
        {
            Matrix = new int[Height, Width];

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = _random.Next(0, 100);
                }
            }
        }

        public void OutputMatrix()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i, j]}\t");
                }

                Console.WriteLine();
            }
        }

        private void OutputMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }

                Console.WriteLine();
            }
        }

        public void OutputInnerMatrices()
        {
            int min = Height > Width ? Width : Height;
            for (int i = min; i > 1; i--)
            {
                OutputInnerMatrices(i);
            }
        }

        public void OutputInnerMatrices(int size)
        {
            if (size > Height || size > Width)
            {
                throw new Exception("Matrix is bigger than its parent matrix.");
            }

            for (int i = 0; i < Height - size + 1; i++)
            {
                for (int j = 0; j < Width - size + 1; j++)
                {
                    OutputInnerMatrix(size, i, j);
                }
            }
        }

        public void OutputInnerMatrix(int size, int offsetRow, int offsetCol)
        {
            if (offsetRow + size > Height || offsetCol + size > Width)
            {
                throw new Exception("Matrix is outside its parent matrix.");
            }

            for (int i = offsetRow; i < offsetRow + size; i++)
            {
                for (int j = offsetCol; j < offsetCol + size; j++)
                {
                    Console.Write($"{Matrix[i, j]}\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 30));
        }
    }
}