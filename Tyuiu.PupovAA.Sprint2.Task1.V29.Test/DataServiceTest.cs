using Tyuiu.PupovAA.Sprint2.Task1.V29.Lib;
namespace Tyuiu.PupovAA.Sprint2.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 657;
            int b = 654;
            int c = 657;
            int d = 657;
            bool[] res= new bool[6];
            res=ds.GetLogicOperations(a, b, c, d);
            bool[] ret= new bool[6] { true, true, true, false, true, true };
            CollectionAssert.AreEqual(res, ret);

        }
    }
}
