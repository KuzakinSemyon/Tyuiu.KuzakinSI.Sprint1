using Tyuiu.KuzakinSI.Sprint1.Task6.V1.Lib;

Console.Title = "Спринт #1 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";
DataService ds = new DataService();

Console.WriteLine("*******************************************************************");
Console.WriteLine("* Спринт #1                                                       *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                *");
Console.WriteLine("* Задание #6                                                      *");
Console.WriteLine("* Вариант #1                                                     *");
Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                    *");
Console.WriteLine("*******************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                        *");
Console.WriteLine("* Напишите программу, которая выводит код введенного пользователем символа.*");
Console.WriteLine("*                                                                 *");
Console.WriteLine("*******************************************************************");
Console.WriteLine("* ИНТЕРАКТИВНЫЙ РЕЖИМ:                                                *");
Console.WriteLine("Введите символ и нажмите <Enter>.");
Console.WriteLine("Для завершения введите точку.");

while (true)
{
    Console.Write("-> ");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Пустой ввод. Попробуйте снова.");
        continue;
    }

    if (input == ".")
    {
        Console.WriteLine("Программа завершена.");
        break;
    }

    if (input.Length != 1)
    {
        Console.WriteLine("Введите ровно один символ.");
        continue;
    }
    Console.WriteLine($"Символ: {input[0]} Код: {ds.SymbolCode(input[0].ToString())}");
}