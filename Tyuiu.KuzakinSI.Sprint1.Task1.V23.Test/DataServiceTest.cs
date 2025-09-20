using Tyuiu.KuzakinSI.Sprint1.Task1.V23.Lib;

namespace Tyuiu.KuzakinSI.Sprint1.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double a = 2.0;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(0.7853981633974483, res);
        }
    }
}
