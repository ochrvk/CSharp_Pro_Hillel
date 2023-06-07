//Генератор випадкових символів. На вхід у символів, на виході рядок з випадковими символами.


Console.Write("Type the number of symbols: ");
int length = int.Parse(Console.ReadLine());

string randomString = GenerateRandomString(length);
Console.WriteLine("Random line: " + randomString);


static string GenerateRandomString(int length)
{
    Random random = new Random();
    const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    char[] result = new char[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = characters[random.Next(characters.Length)];
    }

    return new string(result);
}