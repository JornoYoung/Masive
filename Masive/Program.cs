using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] array = ReadArray(rows, cols);

        SwapSymmetricRows(array);

        Console.WriteLine("Массив после обмена строк:");
        PrintArray(array);
    }

    /// <summary>
    /// Функция для чтения массива с ручным вводом.
    /// </summary>
    /// <param name="rows">Количество строк массива.</param>
    /// <param name="cols">Количество столбцов массива.</param>
    /// <returns>Двумерный массив, заполненный введенными значениями.</returns>
    static int[,] ReadArray(int rows, int cols)
    {
        int[,] array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Введите значение для [{i},{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return array;
    }

    /// <summary>
    /// Функция для обмена строк симметрично относительно вертикальной линии.
    /// </summary>
    /// <param name="array">Двумерный массив, в котором происходит обмен строк.</param>
    static void SwapSymmetricRows(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols / 2; j++)
            {
                int mirrorColIndex = cols - 1 - j;
                int temp = array[i, j];
                array[i, j] = array[i, mirrorColIndex];
                array[i, mirrorColIndex] = temp;
            }
        }
    }

    /// <summary>
    /// Функция для вывода массива.
    /// </summary>
    /// <param name="array">Двумерный массив, который нужно вывести.</param>
    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
