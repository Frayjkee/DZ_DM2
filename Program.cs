// Задание 2. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


using System;

class Program
{
    static void Main()
    {
        // Генерируем случайный двумерный массив (3x3 в данном случае)
        int[,] twoDimensionalArray = GenerateRandomArray(3, 3);

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(twoDimensionalArray);

        // Меняем местами первую и последнюю строки массива
        SwapFirstAndLastRows(twoDimensionalArray);

        // Выводим массив после замены
        Console.WriteLine("\nМассив после замены:");
        PrintArray(twoDimensionalArray);
    }

    static int[,] GenerateRandomArray(int rowCount, int colCount)
    {
        Random random = new Random();
        int[,] array = new int[rowCount, colCount];

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                array[i, j] = random.Next(1, 10); // Генерируем случайное число от 1 до 9
            }
        }

        return array;
    }

    static void SwapFirstAndLastRows(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        // Проверка наличия хотя бы двух строк в массиве
        if (rowCount < 2)
        {
            Console.WriteLine("Массив содержит менее двух строк. Замена невозможна.");
            return;
        }

        // Меняем местами первую и последнюю строки
        for (int j = 0; j < colCount; j++)
        {
            int temp = array[0, j];
            array[0, j] = array[rowCount - 1, j];
            array[rowCount - 1, j] = temp;
        }
    }

    static void PrintArray(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
