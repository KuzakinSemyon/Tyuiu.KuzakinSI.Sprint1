using Tyuiu.KuzakinSI.Sprint1.Task5.V1.Lib;

namespace Tyuiu.KuzakinSI.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 0;
            double y1 = 0;
            double x2 = 4;
            double y2 = 3;
            Assert.AreEqual(5, ds.DistanceBetweenDots(x1, y1, x2, y2));
        }
    }
}
