using Tyuiu.GusevaAS.Sprint1.Task4.V23.Lib;

namespace Tyuiu.GusevaAS.Sprint1.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.236, res);
        }
    }
}
