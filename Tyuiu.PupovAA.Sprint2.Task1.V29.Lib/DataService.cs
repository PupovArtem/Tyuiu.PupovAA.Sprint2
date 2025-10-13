using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PupovAA.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            //Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) 
            //и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет 
            //логическую последовательность(массив): (True, True, True, False, True, True), при a = 657, b = 654, c = 657, d = 657
            bool[] res = new bool[6];
            res[0] = c == d|a-3!=b;
            res[1] = c <= d & b < c;
            res[2] = b>a || a>=d;
            res[3] = a==b && c!=d;
            res[4] = !res[3];
            res[5] = (a > b) ^ (b > a);

            return res;
        }
    }
}
