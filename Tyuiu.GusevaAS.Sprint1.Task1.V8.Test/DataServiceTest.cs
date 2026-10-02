using Tyuiu.GusevaAS.Sprint1.Task1.V8.Lib;

namespace Tyuiu.GusevaAS.Sprint1.Task1.V8.Test
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
            Assert.AreEqual(6.283185307179586, res);
        }
    }
}
