using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BotanogovDS.Sprint3.Task2.V22.Lib;

namespace Tyuiu.BotanogovDS.Sprint3.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #3 | Выполнил: Ботаногов Д. С. | ИСТНб-23-1";
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант 22                                                              *");
            Console.WriteLine("* Выполнил: Ботаногов Дмитрий Сергеевич | АСОиУб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
            Console.WriteLine("* произведение ряда по формуле, при х=5                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int value = 5;
            int startValue = 1;
            int stopValue = 7;
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Переменная x = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
            
            Console.ReadKey();
        }
    }
}
