//Написати програму, яка виводить число літерами. Приклад: 117 - сто сімнадцять

string[] Units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
string[] Teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
string[] Tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

Console.Write("Type number here: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < -999 || number > 999)
{
    Console.WriteLine("Number is out of range.");
}
else
{
    string words = ConvertNumberToWords(number);
    Console.WriteLine("Number in words: " + words);

    string ConvertNumberToWords(int number)
    {
        if (number == 0)
            return "zero";

        if (number < 0)
            return "minus " + ConvertNumberToWords(Math.Abs(number));

        string words = "";

        if ((number / 100) > 0)
        {
            words += ConvertNumberToWords(number / 100) + " hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            if (number < 10)
                words += Units[number];
            else if (number < 20)
                words += Teens[number - 10];
            else
            {
                words += Tens[number / 10];
                if ((number % 10) > 0)
                    words += "-" + Units[number % 10];
            }
        }

        return words;
    }
}