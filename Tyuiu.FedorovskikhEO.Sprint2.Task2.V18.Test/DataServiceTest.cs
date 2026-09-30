using Tyuiu.FedorovskikhEO.Sprint2.Task2.V18.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint2.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1CheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 15;
            int y = 15;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
