// See https://aka.ms/new-console-template for more information


using Tyuiu.KuzakinSI.Sprint1.Task2.V10.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

Console.WriteLine("*******************************************************************");
Console.WriteLine("* Спринт #1                                                       *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                *");
Console.WriteLine("* Задание #2                                                      *");
Console.WriteLine("* Вариант #10                                                     *");
Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                    *");
Console.WriteLine("*******************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                        *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.*");
Console.WriteLine("* Известно расстояние в метрах. Вычислить расстояние в дюймах. Ответ округлите до 3 знаков после запятой.*");
Console.WriteLine("*                                                                 *");
Console.WriteLine("*******************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                *");

int meters;

Console.WriteLine("Введите метры:");
meters = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("*******************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
Console.WriteLine("*******************************************************************");
Console.WriteLine($"inchs = {ds.ConvertMetreToInchs(meters)}");
Console.ReadLine();

