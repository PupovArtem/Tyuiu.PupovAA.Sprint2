using Tyuiu.PupovAA.Sprint2.Task1.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                                *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич | ИБКСб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении)*");
        Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет*");
        Console.WriteLine("* логическую последовательность(массив): (True, True, True, False, True, True), при a = 657, b = 654, c = 657, d = 657*");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: a = 657, b = 654, c = 657, d = 657                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int a = 657;
        int b = 654;
        int c = 657;
        int d = 657;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadLine();
    }
}