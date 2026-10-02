using Tyuiu.GusevaAS.Sprint1.Task7.V9.Lib;

namespace Tyuiu.GusevaAS.Sprint1.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.975, res);
        }
    }
}
