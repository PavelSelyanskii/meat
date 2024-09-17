
        Console.WriteLine("Введите количество мяса в граммах:");
        int meat = Convert.ToInt32(Console.ReadLine());

        if (meat < 500)
        {
            Console.WriteLine("К сожалению, у вас не достаточно мяса для приготовления блюда.");
            return ;
        }
        else if (meat >= 500 && meat < 1000)
        {
            Console.WriteLine("Оптимальный рецепт для приготовления блюда: жареное мясо с овощами.");
        }
        else
        {
            Console.WriteLine("Оптимальный рецепт для приготовления блюда: жареное мясо с картошкой и грибами.");
        }

        Console.WriteLine("Желаете уменьшить варианты блюд? (Да/Нет)");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "да")
        {
            Console.WriteLine("Сколько времени у вас есть на приготовление? (30 минут / 1 час / 2 часа)");
            string time = Console.ReadLine();

            if (time == "30 минут")
            {
                Console.WriteLine("Оптимальный рецепт для приготовления блюда: жареное мясо с овощами.");
            }
            else if (time == "1 час")
            {
                Console.WriteLine("Оптимальный рецепт для приготовления блюда: жареное мясо с картошкой.");
            }
            else if (time == "2 часа")
            {
                Console.WriteLine("Оптимальный рецепт для приготовления блюда: жареное мясо с овощами и грибами.");
            }
            else
            {
                Console.WriteLine("Данный вариант времени не поддерживается.");
            }
        }

