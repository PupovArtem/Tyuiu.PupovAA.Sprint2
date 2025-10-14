using Tyuiu.PupovAA.Sprint2.Task3.V21.Lib;
namespace Tyuiu.PupovAA.Sprint2.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            var y = ds.Calculate(x);
            Assert.AreEqual(242, y);
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            var y = ds.Calculate(x);
            Assert.AreEqual(0.833, y);
        }
        
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = 1;
            var y = ds.Calculate(x);
            Assert.AreEqual(2, y);
        }
        
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -26;
            var y = ds.Calculate(x);
            Assert.AreEqual(-285.962, y);
            
        }
    }
}
