// See https://aka.ms/new-console-template for more information

using Tyuiu.KuzakinSI.Sprint1.Task1.V23.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

Console.WriteLine("*******************************************************************");
Console.WriteLine("* Спринт #1                                                       *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                *");
Console.WriteLine("* Задание #1                                                      *");
Console.WriteLine("* Вариант #23                                                      *");
Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                    *");
Console.WriteLine("*******************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                        *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные    *");
Console.WriteLine("* вычисляет результат по формуле (x*Pi)/(2a) и печатает результат на экране.*");
Console.WriteLine("*                                                                 *");
Console.WriteLine("*******************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                *");

double x, a;

Console.WriteLine("Введите значение x:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение a:");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("*******************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
Console.WriteLine("*******************************************************************");
Console.WriteLine(ds.Calculate(x, a));
Console.ReadLine();