using System;
using NUnit.Framework;
using Telerik.JustMock;

namespace RotatingMatrix.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [TestCase(0)]
        public void Matrix_WhenCreatingMatrixWithLessThan1RowOrCol_ShouldThrowArgumentOutOfRangeException(int dimention)
        {
            var matrix = new Matrix(dimention);

            Assert.Throws<ArgumentOutOfRangeException>(() => matrix.PrintMatrix());
        }

    }
}
