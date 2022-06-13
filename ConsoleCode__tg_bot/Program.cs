using ConsoleCode__tg_bot;

#nullable disable
while (true)
{
    try
    {
        Console.WriteLine("1. Расчет ккал. \n2. Источники.");
        Console.Write("Введите номер операции: ");
        int op = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (op == 1 || op == 2)
        {
            switch (op)
            {
                case 1:
                    Gender gender = new();
                    gender.SwitchGnder();
                    break;

                case 2:
                    Food food = new();
                    food.FoodSources();
                    break;
            }
            break;
        }
        
        else
            Console.WriteLine("Введите: '1' или '2'.");
    }
    
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message} \n");
    }
}