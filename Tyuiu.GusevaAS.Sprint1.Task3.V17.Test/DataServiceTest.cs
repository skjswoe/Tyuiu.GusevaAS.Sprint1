using Tyuiu.GusevaAS.Sprint1.Task3.V17.Lib;

namespace Tyuiu.GusevaAS.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.ZeroCheck(12.305));
            Assert.IsFalse(ds.ZeroCheck(5.123));
        }
    }
}
