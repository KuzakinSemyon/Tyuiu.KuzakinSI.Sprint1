using Tyuiu.KuzakinSI.Sprint1.Task4.V18.Lib;

namespace Tyuiu.KuzakinSI.Sprint1.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 7;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.002, res);
        }
    }
}
