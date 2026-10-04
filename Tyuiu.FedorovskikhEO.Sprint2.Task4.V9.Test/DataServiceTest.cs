using Tyuiu.FedorovskikhEO.Sprint2.Task4.V9.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint2.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Conditional1()
        {
            DataService ds = new DataService();
            double x = -6;
            double y = -1;
            double wait = 0.142;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void Conditional2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 5;
            double wait = 0.4;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
