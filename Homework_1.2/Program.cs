/*
    Розділювач рядка. 
    Дана строка та символ, потрібно розділити строку на кілька строк (масив строк) виходячи із заданого символу. 
    Наприклад: строка = "Лондон, Париж, Рим", а символ = ','. Результат = string[] { "Лондон", "Париж", "Рим" }.
*/


Console.Write("Type symbol here: ");
char symbol = Convert.ToChar(Console.ReadLine());

Console.Write("Type line here: ");
string line = Console.ReadLine();

string[] lines = line.Replace(" ", "").Split(symbol);


int i = 0;
Console.Write("{");
foreach (string l in lines)
{
    i++;
    if (i == lines.Length)
    {
        Console.Write($"\"{l}\"");
    }
    else
    {
        Console.Write($"\"{l}\",");
    }
}
Console.Write("}");
