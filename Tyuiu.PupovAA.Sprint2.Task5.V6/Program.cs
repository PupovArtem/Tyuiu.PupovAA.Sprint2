using System.ComponentModel.DataAnnotations;
using Tyuiu.PupovAA.Sprint2.Task5.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: оператор  switch                                                  *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #6                                                             *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич | ИБКСб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует оператор switch                 *");
        Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.Write("Введите масть карты от 1 до 4: ");
        int x = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите достоиноство карты от 6 до 14: ");
        int y = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("****************************************************************************");
        var card = ds.FindCardNameAndValue(x, y);
        Console.WriteLine("Вы выбрали карту - " + card);
        Console.ReadKey();
    }
}