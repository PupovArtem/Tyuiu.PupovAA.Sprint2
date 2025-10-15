using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PupovAA.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12

    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n > 1)
            {
                return $"{n - 1}.{m}.{g}";
            }

            
            int prevMonth = m - 1;
            int prevYear = g;

            if (prevMonth == 0)
            {
               
                prevMonth = 12;
                prevYear = g - 1;
            }

            
            int daysInPrevMonth = prevMonth switch
            {
                1 => 31,   
                2 => 29,   
                3 => 31,   
                4 => 30,   
                5 => 31,   
                6 => 30,   
                7 => 31,   
                8 => 31,   
                9 => 30,   
                10 => 31,  
                11 => 30,  
                12 => 31,  
                _ => throw new ArgumentException("Некорректный номер месяца")
            };

            return $"{daysInPrevMonth}. {prevMonth}. {prevYear}";
        }
    }
}
