// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;
using Tyuiu.KuzakinSI.Sprint1.Task5.V1.Lib;

Console.Title = "Спринт #1 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";
DataService ds = new DataService();

Console.WriteLine("*******************************************************************");
Console.WriteLine("* Спринт #1                                                       *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                *");
Console.WriteLine("* Задание #5                                                      *");
Console.WriteLine("* Вариант #1                                                     *");
Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                    *");
Console.WriteLine("*******************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                        *");
Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y). Ответ привести к целому с помощью класса Convert.*");
Console.WriteLine("*                                                                 *");
Console.WriteLine("*******************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                *");

double x1;
Console.Write("x1 = ");
x1 = Convert.ToDouble(Console.ReadLine());

double y1;
Console.Write("y1 = ");
y1 = Convert.ToDouble(Console.ReadLine());

double x2;
Console.Write("x2 = ");
x2 = Convert.ToDouble(Console.ReadLine());

double y2;
Console.Write("y2 = ");
y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("*******************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
Console.WriteLine("*******************************************************************");

Console.WriteLine(ds.DistanceBetweenDots(x1, y1, x2, y2));

Console.ReadLine();
