using Tyuiu.PupovAA.Sprint2.Task6.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        
        Console.Title = "Спринт #2 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                                  *");
        Console.WriteLine("* Задание #6                                                             *");
        Console.WriteLine("* Вариант #12                                                            *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич | ИБКСб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g (год), m (порядковый номер месяца) и n (число).      *");
        Console.WriteLine("*По заданным g, n и m определить дату предыдущего дня. Заданный год является високосным. *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("введите год: ");
        int g = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите месяц: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите день: ");
        int n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("****************************************************************************");

        var res = ds.FindDateOfPreviousDay(g, m, n);
        Console.WriteLine("Предыдущий день данной даты был - " + res);
        Console.ReadLine();
    }
}