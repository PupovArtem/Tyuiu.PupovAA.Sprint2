using Tyuiu.PupovAA.Sprint2.Task0.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич | ИБКСб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("*  последовательность операций не должна нарушаться) и арифметических     *");
        Console.WriteLine("* выражений,  которая вернет логическую последовательность(массив):       *");
        Console.WriteLine("* (False, False, False, False, False, False), при x = 111, y = 735        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:      x = 111, y = 735                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int x = 111;
        int y = 735;
        bool[] b = new bool[6];
        b = ds.GetCompareOperations(x, y);
        for (int i = 0; i < b.Length; i++)
        {
            Console.WriteLine(b[i]);

        }
        Console.ReadLine(); 
    }
}