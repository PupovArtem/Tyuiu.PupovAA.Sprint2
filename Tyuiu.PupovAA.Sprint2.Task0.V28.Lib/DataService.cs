using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PupovAA.Sprint2.Task0.V28.Lib
{
    public class DataService : ISprint2Task0V28
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            
            res[0] = x == y;
            res[1] = x + 624 != y;
            res[2] = x * 100 < y;
            res[3] = x > y;
            res[4] = x+1000 <= y;
            res[5] = x >= y;

            return res;


        }
    }
}
