using Tyuiu.KuzakinSI.Sprint1.Task2.V10.Lib;

namespace Tyuiu.KuzakinSI.Sprint1.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int meters = 10;
            var res = ds.ConvertMetreToInchs(meters);
            Assert.AreEqual(393.701, res);
        }
    }
}
