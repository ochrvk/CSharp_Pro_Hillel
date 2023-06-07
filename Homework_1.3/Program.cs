// Пошук підстроки у строці

Console.Write("Type line here: ");
string line = Console.ReadLine();

Console.Write("Type substring here: ");
string substring = Console.ReadLine();

bool isSubstringFound = FindSubstring(line, substring);

if (isSubstringFound)
{
    Console.WriteLine("Substring found!");
}
else
{
    Console.WriteLine("Substring not found!");
}

Console.ReadLine();

bool FindSubstring(string line, string substring)
{
    if (line.Length < substring.Length)
        return false;

    for (int i = 0; i <= line.Length - substring.Length; i++)
    {
        int j;
        for (j = 0; j < substring.Length; j++)
        {
            if (line[i + j] != substring[j])
                break;
        }

        if (j == substring.Length)
            return true;
    }

    return false;
}