using Tyuiu.PupovAA.Sprint2.Task6.V12.Lib;
namespace Tyuiu.PupovAA.Sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2007;
            int m = 10;
            int n = 20;
            var res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual("19.10.2007", res);
        }
    }
}
