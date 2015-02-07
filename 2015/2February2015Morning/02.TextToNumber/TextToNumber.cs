using System;

class TextToNumber
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        long result = 0;
        for (int i = 0; i <= text.Length; i++)
        {
            if (text[i] == '@')
            {
                break;
            }
            else if (text[i] != '@')
            {
                if (char.IsDigit(text[i]))
                {
                    result *= text[i] - '0';
                }
                else if (char.IsLetter(text[i]))
                {
                    if (char.IsUpper(text[i]))
                    {
                        result += text[i] - 'A';//index == 1
                    }
                    else
                    {
                        result += text[i] - 'a';
                    }
                }
                else
                {
                    result %= m;
                }
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine(result);
    }
}