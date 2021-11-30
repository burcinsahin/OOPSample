using System;
using System.Text;

namespace OOPSample.Sample3
{
    public class Matrix2D
    {
        private readonly int _rowCount;
        private readonly int _columnCount;

        private readonly double[,] _matrix;

        public double this[int row, int column]
        {
            get { return _matrix[row, column]; }
            set { _matrix[row, column] = value; }
        }

        public Matrix2D(double[,] matrix)
        {
            _matrix = matrix;
            _rowCount = matrix.GetLength(0);
            _columnCount = matrix.GetLength(1);
        }

        public static Matrix2D operator +(Matrix2D matrix1, Matrix2D matrix2)
        {
            if (matrix1._rowCount != matrix2._rowCount || matrix1._columnCount != matrix2._columnCount)
            {
                throw new NotSupportedException();
            }

            var resultMatrix = new Matrix2D(new double[matrix1._rowCount, matrix1._columnCount]);

            for (var i = 0; i < matrix1._rowCount; i++)
            {
                for (var j = 0; j < matrix1._columnCount; j++)
                {
                    resultMatrix._matrix[i, j] = matrix1._matrix[i, j] + matrix2._matrix[i, j];
                }
            }

            return resultMatrix;
        }

        public static Matrix2D operator -(Matrix2D matrix1, Matrix2D matrix2)
        {
            if (matrix1._rowCount != matrix2._rowCount || matrix1._columnCount != matrix2._columnCount)
            {
                throw new NotSupportedException();
            }

            var resultMatrix = new Matrix2D(new double[matrix1._rowCount, matrix1._columnCount]);

            for (var i = 0; i < matrix1._rowCount; i++)
            {
                for (var j = 0; j < matrix1._columnCount; j++)
                {
                    resultMatrix._matrix[i, j] = matrix1._matrix[i, j] - matrix2._matrix[i, j];
                }
            }

            return resultMatrix;
        }

        public static Matrix2D operator *(double constant, Matrix2D matrix1)
        {
            var resultMatrix = new Matrix2D(new double[matrix1._rowCount, matrix1._columnCount]);

            for (var i = 0; i < matrix1._rowCount; i++)
            {
                for (var j = 0; j < matrix1._columnCount; j++)
                {
                    resultMatrix._matrix[i, j] = constant * matrix1._matrix[i, j];
                }
            }

            return resultMatrix;
        }

        public static Matrix2D operator *(Matrix2D matrix1, Matrix2D matrix2)
        {
            if (matrix1._rowCount != matrix2._columnCount || matrix1._columnCount != matrix2._rowCount)
            {
                throw new NotSupportedException();
            }

            var resultMatrix = new Matrix2D(new double[matrix1._rowCount, matrix2._columnCount]);

            //TODO: Implement multiplication here
            throw new NotImplementedException();

            return resultMatrix;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < _rowCount; i++)
            {
                for (var j = 0; j < _columnCount; j++)
                {
                    stringBuilder.Append(_matrix[i, j].ToString("F1").PadLeft(5));
                    stringBuilder.Append(" ");
                }
                stringBuilder.AppendLine();
            }
            return stringBuilder.ToString().TrimEnd('\r', '\n');
        }
    }
}