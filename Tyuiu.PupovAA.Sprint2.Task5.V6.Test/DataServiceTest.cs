using Tyuiu.PupovAA.Sprint2.Task5.V6.Lib;
namespace Tyuiu.PupovAA.Sprint2.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 11;
            var card = ds.FindCardNameAndValue(x, y);
            Assert.AreEqual(" валет пики",card);
        }
    }
}
