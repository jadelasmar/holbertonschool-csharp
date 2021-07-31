using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Start a new set of tests for Division</summary>
    public class Tests
    {
        [Test]
        ///<summary>even number division</summary>
        public void evenDiv()
        {
            int[,] matrix = new int[,] { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
            int num = 2;
            int[,] newMat = Matrix.Divide(matrix, num);
            int[,] ans = new int[,] { { 49, 0, -6 }, { 10, 486, 22 }, { -363, 30, -1 } };
            Assert.AreEqual(ans, newMat);
        }
        [Test]
        ///<summary>odd number division</summary>
        public void oddDiv()
        {
            int[,] matrix = new int[,] { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
            int num = -7;
            int[,] newMat = Matrix.Divide(matrix, num);
            int[,] ans = new int[,] { { -14, 0, 1 }, { -3, -138, -6 }, { 103, -8, 0 } };
            Assert.AreEqual(ans, newMat);
        }
        [Test]
        ///<summary>division by 0</summary>
        public void zeroDiv()
        {
            int[,] matrix = new int[,] { { 98, 0, -12 }, { 21, 972, 44 }, { -727, 60, -2 } };
            int num = 0;
            int[,] newMat = Matrix.Divide(matrix, num);
            Assert.AreEqual(null, newMat);
        }

        [Test]
        ///<summary>null matrix division</summary>
        public void nullDiv()
        {
            int[,] matrix = null;
            int num = 4;
            int[,] newMat = Matrix.Divide(matrix, num);
            Assert.AreEqual(null, newMat);
        }

        [Test]
        ///<summary>0 in matrix</summary>
        public void matZeroDiv()
        {
            int[,] matrix = new int[,] { { 0, 5 }, { 1, 0 }, { 9, 3 }, { 0, 1 } };
            int num = 2;
            int[,] newMat = Matrix.Divide(matrix, num);
            int[,] ans = new int[,] { { 0, 2 }, { 0, 0 }, { 4, 1 }, { 0, 0 } };
            Assert.AreEqual(ans, newMat);
        }
    }
}