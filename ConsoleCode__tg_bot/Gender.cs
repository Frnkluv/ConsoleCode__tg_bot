using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace ConsoleCode__tg_bot
{
    internal class Gender : Calculator
    {
        internal override void SwitchGnder()
        {
            while (true)
            {
                try
                {
                    Console.Write("1. Мужчина. \n2. Женщина.\nВведите номер пола: ");
                    int gender = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (gender == 1 || gender == 2)
                    {
                        BMR bmr = new();
                        switch (gender)
                        {
                            case 1:
                                bmr.Man();
                                break;
                            case 2:
                                bmr.Woman();
                                break;
                        }
                        break;
                    }
                    else
                        Console.WriteLine("Введите: '1' или '2'.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine();
                }
            }
        }
    }
}
