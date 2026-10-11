using Tyuiu.FedorovskikhEO.Sprint2.Task6.V2.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint2.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FindMonth()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Зима", ds.FindMonthSeason(1));

        }
    }
}
