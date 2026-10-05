using Tyuiu.FedorovskikhEO.Sprint2.Task5.V8.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint2.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("14.5", ds.FindDateOfPreviousDay(5, 15));
            Assert.AreEqual("30.4", ds.FindDateOfPreviousDay(5, 1));
            Assert.AreEqual("28.2", ds.FindDateOfPreviousDay(3, 1));
        }
    }
}
