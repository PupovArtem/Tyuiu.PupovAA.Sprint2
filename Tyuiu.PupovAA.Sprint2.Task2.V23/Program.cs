using Tyuiu.PupovAA.Sprint2.Task2.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                                *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич | ИБКСб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и вычисляет *");
        Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.Write("Введите x = ");
        int x = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите y = ");
        int y = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************/");
        bool res = ds.CheckDotInShadedArea(x, y);
        if (res == true)
        {
            Console.WriteLine("Данная точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Данная точка не находится в заштрихованной области");
        }
        Console.ReadKey();
    }
}