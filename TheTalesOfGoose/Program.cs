using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Домашная работа №3 с 22.02.2018
namespace TheTalesOfGoose
{
    class Program
    {
        static void Main(string[] args)
        {
            // Название игры
            Console.Title = "История одного Работяги";

            /* Переменные персонажа*/
            int playerMaxHealth = 10; // Макс. здоровье персонажа
            int playerHealth = 10; // Здоровье персонажа
            int playerRegen = 0; // Регенерация здоровья персонажа
            int playerArmor = 1; // Защита персонажа
            int playerDamage = 1; // Урон персонажа
            int playerMoney = 0; // Монеты персонажа
            int defeatedEnemiesCounter = 0; // Счётчик убитых монстров

            /* Некоторые логические переменные */ 
            bool isWin = false; // Проверка победы
            bool isDeath = false;  // Проверка смерти
            bool isArmored = false; // Проверка защиты персонажа
            bool isCheck = false; // Для защиты от неправильного ввода

            /* Переменные противника*/
            int enemyHealth = 3;
            int enemyMaxHealth = 3;
            int enemyDamage = 1;
            int enemyLoot = 15;

            /* Переменные меню*/
            bool isExit = false;  // Выход из игры
            bool startGame = false;  // Начало игры
            bool watchLearning = false;  // Просмотр обучения
            bool setSettings = false; // Изменение настроек

            // Начальное меню игры
            while (true)
            {
                // Дефолтные значения
                isExit = false;
                startGame = false;
                watchLearning = false;
                setSettings = false;

                // Начальное меню в интерфейса
                Console.Clear();
                Console.WriteLine(">>..История Гуся..<<");
                Console.WriteLine("Доступные функции: ");
                Console.WriteLine("[1 - Начать играть]");
                Console.WriteLine("[2 - Помощь]");
                Console.WriteLine("[3 - Настройки]");
                Console.WriteLine("[4 - Выход]");
                string command = Console.ReadLine();

                // Просмотрим по функциям
                switch (command)
                {
                    case "1":
                        startGame = true;
                        break;
                    case "2":
                        watchLearning = true;
                        break;
                    case "3":
                        setSettings = true;
                        break;
                    case "4":
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Неправильная команда");
                        break;
                }

                // Начало игры или выход
                if (startGame || isExit)
                    break;
                // Просмотр помощи
                if(watchLearning)
                {
                    Console.Clear();
                    Console.WriteLine("Игровая помощь:");
                    Console.WriteLine("0) Будьте внимательней, монстры становятся сильней после каждой победы.");
                    Console.WriteLine("1) Игра не имеет конца.");
                    Console.WriteLine("2) Смысл - Убить как можно больше монстров");
                    Console.WriteLine("3) Здоровье - Ваш запас сил в походе.");
                    Console.WriteLine("4) Урон - Ваша сила.");
                    Console.WriteLine("5) Защита - Блокирует Х урона при получении.");
                    Console.WriteLine("6) Монеты - Служат для улучшения в магазине после победы.");
                    Console.WriteLine("7) Регенерация - Восстановление Х здоровья.");
                    Console.WriteLine("");
                    Console.WriteLine("Нажмите 'Enter' для выхода в меню...");
                    Console.ReadLine();
                }
                // Установка настроек
                if(setSettings)
                {
                    // Булка для проверки выхода из циклов
                    bool exit = false;

                    // Проверки выбора действия
                    bool isFore = false; // Шрифт
                    bool isBack = false; // Задний фон

                    // Выбор меню настроек
                    while(!exit)
                    {
                        Console.Clear();
                        Console.WriteLine("Меню настроек");
                        Console.WriteLine("1 - Настройка шрифта");
                        Console.WriteLine("2 - Настройка заднего фона");
                        Console.WriteLine("3 - Назад");
                        Console.Write("Выберите действие: ");
                        string choice = Console.ReadLine();

                        // Выбор функции
                        switch(choice)
                        {
                            case "1":
                                isFore = true;
                                exit = true;
                                break;
                            case "2":
                                isBack = true;
                                exit = true;
                                break;
                            case "3":
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Неправильная команда!");
                                break;
                        }
                    }

                    // Установка цвета фона
                    if(isBack)
                    {
                        isBack = false;
                        bool isSet = false;
                        while (!isSet)
                        {
                            Console.Clear();
                            Console.WriteLine("[Настройки цвета фона]");
                            Console.WriteLine("Красный - red или 1");
                            Console.WriteLine("Зелёный - green или 2");
                            Console.WriteLine("Жёлтый - yellow или 3");
                            Console.WriteLine("Белый - white или 4");
                            Console.WriteLine("Синий - blue или 5");
                            Console.WriteLine("Циановый - cyan или 6");
                            Console.WriteLine("Серый - gray или 7");
                            Console.WriteLine("Чёрный - black или 8");
                            Console.WriteLine("Подтвердить и выйти - setandexit или 0");
                            Console.Write("Ваше решение: ");
                            string color = Console.ReadLine();

                            // Установка цвета фона
                            switch (color)
                            {
                                case "0":
                                case "setandexit":
                                    isSet = true;
                                    break;
                                case "red":
                                case "1":
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    break;
                                case "green":
                                case "2":
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    break;
                                case "yellow":
                                case "3":
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    break;
                                case "white":
                                case "4":
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case "blue":
                                case "5":
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    break;
                                case "cyan":
                                case "6":
                                    Console.BackgroundColor = ConsoleColor.Cyan;
                                    break;
                                case "gray":
                                case "7":
                                    Console.BackgroundColor = ConsoleColor.Gray;
                                    break;
                                case "black":
                                case "8":
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                default:
                                    Console.WriteLine("Ошибка ввода, попробуйте ещё раз!");
                                    break;
                            }
                        }
                    }

                    // Установка цвета шрифта
                    if (isFore)
                    {
                        isFore = false;
                        bool isSet = false;
                        while (!isSet)
                        {
                            Console.Clear();
                            Console.WriteLine("[Настройки цвета шрифта]");
                            Console.WriteLine("Красный - red или 1");
                            Console.WriteLine("Зелёный - green или 2");
                            Console.WriteLine("Жёлтый - yellow или 3");
                            Console.WriteLine("Белый - white или 4");
                            Console.WriteLine("Синий - blue или 5");
                            Console.WriteLine("Циановый - cyan или 6");
                            Console.WriteLine("Серый - gray или 7");
                            Console.WriteLine("Чёрный - black или 8");
                            Console.WriteLine("Подтвердить и выйти - setandexit или 0");
                            Console.Write("Ваше решение: ");
                            string color = Console.ReadLine();

                            // Установка цвета шрифта
                            switch (color)
                            {
                                case "0":
                                case "setandexit":
                                    isSet = true;
                                    break;
                                case "red":
                                case "1":
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    break;
                                case "green":
                                case "2":
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;
                                case "yellow":
                                case "3":
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    break;
                                case "white":
                                case "4":
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                case "blue":
                                case "5":
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;
                                case "cyan":
                                case "6":
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    break;
                                case "gray":
                                case "7":
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    break;
                                case "black":
                                case "8":
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    break;
                                default:
                                    Console.WriteLine("Ошибка ввода, попробуйте ещё раз!");
                                    break;
                            }
                        }
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Нажмите Enter для подтверждения...");
                }
            }

            // Сама игра
            if(startGame)
            {
                Console.Clear();
                // Пока не умрём, будем работать
                while (!isDeath)
                {
                    // Проверка начальных действий
                    while (!isCheck)
                    {
                        // Небольшое историческое повествование для погружения в игру :D
                        switch (defeatedEnemiesCounter)
                        {
                            case 0:
                                Console.WriteLine("*Повествование*");
                                Console.WriteLine("**Погружение в игровой мир**");
                                Console.WriteLine("Вы очнулись внутри старого помещения...");
                                Console.WriteLine("В это же мгновенье на вас напрыгнул огромный паук.");
                                Console.WriteLine("Вы успели отпрыгнуть и впали в драку!");
                                Console.WriteLine("*...*");
                                Console.WriteLine("");
                                break;
                            case 1:
                                Console.WriteLine("*Повествование*");
                                Console.WriteLine("Вы успешно отбили атаку паука!");
                                Console.WriteLine("Вам кажется, что это всего-лишь сон...");
                                Console.WriteLine("... попробуйте наколдовать что-нибудь!");
                                Console.WriteLine("Некоторое время спустя Вы придумали себе улучшение способностей!");
                                Console.WriteLine("*...*");
                                Console.WriteLine("");
                                break;
                            case 2:
                                Console.WriteLine("*Повествование*");
                                Console.WriteLine("Вы хорошо справляетесь.");
                                Console.WriteLine("Продолжайте в том же духе!");
                                Console.WriteLine("*...*");
                                Console.WriteLine("");
                                break;
                            case 4:
                                Console.WriteLine("*Повествование*");
                                Console.WriteLine("Вы чувствуете сильное сопротивление со стороны Вашего разума.");
                                Console.WriteLine("Ваш Сон приготовил Вам новое испытание, будьте готовы к нему...");
                                Console.WriteLine("*...*");
                                Console.WriteLine("");
                                break;
                            case 5:
                                Console.WriteLine("*Повествование*");
                                Console.WriteLine("О Боже, этот монстр выглядит сильнее остальных...");
                                Console.WriteLine("Надеюсь, что у Вас хватит сил и стратегий, чтобы победить его!");
                                Console.WriteLine("*...*");
                                Console.WriteLine("");
                                break;
                            case 6:
                                Console.WriteLine("*Повествование*");
                                Console.WriteLine("Ну вот, основная часть пройдена, теперь Вы можете бесконечно бороздить просторы своего воображения!");
                                Console.WriteLine("Удачи! :>");
                                Console.WriteLine("");
                                break;
                        }

                        // Выводим некоторые хар-ки персонажа ...
                        Console.WriteLine("Характеристики персонажа: ");
                        Console.WriteLine("Убито монстров: {0}", defeatedEnemiesCounter);
                        Console.WriteLine("Здоровье: {0}/{1}", playerHealth, playerMaxHealth);
                        Console.WriteLine("Восст. здоровья: {0}", playerRegen);
                        Console.WriteLine("Урон: {0}", playerDamage);
                        Console.WriteLine("Защита: {0}", playerArmor);
                        Console.WriteLine("");
                        // ... и противника
                        Console.WriteLine("Характеристики противника: ");
                        Console.WriteLine("Здоровье: {0}/{1}", enemyHealth, enemyMaxHealth);
                        Console.WriteLine("Урон: {0}", enemyDamage);
                        Console.WriteLine("");
                        // Вывод доступных действий
                        Console.WriteLine("Ваши действия: ");
                        Console.WriteLine("[1 - Атаковать]");
                        Console.WriteLine("[2 - Защититься и восстановиться]");
                        string act = Console.ReadLine();

                        // Проверяем что выбрал игрок
                        switch (act)
                        {
                            case "1":
                                // Наносим урон противнику
                                enemyHealth -= playerDamage;
                                Console.WriteLine("[!] Вы атаковали противника и нанесли: -{0} ед. урона", playerDamage);
                                isCheck = true;
                                break;
                            case "2":
                                Console.WriteLine("[!] Вы подготовились к атаке противника.");
                                Console.WriteLine("[!] Защита +1 на следующую атаку противника.");
                                isArmored = true;
                                isCheck = true;
                                break;
                            default:
                                Console.WriteLine("Некорректное действие!");
                                Console.Clear();
                                break;
                        }
                    }

                    // Восстанавливаем защиту ввода
                    isCheck = false;

                    // Действие противника
                    if(enemyHealth > 0)
                    {
                        // Локальная переменная для проверки защиты персонажа
                        int tempDmg = enemyDamage;
                        // Проверяем защитился ли персонаж
                        if (isArmored)
                        {
                            tempDmg -= playerArmor;
                            // Доп. проверка
                            if (tempDmg < 0)
                                tempDmg = 0;
                        }

                        // Наносим урон персонажу
                        playerHealth -= tempDmg;

                        Console.WriteLine("[!] Противник нанёс вам урон: -{0} ед. здоровья", tempDmg);
                        // Проверяем на восст. здоровья (обязательно после получения урона)
                        if (isArmored)
                        {
                            // Восстанавливаем здоровье после атаки противника
                            playerHealth += playerRegen;
                            // Проверяем не переполнен ли наш запас здоровья
                            if (playerHealth > playerMaxHealth)
                                playerHealth = playerMaxHealth;
                            Console.WriteLine("[!] Восстановлено {0} ед. здоровья.", playerRegen);
                        }

                        // Обнуляем бронирование персонажа
                        isArmored = false;
                    }

                    // Проверка на смерть игрока
                    if (playerHealth <= 0) // Если игрок умер, конец игры...
                        isDeath = true;
                    if(enemyHealth <= 0) // Если умер противник, даём приз
                        isWin = true;

                    // Если мы выйграли, то даём призы игроку
                    if(isWin)
                    {
                        // Информация о победе
                        Console.WriteLine("[!] Вы выйграли.");
                        Console.WriteLine("[!] Награда: {0} монет.", enemyLoot);
                        // Добавляем счётчик убитых монстров
                        defeatedEnemiesCounter++;
                        // Даём деньги в кол-ве от лута с противника
                        playerMoney += enemyLoot;
                        // Обнуляем переменную победы
                        isWin = false;

                        // Устанавливаем новые значение противнику
                        if (defeatedEnemiesCounter % 5 == 0) // Босс
                        {
                            enemyMaxHealth += 7;
                            enemyHealth = enemyMaxHealth;
                            enemyDamage += 3;
                            enemyLoot += 10;
                        } 
                        else // Обычный монстр
                        {
                            enemyMaxHealth += 2;
                            enemyHealth = enemyMaxHealth;
                            if(defeatedEnemiesCounter % 2 == 0)
                                enemyDamage += 1;
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Нажмите любую клавишу для продолжения...");
                        Console.ReadLine();

                        // Выбор улучшения для игрока
                        bool isBuying = true;
                        while (isBuying)
                        {
                            Console.Clear();
                            // Предупреждение о сильном боссе 1 
                            if (defeatedEnemiesCounter % 5 == 0)
                                Console.WriteLine("Закупайтесь внимательней, следующий монстр - это босс!");

                            Console.WriteLine("");
                            Console.WriteLine("Ваши характеристики: ");
                            Console.WriteLine("Убито монстров: {0}", defeatedEnemiesCounter);
                            Console.WriteLine("Здоровье: {0}/{1}", playerHealth, playerMaxHealth);
                            Console.WriteLine("Восст. здоровья: {0}", playerRegen);
                            Console.WriteLine("Урон: {0}", playerDamage);
                            Console.WriteLine("Защита: {0}", playerArmor);
                            Console.WriteLine("");
                            Console.WriteLine("Победное меню: ");
                            Console.WriteLine("У Вас имеется {0} золота.", playerMoney);
                            Console.WriteLine("Что Вы хотите сделать/улучшить?");
                            Console.WriteLine("[1 - Улучшить макс. здоровье +3 (5 монет)]");
                            Console.WriteLine("[2 - Улучшить урон +1 (10 монет)]");
                            Console.WriteLine("[3 - Улучшить защиту +1 (10 монет)]");
                            Console.WriteLine("[4 - Улучшить регенерацию +1 (15 монет)]");
                            Console.WriteLine("[5 - Восстановить здоровье (5 монет)]");
                            Console.WriteLine("[6 - Выход из магазина]");
                            Console.WriteLine("");

                            // Предупреждение о сильном боссе 2
                            if(defeatedEnemiesCounter % 5 == 0)
                                Console.WriteLine("Закупайтесь внимательней, следующий монстр - это босс!");

                            string act = Console.ReadLine();

                            // Проверяем что выбрал игрок
                            switch(act)
                            {
                                case "1":
                                    if(playerMoney >= 5)
                                    {
                                        playerMaxHealth += 3;
                                        playerMoney -= 5;
                                        Console.WriteLine("[!] Вы приобрели улучшение на макс. здоровье.");
                                    }
                                    break;
                                case "2":
                                    if(playerMoney >= 10)
                                    {
                                        playerDamage += 1;
                                        playerMoney -= 10;
                                        Console.WriteLine("[!] Вы приобрели улучшение на урон.");
                                    }
                                    break;
                                case "3":
                                    if(playerMoney >= 10)
                                    {
                                        playerArmor += 1;
                                        playerMoney -= 10;
                                        Console.WriteLine("[!] Вы приобрели улучшение на защиту.");
                                    }
                                    break;
                                case "4":
                                    if(playerMoney >= 15)
                                    {
                                        playerRegen += 1;
                                        playerMoney -= 15;
                                        Console.WriteLine("[!] Вы приобрели улучшение на восстановление здоровья.");
                                    }
                                    break;
                                case "5":
                                    if(playerMoney >= 5)
                                    {
                                        playerHealth = playerMaxHealth;
                                        playerMoney -= 5;
                                        Console.WriteLine("[!] Вы восстановили себе здоровье.");
                                    }
                                    break;
                                case "6":
                                    isBuying = false;
                                    break;
                                default:
                                    Console.WriteLine("Некорректный выбор!");
                                    break;
                            }
                        }
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
                    Console.ReadLine();
                    Console.Clear();
                }

                // Если умерли во время битвы
                if (isDeath)
                {
                    Console.Clear();
                    Console.WriteLine("[!] Вы умерли. :C");
                    Console.WriteLine("");
                    Console.WriteLine("Нажмите любую клавишу для выхода из игры...");
                    Console.ReadLine();
                }
            }
        }
    }
}