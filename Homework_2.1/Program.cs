//Реверс строки/масиву. Без додаткового масиву. Складність О(n).

Console.Write("Type line here: ");
char[] array = Console.ReadLine().ToCharArray();

ReverseArray(array);

Console.WriteLine(array);

static void ReverseArray(char[] array)
{
    int start = 0;
    int end = array.Length - 1;

    while (start < end)
    {
        char tmp = array[start];
        array[start] = array[end];
        array[end] = tmp;

        start++;
        end--;
    }
}