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
                    Calculator cal = new();
                    cal.Calorie_Сalculation();
                    break;

                case 2:
                    FoodSources();
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


void FoodSources()
{
    Console.WriteLine("Белок: татататтатата. \nЖиры: хкхкхкхкхкх. \nУгли: тотототото.");
}

class Calculator
{
    internal void Calorie_Сalculation()
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
                    switch (gender)
                    {
                        case 1:
                            BMR_man();
                            break;
                        case 2:
                            BMR_woman();
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

    private void BMR_man()
    {
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
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Используйте запятую после целой части!\n");
            }
        }
    }

    private void BMR_woman()
    {
        Console.Write("Введите вес (кг): ");
        double w = double.Parse(Console.ReadLine());
        Console.Write("Введите рост (см): ");
        double h = double.Parse(Console.ReadLine());
        Console.Write("Введите возраст (лет): ");
        double age = int.Parse(Console.ReadLine());

        double BMRw = (9.99 * w) + (6.25 * h) - (4.92 * age) - 161;

        Console.WriteLine($"\nБазовый метаболизм: {BMRw} ккал");
        Console.WriteLine();

        CoeffActvityInfo();

        while (true)
        {
            try
            {
                Console.Write("Коэффициент: ");
                double koef = double.Parse(Console.ReadLine());
                double totalResult = BMRw * koef;
                Console.WriteLine($"\nЗатраченные калории за день: {totalResult} ккал");
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

/*
void Calorie_Сalculation()
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
                switch (gender)
                {
                    case 1:
                        BMR_man();
                        break;
                    case 2:
                        BMR_woman();
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

void BMR_man()
{
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
            Console.Write("Коэффициент (десятич. часть после запятой): ");
            double koef = double.Parse(Console.ReadLine());
            double totalResult = BMRm * koef;
            Console.WriteLine($"\nЗатраченные калории за день: {totalResult} ккал");
            break;
        }
        catch (Exception)
        {
            Console.WriteLine("Используйте запятую после целой части!\n");
        }
    }
}

void BMR_woman()
{
    Console.Write("Введите вес (кг): ");
    double w = double.Parse(Console.ReadLine());
    Console.Write("Введите рост (см): ");
    double h = double.Parse(Console.ReadLine());
    Console.Write("Введите возраст (лет): ");
    double age = int.Parse(Console.ReadLine());

    double BMRw = (9.99 * w) + (6.25 * h) - (4.92 * age) - 161;

    Console.WriteLine($"\nБазовый метаболизм: {BMRw} ккал");
    Console.WriteLine();

    CoeffActvityInfo();

    while (true)
    {
        try
        {
            Console.Write("Коэффициент (десятичную часть после запятой): ");
            double koef = double.Parse(Console.ReadLine());
            double totalResult = BMRw * koef;
            Console.WriteLine($"\nЗатраченные калории за день: {totalResult} ккал");
            break;
        }
        catch (Exception)
        {
            Console.WriteLine("Используйте запятую после целой части!\n");
        }
    }
}

// не рабит так, не видно переменные в BMR
void PersonData()
{
    Console.Write("Введите вес (кг): ");
    double w = double.Parse(Console.ReadLine());
    Console.Write("Введите рост (см): ");
    double h = double.Parse(Console.ReadLine());
    Console.Write("Введите возраст (лет): ");
    double age = int.Parse(Console.ReadLine());
}

void CoeffActvityInfo()
{
    Console.WriteLine("Выберите коэффициент активности\n" +
        "1,2 = минимум или отсутствие нагрузки, сидячий образ жизни.\n" +
        "1,3-1,4 = 1-3 раза в неделю тренировок.\n" +
        "1,5-1,6 = 3-5 раз в неделю тренировок.\n" +
        "1,7-1,8 = активный образ жизни и интенсивные тренировки 6-7 раз в неделю.\n" +
        "1,9-2,0 = много физической работы плюс интенсивные ежедневные тренировки.\n");
    Console.WriteLine();
}
*/