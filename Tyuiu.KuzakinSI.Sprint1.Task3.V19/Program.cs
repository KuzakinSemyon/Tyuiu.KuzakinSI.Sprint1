using System;
using Tyuiu.KuzakinSI.Sprint1.Task3.V19.Lib;
class Program
{
    static void Main()
    {
        Console.Title = "Спринт #1 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

        Console.WriteLine("*******************************************************************");
        Console.WriteLine("* Спринт #1                                                       *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                *");
        Console.WriteLine("* Задание #3                                                      *");
        Console.WriteLine("* Вариант #19                                                     *");
        Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                    *");
        Console.WriteLine("*******************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                        *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.*");
        Console.WriteLine("*                                                                 *");
        Console.WriteLine("*******************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                *");
        
        int x1 = ReadCoordinate("Введите x1 (1-8): ");
        int x2 = ReadCoordinate("Введите x2 (1-8): ");
        int y1 = ReadCoordinate("Введите y1 (1-8): ");
        int y2 = ReadCoordinate("Введите y2 (1-8): ");

        Console.WriteLine("*******************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
        Console.WriteLine("*******************************************************************");
        DataService ds = new DataService();
        Console.WriteLine(ds.ElephCanMove(x1, y1, x2, y2));
        Console.ReadLine();
    }

    static int ReadCoordinate(string prompt)
    {
        int coord;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out coord) && coord >= 1 && coord <= 8)
            {
                return coord;
            }
            Console.WriteLine("Ошибка: введите число от 1 до 8.");
        }
    }
}