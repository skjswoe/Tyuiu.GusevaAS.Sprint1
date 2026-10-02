using Tyuiu.GusevaAS.Sprint1.Task5.V3.Lib;

namespace Tyuiu.GusevaAS.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 130985;
            var res = ds.Calculate(k);
            Assert.AreEqual(5, res);
        }
    }
}
