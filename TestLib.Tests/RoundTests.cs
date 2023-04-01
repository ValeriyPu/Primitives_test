using TestLib.Src.Figures;

namespace TestLib.Tests
{
    [TestClass]
    public class RoundTests
    {
        [TestMethod]
        public void TestArea()
        {
            var round = new Round();

            round.R = 1;

            var res = (float)(2 * Math.PI);

            Assert.AreEqual(res, round.GetArea());
        }
    }
}