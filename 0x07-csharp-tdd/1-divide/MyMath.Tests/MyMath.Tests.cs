using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Starting set of tests for division</summary>
    public class Tests
    {
        [Test]
        ///<summary>odd division</summary>
        public void testOdd()
        {
            int[,] newMatrix = Matrix.Divide(new int[,] { { 5, 7 }, { 9, 7 }, { 11, 13 }, { 17, 21 } }, 2);
            Assert.AreEqual(new int[,] { { 2, 3 }, { 4, 3 }, { 5, 6 }, { 8, 10 } }, newMatrix);
        }
        [Test]
        ///<summary>even division</summary>
        public void testEven()
        {
            int[,] newMatrix = Matrix.Divide(new int[,] { { 4, 4 }, { 8, 8 }, { 12, 12 }, { 16, 16 } }, 2);
            Assert.AreEqual(new int[,] { { 2, 2 }, { 4, 4 }, { 6, 6 }, { 8, 8 } }, newMatrix);
        }
        [Test]
        ///<summary>null matrix division</summary>
        public void testNull()
        {
            int[,] newMatrix = Matrix.Divide(null, 2);
            Assert.AreEqual(null, newMatrix);
        }
        [Test]
        ///<summary>num 0 division</summary>
        public void testNum0()
        {
            int[,] newMatrix = Matrix.Divide(new int[,] { { 4, 4 }, { 8, 8 }, { 12, 12 }, { 16, 16 } }, 0);
            Assert.AreEqual(null, newMatrix);
        }
        [Test]
        ///<summary>negative matrix division</summary>
        public void Test1()
        {
            int[,] newMatrix = Matrix.Divide(new int[,] { { -4, -4 }, { -8, 8 }, { 12, -12 }, { -16, 16 } }, 2);
            Assert.AreEqual(new int[,] { { -2, -2 }, { -4, 4 }, { 6, -6 }, { -8, 8 } }, newMatrix);
        }
        [Test]
        ///<summary>matrix with 0 division</summary>
        public void Test0()
        {
            int[,] newMatrix = Matrix.Divide(new int[,] { { 4, 0 }, { 8, 8 }, { 0, 12 }, { 0, 0 } }, 2);
            Assert.AreEqual(new int[,] { { 2, 0 }, { 4, 4 }, { 0, 6 }, { 0, 0 } }, newMatrix);
        }
    }
}