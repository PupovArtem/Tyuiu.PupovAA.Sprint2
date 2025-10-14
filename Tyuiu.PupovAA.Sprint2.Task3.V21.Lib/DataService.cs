using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PupovAA.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                 y = (Math.Pow(((x + 9) / (x - 1)), x)) * x;
            }
            else
            {
                if (x == 0)
                {
                    y = (Math.Pow(x, 2) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
                }
                else
                {
                    if (x>-25 && x<2)
                    {
                        y = Math.Pow((1 + (1 / (x * x))), x);
                    }
                    else
                    {
                        if (x < -25)
                        {
                           y= x + 10 * x - (1 / x);
                        }
                    }
                }
                
            }
            return Math.Round(y, 3);

        }
        
    }
}
