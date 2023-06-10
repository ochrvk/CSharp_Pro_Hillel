/*
    1. Згенерувати впорядковану колоду карт
    2. Перемішати колоду карт
    3. Знайти позиції всіх тузів у колоді
    4. Перемістити всі пікові карти на початок колоди
    5. Відсортувати колоду
    6. Створіть консольну програму для карткової гри «21» з простими правилами:
        a. у грі 36 карт +
        b. вартість карток в окулярах: Туз - 11 очок; Король – 4 очки; Леді / Дама - 3 бали; Джек / Валет – 2 очки; Інші карти за їх номіналом +
        c. 2 гравці (ви та комп'ютер)
        d. мета гри - набрати 21 очко
        e. спочатку ви повинні ввести, хто отримує перші картки
        f. ви та комп'ютер отримуєте 2 карти відразу
        g. після цього кожен із вас вирішить, чого ви хочете? отримати ще одну карту або перестати отримувати карти (залежить від того, хто першим почав гру)
        h. якщо один з вас набрав 21 очко або 2 тузи, гра закінчена і виграє гравець з 21 очком або 2 тузами
        i. якщо один із гравців набирає більше 21 очка, гра закінчується, але в кінці раунду
        j. якщо у вас обох більше 21 очка гра закінчена та виграє гравець з меншою кількістю очок
        k. має бути можливість продовжувати грати
        l. повинна статистика за результатами всіх зіграних ігор
*/

BlackJack blackJack = new BlackJack();

while (true)
{
    Console.WriteLine("===== BlackJack =====");
    Console.WriteLine("(1) Start new game");
    Console.WriteLine("(2) Display Statistic");
    Console.WriteLine("(3) Execution of other tasks which not used in game");
    Console.WriteLine("(4) End game");
    Console.WriteLine("====================");
    Console.Write("Your choise: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            blackJack.StartGame();
            break;
        case "2":
            blackJack.DisplayStatistics();
            break;
        case "3":
            ShowOtherTasks();
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Incorrect type. Please try again");
            break;
    }
}

static void ShowOtherTasks()
{
    Deck deck = new Deck();
    Console.WriteLine("-Move Spades to Beginning-");
    deck.Mix();
    deck.MoveSpadesToBeginning();
    deck.ShowDeck();


    foreach (var acePosition in deck.FindAcePositions())
    {
        Console.WriteLine(acePosition);
    }
}