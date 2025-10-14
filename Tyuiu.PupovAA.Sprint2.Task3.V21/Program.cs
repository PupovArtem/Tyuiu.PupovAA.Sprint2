using Tyuiu.PupovAA.Sprint2.Task3.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Вложенные операторы if - else                                      *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич | ИБКСб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с     *");
        Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит значение *");
        Console.WriteLine("* переменной X с клавиатуры. Округлить полученное значение до трех знаков *");
        Console.WriteLine("* после запятой;                                                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.Write("Введите число x= ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("****************************************************************************");
        var y = ds.Calculate(x);
        Console.WriteLine("Значение функции Y = " + y);
        Console.ReadLine();
    }
}