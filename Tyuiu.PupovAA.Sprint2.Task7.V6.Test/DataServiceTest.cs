using Tyuiu.PupovAA.Sprint2.Task7.V6.Lib;
namespace Tyuiu.PupovAA.Sprint2.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -1.5;
            double y = 1.2;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool ret = true;
            Assert.AreEqual(ret, res);
        }
    }
}
