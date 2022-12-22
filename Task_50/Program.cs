/*
Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int GetNumber(string messege)
{
    int result = 0;
    while (true)
    {
        Console.Write(messege);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else Console.WriteLine("Не корректный ввод числа");
    }
    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 20);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void FindNumber(int[,] matrix, int number)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                Console.WriteLine($"Число {number} найден на позиции {i+1} {j+1}");
                count++;
            }
        }
    }
    if (count == 0) Console.WriteLine(number + "-> такого числа в массиве нет");
}

int rows = GetNumber("Введите количество строк -> ");
int columns = GetNumber("Введите количество столбцов -> ");
int number = GetNumber("Введите число для поиска -> ");
int[,] matrix = InitMatrix(rows, columns);

Console.WriteLine();
FindNumber(matrix, number);