using NUnit.Framework;
using System;
using System.Linq;
using Utils;

namespace UtilsTests
{
    [TestFixture]
    public class ArrayExtensionsTests
    {
        [Test]
        public void TransposeEmptyMatrix()
        {
            var emptyMatrix = new int[0][];
            Assert.AreEqual(emptyMatrix, emptyMatrix.Transpose());
        }

        [Test]
        public void TransposeMatrix3x2()
        {
            var matrix3x2 = Enumerable.Range(0, 3)
                .Select(i => Enumerable.Range(0, 2).Select(j => i * j).ToArray())
                .ToArray();
            var transposedMatrix = matrix3x2.Transpose();
            Assert.IsTrue(
                Enumerable.Range(0, 2)
                    .All(i => Enumerable.Range(0, 3).All(j => Equals(transposedMatrix[i][j], i * j))));
        }

        [Test]
        public void TransposeIncorrectMatrix()
        {
            var incorrectMatrix = Enumerable.Range(0, 3)
                .Select(i => Enumerable.Range(0, i).Select(j => i * j).ToArray())
                .ToArray();
            Assert.Throws<ArgumentException>(() => incorrectMatrix.Transpose());
        }
    }
}
