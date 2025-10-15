using Tyuiu.PupovAA.Sprint2.Task7.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                             *");
        Console.WriteLine("* Вариант #6                                                            *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич | ИБКСб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные значения) *");
        Console.WriteLine("*и вычисляет, находится ли точка с координатами X,Y в заштрихованной области. *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("введите y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("****************************************************************************");
        var res = ds.CheckDotInShadedArea(x, y);
        if (res)
        {
            Console.WriteLine("Данная точка находится  в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Данная точка не находится в заштрихованной области");
        }
            

    }
}