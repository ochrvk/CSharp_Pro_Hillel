/*
    Розділювач рядка. 
    Дана строка та символ, потрібно розділити строку на кілька строк (масив строк) виходячи із заданого символу. 
    Наприклад: строка = "Лондон, Париж, Рим", а символ = ','. Результат = string[] { "Лондон", "Париж", "Рим" }.
*/

Console.Write("Type symbol here: ");
char symbol = Convert.ToChar(Console.ReadLine());

Console.Write("Type line here: ");
string line = Console.ReadLine();

List<string> lines = new List<string>();

int startIndex = 0;
for (int i = 0; i < line.Length; i++)
{
    if (line[i] == symbol)
    {
        lines.Add(line.Substring(startIndex, i - startIndex));
        startIndex = i + 1;
    }
}
lines.Add(line.Substring(startIndex));

Console.Write("{");
for (int j = 0; j < lines.Count; j++)
{
    if (j == lines.Count - 1)
    {
        Console.Write($"\"{lines.ElementAt(j)}\"");
    }
    else
    {
        Console.Write($"\"{lines.ElementAt(j)}\",");
    }
}
Console.Write("}");