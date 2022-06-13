using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace ConsoleCode__tg_bot
{
    internal class BMR : Gender
    {
        internal void Man()
        {
            // как-то избавится от этого дублирования

            Console.Write("Введите вес (кг): ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Введите рост (см): ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Введите возраст (лет): ");
            double age = int.Parse(Console.ReadLine());

            double BMRm = (9.99 * w) + (6.25 * h) - (4.92 * age) + 5;

            Console.WriteLine($"\nБазовый метаболизм: {BMRm} ккал");
            Console.WriteLine();

            CoeffActvityInfo();

            while (true)
            {
                try
                {
                    Console.Write("Коэффициент: ");
                    double koef = double.Parse(Console.ReadLine());
                    double totalResult = BMRm * koef;
                    Console.WriteLine($"\nЗатраченные калории за день: {totalResult} ккал");
                    Console.ReadKey();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Используйте запятую после целой части!\n");
                }
            }
        }

        internal void Woman()
        {
            Console.Write("Введите вес (кг): ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Введите рост (см): ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Введите возраст (лет): ");
            double age = int.Parse(Console.ReadLine());

            double BMRw = (9.99 * w) + (6.25 * h) - (4.92 * age) - 161;     // эта

            Console.WriteLine($"\nБазовый метаболизм: {BMRw} ккал");
            Console.WriteLine();

            CoeffActvityInfo();

            while (true)
            {
                try
                {
                    Console.Write("Коэффициент: ");
                    double koef = double.Parse(Console.ReadLine());
                    double totalResult = BMRw * koef;                       // эта тк BMR разный у м/ж
                    Console.WriteLine($"\nЗатраченные калории за день: {totalResult} ккал");
                    Console.ReadKey();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Используйте запятую после целой части!\n");
                }
            }
        }

        private void CoeffActvityInfo()
        {
            Console.WriteLine("Выберите коэффициент активности\n" +
                "1,2 = минимум или отсутствие нагрузки, сидячий образ жизни.\n" +
                "1,3-1,4 = 1-3 раза в неделю тренировок.\n" +
                "1,5-1,6 = 3-5 раз в неделю тренировок.\n" +
                "1,7-1,8 = активный образ жизни и интенсивные тренировки 6-7 раз в неделю.\n" +
                "1,9-2,0 = много физической работы плюс интенсивные ежедневные тренировки.\n");
            Console.WriteLine();
        }
    }
}
