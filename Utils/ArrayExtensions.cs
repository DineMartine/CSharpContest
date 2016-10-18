using System;
using System.Linq;

namespace Utils
{
    public static class ArrayExtensions
    {
        public static T[][] Transpose<T>(this T[][] matrix)
        {
            var rowCount = matrix.Length;
            if (rowCount == 0) return matrix;
            var columnCount = matrix.First().Length;

            if (matrix.Any(row => row.Length != columnCount))
                throw new ArgumentException("row sizes are incompatible");

            var transposedMatrix = Enumerable.Range(0, columnCount).Select(r => new T[rowCount]).ToArray();
            var i = 0;
            foreach(var row in matrix)
            {
                var j = 0;
                foreach(var value in row)
                {
                    transposedMatrix[j][i] = value;
                    j++;
                }
                i++;
            }
            return transposedMatrix;
        }
    }
}
