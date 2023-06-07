//Знайти позицію літери в алфавіті та перевести її в інший регістр

string alphabet = "abcdefghijklmnopqrstuvwxyz";

Console.Write("Type letter here: ");
char letter = Convert.ToChar(Console.ReadLine());
int position = 1;


if (Char.IsUpper(letter))
{
    position = alphabet.IndexOf(Char.ToLower(letter)) + 1;
    letter = Char.ToLower(letter);
}
else
{
    position = alphabet.IndexOf(letter) + 1;
    letter = Char.ToUpper(letter);
}

Console.WriteLine(letter);
Console.WriteLine(position);
