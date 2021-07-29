using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Tests</summary>
    public class MatrixTests
    {
        [Test]
        public void evenNumbers()
        {

            int[,] result = Matrix.Divide(new int[,] { { 1, 2 }, { 4, 4 }, { 6, 6 }, { 8, 8 } }, 2);

            Assert.AreEqual(new int[,] { { 0, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 } }, result);
        }

        [Test]
        public void oddNUmbers()
        {
            int[,] matrix = new int[,] { { 3, 24 }, { 5, 10 }, { 15, 6 }, { 9, 8 } };
            int num = 2;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(new int[,] { { 1, 12 }, { 2, 5 }, { 7, 3 }, { 4, 4 } }, result);
        }

        [Test]
        public void numEquals0()
        {
            int[,] matrix = new int[,] { { 3, 24 }, { 5, 10 }, { 15, 6 }, { 9, 8 } };
            int num = 0;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(null, result);
        }

        [Test]
        public void nullMatrix()
        {
            int[,] matrix = null;
            int num = 2;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(null, result);
        }
    }
}