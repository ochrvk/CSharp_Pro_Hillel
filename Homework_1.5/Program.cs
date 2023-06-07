//Поміняти місцями значення двох змінних (типу int) (без використання 3й)


Console.Write("Type first number here: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Type second number here: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Before: ");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

a = a ^ b;
b = a ^ b;
a = a ^ b;

Console.WriteLine("After: ");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
