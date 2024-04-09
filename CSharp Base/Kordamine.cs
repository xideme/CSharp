using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Введите символ для подсчета его вхождений:");
        char targetChar = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Переход на новую строку после ввода символа

        int totalChars = inputString.Length;
        int targetCharCount = 0;

        foreach (char ch in inputString)
        {
            if (ch == targetChar)
            {
                targetCharCount++;
            }
        }

        double percentage = (double)targetCharCount / totalChars * 100;

        Console.WriteLine($"Процент вхождения символа '{targetChar}' в строку: {percentage}%");
    }
}
