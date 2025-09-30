using Tyuiu.KuzakinSI.Sprint1.Task6.V1.Lib;

namespace Tyuiu.KuzakinSI.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Символ: 1 Код: 49", ds.SymbolCode("1"));
        }
    }
}
