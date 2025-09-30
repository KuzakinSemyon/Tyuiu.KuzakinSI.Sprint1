// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;
using Tyuiu.KuzakinSI.Sprint1.Task4.V18.Lib;

Console.Title = "Спринт #1 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";
DataService ds = new DataService();

Console.WriteLine("*******************************************************************");
Console.WriteLine("* Спринт #1                                                       *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                *");
Console.WriteLine("* Задание #3                                                      *");
Console.WriteLine("* Вариант #18                                                     *");
Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                    *");
Console.WriteLine("*******************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                        *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле*");
Console.WriteLine("* и печатает его на экране. Ответ округлите до 3 знаков после запятой.*");
Console.WriteLine("*                                                                 *");
Console.WriteLine("*******************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                *");

double x;
Console.Write("x = ");
x = Convert.ToDouble(Console.ReadLine());

double y;
Console.Write("y = ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("*******************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
Console.WriteLine("*******************************************************************");

Console.WriteLine(ds.Calculate(x, y));

Console.ReadLine();
