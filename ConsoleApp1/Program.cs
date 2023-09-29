using System;

class Program
{
    static bool Get24(int[] numbers, int currentIndex, int currentResult)
    {
        if (currentIndex == numbers.Length)
        {
            return currentResult == 24;
        }

        int currentNumber = numbers[currentIndex];

        return Get24(numbers, currentIndex + 1, currentResult + currentNumber) ||
               Get24(numbers, currentIndex + 1, currentResult - currentNumber) ||
               Get24(numbers, currentIndex + 1, currentResult * currentNumber);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите 4 числа через пробел:");
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');

        if (numberStrings.Length != 4)
        {
            Console.WriteLine("Пожалуйста, введите ровно 4 числа.");
            return;
        }

        int[] numbers = new int[4];

        for (int i = 0; i < 4; i++)
        {
            if (!int.TryParse(numberStrings[i], out numbers[i]))
            {
                Console.WriteLine("Пожалуйста, введите корректные числа.");
                return;
            }
        }

        if (Get24(numbers, 0, 0))
        {
            Console.WriteLine("Можно получить 24 ");
        }
        else
        {
            Console.WriteLine("Нельзя получить 24");
        }
    }
}