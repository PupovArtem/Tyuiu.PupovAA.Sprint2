using Tyuiu.PupovAA.Sprint2.Task4.V9.Lib;
namespace Tyuiu.PupovAA.Sprint2.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 20;
            double z = ds.Calculate(x, y);
            Assert.AreEqual( Math.Pow(8,20), z);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double z = ds.Calculate(x, y);
            Assert.AreEqual(0.7, z);
        }
    }
}
