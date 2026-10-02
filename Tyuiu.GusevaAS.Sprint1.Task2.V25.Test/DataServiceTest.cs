using Tyuiu.GusevaAS.Sprint1.Task2.V25.Lib;

namespace Tyuiu.GusevaAS.Sprint1.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int radians = 1;
            var res = ds.ConvertRadsToDegrees(radians);
            Assert.AreEqual(57.296, res);
        }
    }
}
