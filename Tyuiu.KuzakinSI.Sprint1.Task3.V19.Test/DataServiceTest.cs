using Tyuiu.KuzakinSI.Sprint1.Task3.V19.Lib;

namespace Tyuiu.KuzakinSI.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
            public void TestCanBishopMove()
            {
                var ds = new DataService();
                var tests = new (double, double, double, double, bool)[]
                {
                        (1, 1, 3, 3, true),
                        (4, 4, 6, 6, true),
                        (5, 5, 5, 6, false),
                        (2, 3, 5, 7, false),
                        (8, 8, 1, 1, true),
                        (1, 8, 8, 1, true),
                };

                foreach (var (x1, y1, x2, y2, expected) in tests)
                {
                    bool result = ds.ElephCanMove(x1, y1, x2, y2);
                //Console.WriteLine($"CanBishopMove({x1}, {y1}, {x2}, {y2}) = {result}, ожидается = {expected}, {(result == expected ? "OK" : "FAIL")}");
                Assert.AreEqual(expected, result);
                }
            }   
    }
}
