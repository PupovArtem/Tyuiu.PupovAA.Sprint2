using Tyuiu.PupovAA.Sprint2.Task2.V23.Lib;
namespace Tyuiu.PupovAA.Sprint2.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            var res = ds.CheckDotInShadedArea(x, y);
            bool ret = true;
            Assert.AreEqual(ret, res);


                    
        }
    }
}
