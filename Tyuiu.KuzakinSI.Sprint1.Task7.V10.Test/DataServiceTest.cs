using Tyuiu.KuzakinSI.Sprint1.Task7.V10.Lib;

namespace Tyuiu.KuzakinSI.Sprint1.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-13.142, ds.Calculate(1));
        }
    }
}
