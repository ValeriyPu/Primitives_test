using TestLib.Src.Figures;

namespace TestLib.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestRightTriangle()
        {
            var triangle = new Triangle();
            triangle.A = 3;
            triangle.B = 4;
            triangle.C = 5;

            Assert.AreEqual(true, triangle.IsRightTriangle());
        }

        [TestMethod]
        public void TestNonRightTriangle()
        {
            var triangle = new Triangle();
            triangle.A = 1;
            triangle.B = 2;
            triangle.C = 3;

            Assert.AreEqual(false, triangle.IsRightTriangle());
        }

        [TestMethod]
        public void TestArea()
        {
            var triangle = new Triangle();
            triangle.A = 3;
            triangle.B = 4;
            triangle.C = 5;

            Assert.AreEqual(6, triangle.GetArea());
        }
    }
}