/*
 * Перевірка гіпотези Сиракуз: 
 * Візьмемо будь-яке натуральне число. 
 * Якщо воно парне - розділимо його навпіл, якщо непарне - помножимо на 3, додамо 1 і розділимо навпіл. 
 * Повторимо ці дії із знову отриманим числом. Гіпотеза свідчить, незалежно від вибору першого числа рано чи пізно ми отримаємо 1. 
 * На вхід – число, при кожній зміні – роздрукувати число. Зробити рекурсивно.
 */

Console.Write("Type a natural number: ");
int number = int.Parse(Console.ReadLine());

SyracuseHypothesis(number);

static void SyracuseHypothesis(int n)
{
    Console.WriteLine(n);

    if (n == 1)
    {
        Console.WriteLine("Hypothesis confirmed!");
        return;
    }

    if (n % 2 == 0)
    {
        SyracuseHypothesis(n / 2);
    }
    else
    {
        SyracuseHypothesis((n * 3) + 1);
    }
}