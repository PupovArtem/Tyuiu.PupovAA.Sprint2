using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PupovAA.Sprint2.Task2.V23.Lib
{
    public class DataService : ISprint2Task2V23
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;
            if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 12))
            {
                if (((y >= 6 && y <= 10) && (x >= 3 && x <= 5)) || (x == 6 && (y >= 6 && y <= 8)) || ((y >= 3 && y <= 4) && (x >= 6 && x <= 8)) || (x == 13 && (y >= 3 && y <= 5) && (y >= 9 && y <= 10)) || (x == 11 && y == 12))
                {
                    res = false;
                }
                else
                {
                    res = true;
                }
            }
            else
            {
                res = false;
            }
            return res;

        }
    }
}
